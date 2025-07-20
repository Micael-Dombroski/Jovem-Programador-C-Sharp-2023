using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MerceariaApiSoluction.WebAPIProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController: ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            foreach (var item in produtos)
            {
                if (item.Id == id)
                {
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhum produto com esse Id");
            return BadRequest(resposta);
        }

        [HttpGet("{produto}")]
        private Produto Get(Produto produto)
        {
            foreach (var item in produtos)
            {
                if (item.Id == produto.Id)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            foreach (var item in produtos)
            {
                if (item.Id == id)
                {
                    produtos.Remove(item);
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhum produto com esse Id");
            return BadRequest(resposta);
        }

        [HttpPost]
        public IActionResult ProdutoPost([FromBody] Produto produto)
        {
            if (Get(produto) == null)
            {
                produtos.Add(produto);
                return Ok(produto);
            }
            var resposta = new Resposta(400, "Um produto com esse Id já foi cadastrado");
            return BadRequest(resposta);
        }

        [HttpPut]
        public IActionResult ProdutoPut([FromBody] Produto produto)
        {
            produtos.Remove(produto);
            produtos.Add(produto);
            return Ok(produto);
        }
    }
}