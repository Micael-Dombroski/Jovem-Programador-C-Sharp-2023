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
        public List<Produto> Get()
        {
            return produtos;
        }

        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            foreach (var item in produtos)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{id}")]
        public Produto Delete(int id)
        {
            foreach (var item in produtos)
            {
                if (item.Id == id)
                {
                    produtos.Remove(item);
                    return item;
                }
            }
            return null;
        }

        [HttpPost]
        public Produto ProdutoPost([FromBody] Produto produto)
        {
            if (Get(produto.Id) == null)
            {
                produtos.Add(produto);
                return produto;
            }   
            return null;
        }

        [HttpPut]
        public Produto ProdutoPut([FromBody] Produto produto)
        {
            produtos.Remove(produto);
            produtos.Add(produto);
            return produto;
        }
    }
}