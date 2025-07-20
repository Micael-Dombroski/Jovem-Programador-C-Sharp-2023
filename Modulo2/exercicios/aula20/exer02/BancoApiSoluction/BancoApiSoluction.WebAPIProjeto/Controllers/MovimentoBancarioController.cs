using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BancoApiSoluction.WebAPIProjeto
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovimentoBancarioController: ControllerBase
    {
        private static List<MovimentoBancario> movimentos = new List<MovimentoBancario>();

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(movimentos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            foreach (var item in movimentos)
            {
                if (item.Id == id)
                {
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhum movimento bancário com esse ID");
            return BadRequest(resposta);
        }

        [HttpGet("{movimentoBancario}")]
        private MovimentoBancario Get(MovimentoBancario movimentoBancario)
        {
            foreach (var item in movimentos)
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
            foreach (var item in movimentos)
            {
                if (item.Id == id)
                {
                    movimentos.Remove(item);
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Não foi possível encontrar nenhum movimento bancário com esse ID");
            return BadRequest(resposta);
        }

        [HttpPost]
        public IActionResult movimentoBancarioPost([FromBody] MovimentoBancario movimentoBancario)
        {
            if (Get(movimentoBancario) == null)
            {
                movimentos.Add(movimentoBancario);
                return Ok(movimentoBancario);
            }   
            var resposta = new Resposta(400, "Já há um movimento bancário cadastrado com esse ID");
            return BadRequest(resposta);
        }

        [HttpPut]
        public IActionResult movimentoBancarioPut([FromBody] MovimentoBancario movimentoBancario)
        {
            movimentos.Remove(movimentoBancario);
            movimentos.Add(movimentoBancario);
            return Ok(movimentoBancario);
        }
    }
}