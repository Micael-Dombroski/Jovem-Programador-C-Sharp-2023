using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MerceariaApiSoluction.WebAPIProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController: ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public List<Cliente> Get()
        {
            return clientes;
        }

        [HttpGet("{cpf}")]
        public Cliente Get(string cpf)
        {
            foreach (var item in clientes)
            {
                if (item.Cpf == cpf)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{cpf}")]
        public Cliente Delete(string cpf)
        {
            foreach (var item in clientes)
            {
                if (item.Cpf == cpf)
                {
                    clientes.Remove(item);
                    return item;
                }
            }
            return null;
        }

        [HttpPost]
        public Cliente ClientePost([FromBody] Cliente cliente)
        {
            if (Get(cliente.Cpf) == null)
            {
                clientes.Add(cliente);
                return cliente;
            }   
            return null;
        }

        [HttpPut]
        public Cliente ClientePut([FromBody] Cliente cliente)
        {
            clientes.Remove(cliente);
            clientes.Add(cliente);
            return cliente;
        }
    }
}