using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControleOnLine.BLL.Exceptions; 
using SistemaControleOnLine.DAL;
using SistemaControleOnLine.Entities;

namespace SistemaControleOnLine.BLL
{
    public class AlunosBo
    {
        private AlunoDao _alunoDao;

        public List<Aluno> ObterTodosOsAlunos()
        {
            _alunoDao = new AlunoDao();
            return _alunoDao.ObterTodosOsAlunos();
        }

        public Aluno ObterAlunoPeloId(int id)
        {
            _alunoDao = new AlunoDao();
            var aluno = _alunoDao.ObterAlunoPeloId(id);

            if (aluno == null)
            {
                throw new AlunoNaoEncontradoException();
            }
          
            return aluno;
        }

        public void InserirNovoAluno(Aluno aluno)
        {
            _alunoDao = new AlunoDao();

            ValidarCadastroAluno(aluno);

            var linhasAfetadas = _alunoDao.InserirAluno(aluno);

            if (linhasAfetadas == 0)
            {
                throw new AlunoNaoCadastradoException();
            }
        }

        public void ValidarCadastroAluno(Aluno aluno)
        {
            if(string.IsNullOrWhiteSpace(aluno.Nome) ||
                aluno.IdInstrumento == 0)
            {
                throw new AlunoNaoValidadoException();
            }
        }

        public void AlterarAluno(Aluno aluno)
        {
            _alunoDao = new AlunoDao();

            ValidarCadastroAluno(aluno);

            var linhasAfetadas = _alunoDao.AlterarAluno(aluno);

            if (linhasAfetadas == 0)
            {
                throw new  AlunoNaoAtualizadoException();
            }
        }
    }
}
