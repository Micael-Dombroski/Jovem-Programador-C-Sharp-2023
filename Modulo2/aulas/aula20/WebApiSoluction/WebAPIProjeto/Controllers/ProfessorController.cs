using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private static List<Professor> professores = new List<Professor>();

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(professores);
        }

        /*[HttpGet("{matricula}")]
        public IActionResult Get(int matricula)
        {
            foreach (var item in professores)
            {
                if (item.Matricula == matricula)
                {
                    return Ok(item);
                }
            }
            return NoContent();
        }*/

        [HttpGet("{matricula}")]
        public IActionResult Get(int matricula)
        {
            foreach (var item in professores)
            {
                if (item.Matricula == matricula)
                {
                    return Ok(item);
                }
            }
            var resposta = new Resposta(400, "Matrícula não encontrada");
            return BadRequest(resposta);
        }

        [HttpDelete("{matricula}")]
        public Professor Delete(int matricula)
        {
            foreach (var item in professores)
            {
                if (item.Matricula == matricula)
                {
                    professores.Remove(item);
                    return item;
                }
            }
            return null;
        }

        [HttpPost]
        public Professor ProfessorPost([FromBody] Professor professor)
        {
            if (Get(professor.Matricula) == null)
            {
                professores.Add(professor);
                return professor;
            }   
            return null;
        }

        [HttpPut]
        public Professor professorPut([FromBody] Professor professor)
        {
            professores.Remove(professor);
            professores.Add(professor);
            return professor;
        }
    }
}