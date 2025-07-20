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
    public class MovimentoBancarioController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            MovimentoBancarioRepository _movimentoRepo = new MovimentoBancarioRepository();
            if (_movimentoRepo.ConsultarTodos() != null)
            {
                return Ok(_movimentoRepo.ConsultarTodos());
            }
            return BadRequest(new Resposta(400, "Não há nenhum movimento bancário registrado"));
        }

        [HttpGet("{agencia},{numero}")]
        public IActionResult Get(int agencia, int numero)
        {
            MovimentoBancarioRepository _movimentoRepo = new MovimentoBancarioRepository();
            ContaRepository _contaRepo = new ContaRepository();
            if (_contaRepo.ConsultarPorAgenciaENumero(agencia, numero) == null)
            {
                return BadRequest(new Resposta(400, "Não há nenhuma conta registrada com essa Agência e Número"));
            }
            if (_movimentoRepo.ConsultarPorConta(_contaRepo.ConsultarPorAgenciaENumero(agencia,numero)) != null)
            {
                return Ok(_movimentoRepo.ConsultarPorConta(_contaRepo.ConsultarPorAgenciaENumero(agencia,numero)));
            }
            return BadRequest(new Resposta(400, "Essa conta não possui nenhuma movimentação bancária registrada"));
        }

        [HttpGet("{movimentoBancario}")]
        private MovimentoBancario Get(MovimentoBancario movimentoBancario)
        {
            MovimentoBancarioRepository _movimentoRepo = new MovimentoBancarioRepository();
            foreach (var item in _movimentoRepo.ConsultarTodos())
            {
                if (item.Id == movimentoBancario.Id)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return BadRequest(new Resposta(400, "Não é possível excluir o registro de uma movimentação bancária"));
        }

        [HttpPost]
        public IActionResult movimentoBancarioPost([FromBody] MovimentoBancario movimentoBancario)
        {
            MovimentoBancarioRepository _movimentoRepo = new MovimentoBancarioRepository();
            ContaRepository _contaRepo = new ContaRepository();
            Conta  conta  = movimentoBancario.ContaUsada;
            if (_contaRepo.ConsultarPorAgenciaENumero(conta.Agencia, conta.Numero) == null)
            {
                return BadRequest(new Resposta(400, "Não há nenhuma conta cadastrada com essa agência e número"));
            }
            if (Get(movimentoBancario) == null)
            {
                _movimentoRepo.Salvar(movimentoBancario);
                return Ok(movimentoBancario);
            }   
            var resposta = new Resposta(400, "Já há um movimento bancário cadastrado com esse ID");
            return BadRequest(resposta);
        }

        [HttpPut]
        public IActionResult movimentoBancarioPut([FromBody] MovimentoBancario movimentoBancario)
        {
            return BadRequest(new Resposta(400, "Não é possível editar o registro de uma movimentação bancária"));
        }
    }
}