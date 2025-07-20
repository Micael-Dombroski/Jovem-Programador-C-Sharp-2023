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
    public class ClienteController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            if (_clienteRepo.ConsultarTodos() != null)
            {
                return Ok(_clienteRepo.ConsultarTodos());
            }
            return BadRequest(new Resposta(400, "Não há nenhum cliente cadastrado"));
        }

        [HttpGet("{cpf}")]
        public IActionResult Get(string cpf)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            if (_clienteRepo.ConsultarPorCpf(cpf) != null)
            {
                return Ok(_clienteRepo.ConsultarPorCpf(cpf));
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum cliente com esse CPF"));
        }

        [HttpGet("{cliente}")]
        private Cliente Get(Cliente cliente)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            foreach (var item in _clienteRepo.ConsultarTodos())
            {
                if (item.Cpf == cliente.Cpf)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{cpf}")]
        public IActionResult Delete(string cpf)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            if (_clienteRepo.ConsultarPorCpf(cpf) != null)
            {
                VendaRepository _vendaRepo = new VendaRepository();
                if (_vendaRepo.ConsultarPorCliente(cpf) == null)
                {
                    Cliente cliente = _clienteRepo.ConsultarPorCpf(cpf);
                    _clienteRepo.Excluir(cpf);
                    return Ok(cliente);
                }
                return BadRequest(new Resposta(400, "Não é possível excluir um cliente vinculado a uma venda"));
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum cliente com esse CPF"));
        }

        [HttpPost]
        public IActionResult ClientePost([FromBody] Cliente cliente)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            if (Get(cliente) == null)
            {
                _clienteRepo.Salvar(cliente);
                return Ok(cliente);
            }
            return BadRequest(new Resposta(400, "Um cliente com esse CPF já foi cadastrado"));
        }

        [HttpPut]
        public IActionResult ClientePut([FromBody] Cliente cliente)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            if (_clienteRepo.ConsultarPorCpf(cliente.Cpf) != null)
            {
                _clienteRepo.Editar(cliente, cliente.Cpf);
                return Ok(cliente);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum cliente com esse CPF"));
        }
    }
}