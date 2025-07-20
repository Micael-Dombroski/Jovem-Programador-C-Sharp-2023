using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MerceariaSolution.Domain.Entidade;
using MerceariaSolution.Infra.Data.Repository;

namespace MerceariaSoluction.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            ProdutoRepository _produtoRepo = new ProdutoRepository();
            if (_produtoRepo.ConsultarTodos() != null)
            {
                return Ok(_produtoRepo.ConsultarTodos());
            }
            return BadRequest(new Resposta(400, "Não há nenhum produto cadastrado"));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ProdutoRepository _produtoRepo = new ProdutoRepository();
            if (_produtoRepo.ConsultarPorId(id) != null)
            {
                return Ok(_produtoRepo.ConsultarPorId(id));
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum produto com esse Id"));
        }

        [HttpGet("{produto}")]
        private Produto Get(Produto produto)
        {
            ProdutoRepository _produtoRepo = new ProdutoRepository();
            foreach (var item in _produtoRepo.ConsultarTodos())
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
            ProdutoRepository _produtoRepo = new ProdutoRepository();
            if (_produtoRepo.ConsultarPorId(id) != null)
            {
                VendaRepository _vendaRepo = new VendaRepository();
                foreach (var item in _vendaRepo.ConsultarTodos())
                {
                    if (item.ProdutoVendido.Id == id)
                    {
                        return BadRequest(new Resposta(400, "Não é possível excluir um produto que já está vinculado a uma venda"));
                    }
                }
                Produto produto = _produtoRepo.ConsultarPorId(id);
                _produtoRepo.Excluir(id);
                return Ok(produto);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum produto com esse Id"));
        }

        [HttpPost]
        public IActionResult ProdutoPost([FromBody] Produto produto)
        {
            ProdutoRepository _produtoRepo = new ProdutoRepository();
            if (Get(produto) == null)
            {
                _produtoRepo.Salvar(produto);
                return Ok(produto);
            }
            return BadRequest(new Resposta(400, "Um produto com esse Id já foi cadastrado"));
        }

        [HttpPut]
        public IActionResult ProdutoPut([FromBody] Produto produto)
        {
            ProdutoRepository _produtoRepo = new ProdutoRepository();
            if (_produtoRepo.ConsultarPorId(produto.Id) != null)
            {
                _produtoRepo.Editar(produto);
                return Ok(produto);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum produto com esse Id"));
        }
    }
}