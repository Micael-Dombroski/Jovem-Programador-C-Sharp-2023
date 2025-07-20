using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;
using BancoSolution.Domain.Repository;
using BancoSolution.Infra.Data.DAO;

namespace BancoSolution.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private UsuarioDAO _dao;
        public UsuarioRepository()
        {
            _dao = new UsuarioDAO();
        }
        public Usuario ConsultarPorLoginESenha(string login, string senha)
        {
            Usuario usuario = _dao.ConsultarPorLoginESenha(login,senha);
            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado");
            }
            else
            {
                return usuario;
            }
        }

        public ICollection<Usuario> ConsultarTodos()
        {
            if (_dao.ConsultarTodos() != null)
            {
                return _dao.ConsultarTodos();
            }
            else
            {
                throw new Exception("Não há nenhum Usuário cadastrado");
            }
        }

        public void Editar(Usuario objeto)
        {
            bool usuarioEncontrado = false;
            if (_dao.ConsultarTodos() != null)
            {
                foreach (var item in _dao.ConsultarTodos())
                {
                    if (objeto.Equals(item) && objeto.LoginUsuario == item.LoginUsuario)
                    {
                        _dao.Editar(objeto);
                        usuarioEncontrado = true;
                    }
                    else if (objeto.LoginUsuario == item.LoginUsuario)
                    {
                        throw new Exception("Já existe um usuário com este Login");
                    }
                }
                if (usuarioEncontrado == false)
                {
                    throw new Exception("Esse usuário não está cadastrado");
                }
            }
            else
            {
                throw new Exception("Não há nenhum Usuário cadastrado");
            }
        }


        public void Excluir(Usuario objeto)
        {
            Usuario usuario = _dao.ConsultarPorLoginESenha(objeto.LoginUsuario, objeto.SenhaUsuario);
            if (usuario != null)
            {
                _dao.Excluir(objeto);
            }
            else
            {
                throw new Exception("Esse usuário não está cadastrado");
            }
        }

        public void Salvar(Usuario objeto)
        {
            Usuario usuario = _dao.ConsultarPorLoginESenha(objeto.LoginUsuario, objeto.SenhaUsuario);
            if (usuario == null)
            {
                _dao.Adicionar(objeto);
            }
            else
            {
                throw new Exception("Esse usuário já está cadastrado");
            }
        }
    }
}