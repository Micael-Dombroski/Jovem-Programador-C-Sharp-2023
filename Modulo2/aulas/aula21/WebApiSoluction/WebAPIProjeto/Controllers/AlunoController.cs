using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController:ControllerBase
    {
        private static List<Aluno> alunos = new List<Aluno>();

        [HttpGet]
        public IActionResult Get()
        {
            /*var aluno = new Aluno()
            {
                Matricula = 1,
                Nome = "Claire",
                Idade = 23
            };
            alunos.Add(aluno);
            aluno = new Aluno()
            {
                Matricula = 2,
                Nome = "Hinata",
                Idade = 15
            };
            alunos.Add(aluno);*/
            if (alunos.Count() > 0)
            {
                return Ok(alunos);
            }
            return BadRequest(new Resposta(400, "Não há nenhum aluno cadastrado"));
        }

        [HttpGet("{matricula}")]
        public IActionResult Get(int matricula)
        {
            /*var aluno = new Aluno()
            {
                Matricula = 1,
                Nome = "Claire",
                Idade = 23
            };
            alunos.Add(aluno);
            aluno = new Aluno()
            {
                Matricula = 2,
                Nome = "Hinata",
                Idade = 15
            };
            alunos.Add(aluno);*/
            foreach (var item in alunos)
            {
                if (item.Matricula == matricula)
                {
                    return Ok(item);
                }
            }
            //return $"Matrícula {matricula} não cadastrada";
            return BadRequest(new Resposta(400, "Aluno não encontrado"));
        }

        [HttpGet("{aluno}")]
        private Aluno Get(Aluno aluno)
        {
            foreach (var item in alunos)
            {
                if (item.Matricula == aluno.Matricula)
                {
                    return item;
                }
            }
            return null;
        }

        [HttpDelete("{matricula}")]
        public IActionResult Delete(int matricula)
        {
            foreach (var item in alunos)
            {
                if (item.Matricula == matricula)
                {
                    alunos.Remove(item);
                    return Ok(item);
                }
            }
            return BadRequest(new Resposta(400, "Matrícula não encontrada"));
        }

        [HttpPost]
        public IActionResult AlunoPost([FromBody] Aluno aluno)
        {
            if (Get(aluno) == null)
            {
                alunos.Add(aluno);
                return Ok(aluno);
            }   
            return BadRequest(new Resposta(400, "Matrícula já cadastrada"));
        }

        [HttpPut]
        public Aluno AlunoPut([FromBody] Aluno aluno)
        {
            alunos.Remove(aluno);
            alunos.Add(aluno);
            return aluno;
        }
    }
}