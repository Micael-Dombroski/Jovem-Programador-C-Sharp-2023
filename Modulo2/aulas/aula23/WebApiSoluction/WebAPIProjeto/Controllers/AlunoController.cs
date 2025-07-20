using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace WebAPIProjeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController:ControllerBase
    {
        private static List<Aluno> alunos = new List<Aluno>();

        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            if (alunos.Count() > 0)
            {
                return Ok(alunos);
            }
            return BadRequest(new Resposta(400, "Não há nenhum aluno cadastrado"));
        }

        [HttpGet("{matricula}")]
        [Authorize]
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
        [Authorize]
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
        [Authorize]
        public Aluno AlunoPut([FromBody] Aluno aluno)
        {
            alunos.Remove(aluno);
            alunos.Add(aluno);
            return aluno;
        }

        private string generateJwtToken(Aluno aluno) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("1234567890123456");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("matricula", aluno.Matricula.ToString())}),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        [HttpPost]
        [Route("autenticacao")]
        public IActionResult AutenticacaoPost([FromBody] Aluno aluno)
        {
            string token = null;
            foreach (var item in alunos)
            {
                if (item.Equals(aluno))
                {
                    token = generateJwtToken(aluno);
                    break;
                }
            }
            if (token == null)
            {
                return BadRequest(new Resposta(400, "Aluno inválido"));
            }
            return Ok(token);
        }
    }
}