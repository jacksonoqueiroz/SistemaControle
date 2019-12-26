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
    public class TurmasBo
    {
        private TurmasDao _turmaDao;

        public List<Turma> ObterTodosAsTurmas()
        {
            _turmaDao = new TurmasDao();
            return _turmaDao.ObterTodosAsTurmas();
        }


        public void InserirNovaTurma(Turma turma)
        {
            _turmaDao = new TurmasDao();

            var linhasAfetadas = _turmaDao.InserirNovaTurma(turma);

            if (linhasAfetadas == 0)
            {
                throw new TurmaNaoCadastradoException();
            }
        }
        
    }
}
