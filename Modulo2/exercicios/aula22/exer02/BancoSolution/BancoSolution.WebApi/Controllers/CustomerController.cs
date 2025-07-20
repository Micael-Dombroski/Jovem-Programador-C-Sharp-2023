using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;
using BancoSolution.Infra.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BancoSolution.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private CustomerRepository _repository = new();
        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _repository.GetAll();
            if (customers.Count > 0)
            {
                return Ok(customers);
            }
            return BadRequest("Não possui clientes cadastrados");
        }

        [HttpGet]
        [Route("{cpf}")]
        public IActionResult GetByCpf(string cpf)
        {
            var customer = _repository.GetByCpf(cpf);
            if (customer != null)
            {
                return Ok(customer);
            }
            return BadRequest("Cliente não cadastrado");
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Customer customer)
        {
            try
            {
                _repository.Insert(customer);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Customer customer)
        {
            try
            {
                _repository.Edit(customer);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("{cpf}")]
        public IActionResult Delete(string cpf)
        {
            try
            {
                Customer customer = _repository.GetByCpf(cpf);
                _repository.Delete(cpf);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}