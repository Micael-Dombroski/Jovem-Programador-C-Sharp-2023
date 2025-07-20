using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BancoApiSoluction.WebAPIProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController: ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(clientes);
        }

        [HttpGet("{cpf}")]
        public IActionResult Get(string cpf)
        {
            foreach (var item in clientes)
            {
                if (item.CPF == cpf)
                {
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhum cliente com esse CPF");
            return BadRequest(resposta);
        }

        [HttpGet("{cliente}")]
        private Cliente Get(Cliente cliente)
        {
            foreach (var item in clientes)
            {
                if (item.CPF == cliente.CPF)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{cpf}")]
        public IActionResult Delete(string cpf)
        {
            foreach (var item in clientes)
            {
                if (item.CPF == cpf)
                {
                    clientes.Remove(item);
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhum cliente com esse CPF");
            return BadRequest(resposta);
        }

        [HttpPost]
        public IActionResult clientePost([FromBody] Cliente cliente)
        {
            if (Get(cliente) == null)
            {
                clientes.Add(cliente);
                return Ok(cliente);
            }   
            var resposta = new Resposta(400, "Já há um cliente cadastrado com esse CPF");
            return BadRequest(resposta);
        }

        [HttpPut]
        public IActionResult clientePut([FromBody] Cliente cliente)
        {
            clientes.Remove(cliente);
            clientes.Add(cliente);
            return Ok(cliente);
        }
    }
}