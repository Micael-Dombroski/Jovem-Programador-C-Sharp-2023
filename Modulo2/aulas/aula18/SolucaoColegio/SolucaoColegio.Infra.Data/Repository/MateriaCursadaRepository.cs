using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;
using SolucaoColegio.Domain.Repository;
using SolucaoColegio.Infra.Data.DAO;

namespace SolucaoColegio.Infra.Data.Repository
{
    public class MateriaCursadaRepository: IMateriaCursadaRepository
    {
        private MateriaCursadaDAO _dao;
        private AlunoDAO _alunoDAO;
        private MateriaDAO _materiaDAO;
        public MateriaCursadaRepository()
        {
            _dao = new MateriaCursadaDAO();
            _alunoDAO = new AlunoDAO();
            _materiaDAO = new MateriaDAO();
        }

        public ICollection<MateriaCursada> ConsultarPorAluno(int matricula)
        {
            Aluno alunoConsultado = _alunoDAO.ConsultarPorMatricula(matricula);
            if (alunoConsultado != null)
            {
                return _dao.ConsultarPorAluno(alunoConsultado);
            }
            return null;
        }

        public ICollection<MateriaCursada> ConsultarPorMateria(int materiaId)
        {
            Materia materiaConsultada = _materiaDAO.ConsultarPorId(materiaId);
            if (materiaConsultada != null)
            {
                return _dao.ConsultarPorMateria(materiaConsultada);
            }
            return null;
        }
        public ICollection<MateriaCursada> ConsultarPorMateria (string nome)
        {
            Materia materiaConsultada = _materiaDAO.ConsultarPorNome(nome);
            if (materiaConsultada != null)
            {
                return _dao.ConsultarPorMateria(materiaConsultada);
            }
            return null;
        }
        public ICollection<MateriaCursada> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (MateriaCursada objeto)
        {
            _dao.Editar(objeto);
        }
        public void Salvar(MateriaCursada objeto)
        {
            var alunoConsultado = _alunoDAO.ConsultarPorMatricula(objeto.AlunoCursando.Matricula);
            if (alunoConsultado != null)
            {
                _dao.Adicionar(objeto);
            }
        }
    }
}