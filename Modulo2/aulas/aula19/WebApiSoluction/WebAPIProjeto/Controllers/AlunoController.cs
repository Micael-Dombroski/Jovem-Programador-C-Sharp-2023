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
        public List<Aluno> Get()
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
            return alunos;
        }

        [HttpGet("{matricula}")]
        public Aluno Get(int matricula)
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
                    return item;
                }
            }
            //return $"Matrícula {matricula} não cadastrada";
            return null;
        }

        [HttpDelete("{matricula}")]
        public Aluno Delete(int matricula)
        {
            foreach (var item in alunos)
            {
                if (item.Matricula == matricula)
                {
                    alunos.Remove(item);
                    return item;
                }
            }
            return null;
        }

        [HttpPost]
        public Aluno AlunoPost([FromBody] Aluno aluno)
        {
            if (Get(aluno.Matricula) == null)
            {
                alunos.Add(aluno);
                return aluno;
            }   
            return null;
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