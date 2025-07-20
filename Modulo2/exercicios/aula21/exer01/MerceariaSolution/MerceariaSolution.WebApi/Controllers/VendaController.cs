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
    public class VendaController: ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            VendaRepository _vendaRepo = new VendaRepository();
            ICollection<Venda> vendas = _vendaRepo.ConsultarTodos();
            if (vendas != null)
            {
                return Ok(vendas);
            }
            return BadRequest(new Resposta(400, "Não há nenhuma venda cadastrada"));
        }

        [HttpGet("{cpf}")]
        public IActionResult Get(string cpf)
        {
            VendaRepository _vendaRepo = new VendaRepository();
            ICollection<Venda> vendasPorCliente = _vendaRepo.ConsultarPorCliente(cpf);
            if (vendasPorCliente != null)
            {
                return Ok(vendasPorCliente);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhuma venda vinculada a esse cliente"));
        }

        [HttpGet("{venda}")]
        private Venda Get(Venda venda)
        {
            VendaRepository _vendaRepo = new VendaRepository();
            ICollection<Venda> vendas = _vendaRepo.ConsultarTodos();
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
            return BadRequest(new Resposta(405, "Não é possível deletar uma Venda"));
        }

        [HttpPost]
        public IActionResult vendaPost([FromBody] Venda venda)
        {
            VendaRepository _vendaRepo = new VendaRepository();
            if (Get(venda) == null)
            {
                _vendaRepo.Salvar(venda);
                return Ok(venda);
            }
            return BadRequest(new Resposta(400, "Uma venda com esse Id já foi cadastrada"));
        }

        [HttpPut]
        public IActionResult vendaPut([FromBody] Venda venda)
        {
            return BadRequest(new Resposta(400, "Não é possível editar uma venda"));
        }
    }
}