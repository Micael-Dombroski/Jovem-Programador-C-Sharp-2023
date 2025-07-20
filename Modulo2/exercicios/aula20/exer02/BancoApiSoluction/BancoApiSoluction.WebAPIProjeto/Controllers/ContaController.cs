using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BancoApiSoluction.WebAPIProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContaController: ControllerBase
    {
        private static List<Conta> contas = new List<Conta>();

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(contas);
        }

        [HttpGet("{agencia},{numero}")]
        public IActionResult Get(int agencia, int numero)
        {
            foreach (var item in contas)
            {
                if (item.Agencia == agencia && item.Numero == numero)
                {
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhuma conta com essa Agência e Número");
            return BadRequest(resposta);
        }

        [HttpGet("{Conta}")]
        private Conta Get(Conta conta)
        {
            foreach (var item in contas)
            {
                if (item.Agencia == conta.Agencia && item.Numero == conta.Numero)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{agencia},{numero}")]
        public IActionResult Delete(int agencia, int numero)
        {
            foreach (var item in contas)
            {
                if (item.Agencia == agencia && item.Numero == numero)
                {
                    contas.Remove(item);
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhuma conta com essa Agência e Número");
            return BadRequest(resposta);
        }

        [HttpPost]
        public IActionResult ContaPost([FromBody] Conta conta)
        {
            if (Get(conta) == null)
            {
                contas.Add(conta);
                return Ok(conta);
            }   
            var resposta = new Resposta(400, "Já há uma conta cadastrada com essa Agência e Número");
            return BadRequest(resposta);
        }

        [HttpPut]
        public IActionResult ContaPut([FromBody] Conta Conta)
        {
            contas.Remove(Conta);
            contas.Add(Conta);
            return Ok(Conta);
        }
    }
}