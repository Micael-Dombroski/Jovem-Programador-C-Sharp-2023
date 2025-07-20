using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MerceariaApiSoluction.WebAPIProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController: ControllerBase
    {
        private static List<Venda> vendas = new List<Venda>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(vendas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            foreach (var item in vendas)
            {
                if (item.IdVenda == id)
                {
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhuma venda com esse Id");
            return BadRequest(resposta);
        }

        [HttpGet("{venda}")]
        private Venda Get(Venda venda)
        {
            foreach (var item in vendas)
            {
                if (item.IdVenda == venda.IdVenda)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            foreach (var item in vendas)
            {
                if (item.IdVenda == id)
                {
                    vendas.Remove(item);
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhuma venda com esse Id");
            return BadRequest(resposta);
        }

        [HttpPost]
        public IActionResult vendaPost([FromBody] Venda venda)
        {
            if (Get(venda) == null)
            {
                vendas.Add(venda);
                return Ok(venda);
            }
            var resposta = new Resposta(400, "Uma venda com esse Id já foi cadastrada");
            return BadRequest(resposta);
        }

        [HttpPut]
        public IActionResult vendaPut([FromBody] Venda venda)
        {
            vendas.Remove(venda);
            vendas.Add(venda);
            return Ok(venda);
        }
    }
}