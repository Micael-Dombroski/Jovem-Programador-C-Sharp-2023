using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BancoSolution.Domain.Entidade;
using BancoSolution.Infra.Data.Repository;

namespace BancoSolution.WebApi.Controllers
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
            return BadRequest(new Resposta(400, "Não há nenhum correnstista cadastrado"));
        }

        [HttpGet("{cpf}")]
        public IActionResult Get(string cpf)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            Cliente cliente = _clienteRepo.ConsultarPorCpf(cpf);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum correntista com esse CPF"));
        }

        [HttpGet("{cliente}")]
        private Cliente Get(Cliente cliente)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            foreach (var item in _clienteRepo.ConsultarTodos())
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
            try
            {
                ClienteRepository _clienteRepo = new ClienteRepository();
                Cliente cliente = _clienteRepo.ConsultarPorCpf(cpf);
                if (_clienteRepo.ConsultarPorCpf(cpf) != null)
                {
                    ContaRepository _contaRepo = new ContaRepository();
                    if (_contaRepo.ConsultarTodos() is null)
                    {
                        List<Conta> contas = _contaRepo.ConsultarTodos();
                        foreach (Conta item in contas)
                        {
                            if(item.Correntista.Equals(cliente))
                            {
                                return BadRequest(new Resposta(400, "Não é possível excluir um correnstista que está vinculado a uma conta"));
                            }
                        }
                    }
                    _clienteRepo.Excluir(cpf);
                    return Ok(cliente);
                }
                return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum correntista com esse CPF"));
            }
            catch (Exception e)
            {
                return BadRequest(new Resposta(400, $"{e.Message}"));
            }
        }

        [HttpPost]
        public IActionResult clientePost([FromBody] Cliente cliente)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            if (Get(cliente) == null)
            {
                _clienteRepo.Salvar(cliente);
                return Ok(cliente);
            }
            return BadRequest(new Resposta(400, "Já há um correntista cadastrado com esse CPF"));
        }

        

        [HttpPut]
        public IActionResult clientePut([FromBody] Cliente cliente)
        {
            ClienteRepository _clienteRepo = new ClienteRepository();
            if (_clienteRepo.ConsultarPorCpf(cliente.CPF) != null)
            {
                _clienteRepo.Editar(cliente);
                return Ok(cliente);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhum correntista com esse CPF"));
        }
    }
}