using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;
using BancoSolution.Infra.Data.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BancoSolution.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController: ControllerBase
    {
        private static string token = null;
        [HttpGet]
        [Authorize]
        public IActionResult Get() 
        {
            
            try
            {
                UsuarioRepository _usuarioRepo = new UsuarioRepository();
                ICollection<Usuario> usuarios = _usuarioRepo.ConsultarTodos();
                return Ok(usuarios);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{login}/{senha}")]
        [Authorize]
        public IActionResult Get(string login, string senha)
        {
            try
            {
                UsuarioRepository _usuarioRepo = new UsuarioRepository();
                Usuario usuario = _usuarioRepo.ConsultarPorLoginESenha(login, senha);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{login}/{senha}")]
        [Authorize]
        public IActionResult Delete(string login, string senha)
        {
            try
            {
                UsuarioRepository _usuarioRepo = new UsuarioRepository();
                Usuario usuario = _usuarioRepo.ConsultarPorLoginESenha(login, senha);
                _usuarioRepo.Excluir(usuario);
                return Ok(usuario);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        [HttpPost]
        public IActionResult ProdutoPost([FromBody] Usuario usuario)
        {
            try
            {
                UsuarioRepository _usuarioRepo = new UsuarioRepository();
                _usuarioRepo.Salvar(usuario);
                return Ok("Usuário cadastrado com sucesso");
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public IActionResult ProdutoPut([FromBody] Usuario usuario)
        {
            try
            {
                UsuarioRepository _usuarioRepo = new UsuarioRepository();
                _usuarioRepo.Editar(usuario);
                return Ok(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        private string generateJwtToken(Usuario usuario) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("1234567890123456");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", usuario.Id.ToString())}),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        [HttpPost]
        [Route("autenticacao/{login}/{senha}")]
        public IActionResult AutenticacaoPost(string login, string senha)
        {
            token = null;
            try
            {
                UsuarioRepository _usuarioRepo = new UsuarioRepository();
                Usuario  usuario = _usuarioRepo.ConsultarPorLoginESenha(login,senha);
                if (usuario != null)
                {
                    token = generateJwtToken(usuario);
                }
                if (token == null)
                {
                    return BadRequest(new Resposta(400, "Usuário inválido"));
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
            return Ok(token);
        }
    }
}