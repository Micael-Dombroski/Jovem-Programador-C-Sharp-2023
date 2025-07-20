using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BancoSolution.Domain.Entidade;
using BancoSolution.Infra.Data.Repository;
using System.IO;

namespace BancoSolution.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContaController: ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            ContaRepository _contaRepo = new ContaRepository();
            if (_contaRepo.ConsultarTodos() != null)
            {
                return Ok(_contaRepo.ConsultarTodos());
            }
            return BadRequest(new Resposta(400, "Não há nenhuma conta cadastrada"));
        }

        [HttpGet("{agencia},{numero}")]
        public IActionResult Get(int agencia, int numero)
        {
            ContaRepository _contaRepo = new ContaRepository();
            if (_contaRepo.ConsultarPorAgenciaENumero(agencia,numero) != null)
            {
                Conta conta = _contaRepo.ConsultarPorAgenciaENumero(agencia,numero);
                return Ok(conta);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhuma conta com essa Agência e Número"));
        }

        [HttpGet("{conta}")]
        private Conta Get(Conta conta)
        {
            ContaRepository _contaRepo = new ContaRepository();
            if (_contaRepo.ConsultarPorAgenciaENumero(conta.Agencia, conta.Numero) != null)
            {
                return _contaRepo.ConsultarPorAgenciaENumero(conta.Agencia, conta.Numero);
            }
            return null;
        }

        [HttpDelete("{agencia},{numero}")]
        public IActionResult Delete(int agencia, int numero)
        {
            ContaRepository _contaRepo = new ContaRepository();
            if (_contaRepo.ConsultarPorAgenciaENumero(agencia,numero) != null)
            {
                Conta conta = _contaRepo.ConsultarPorAgenciaENumero(agencia,numero);
                MovimentoBancarioRepository _movimentoRepo = new MovimentoBancarioRepository();
                if (_movimentoRepo.ConsultarPorConta(conta) != null)
                {
                    return BadRequest(new Resposta(400, "Não é possível excluir uma conta que já efetuou algum movimento bancário"));
                }
                _contaRepo.Excluir(agencia,numero);
                return Ok(conta);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhuma conta com essa Agência e Número"));
        }

        [HttpPost]
        public IActionResult ContaPost([FromBody] Conta conta)
        {
            Conta novaConta = conta;
            if (conta.TipoConta > 3 || conta.TipoConta < 1)
            {
                return BadRequest(new Resposta(400, "Tipo de Conta Inválido"));
            }
            ContaRepository _contaRepo = new ContaRepository();
            if (Get(novaConta) == null)
            {
                _contaRepo.Salvar(novaConta);
                return Ok(novaConta);
            }   
            return BadRequest(new Resposta(400, "Já há uma conta cadastrada com essa Agência e Número"));
        }

        [HttpPut]
        public IActionResult ContaPut([FromBody] Conta conta)
        {
            if (conta.TipoConta > 3 || conta.TipoConta < 1)
            {
                return BadRequest(new Resposta(400, "Tipo de Conta Inválido"));
            }
            ContaRepository _contaRepo = new ContaRepository();
            if (_contaRepo.ConsultarPorAgenciaENumero(conta.Agencia, conta.Numero) != null)
            {
                _contaRepo.Editar(conta);
                return Ok(conta);
            }
            return BadRequest(new Resposta(400, "Não foi possível encontrar nenhuma conta com essa Agência e Número"));
        }
    }
}