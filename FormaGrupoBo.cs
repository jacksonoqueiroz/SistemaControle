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
    public class FormaGrupoBo
    {
        private FormacaoGrupoDao _formaDao;

        public List<FormaGrupo> ObterTodasFormacoes()
        {
            _formaDao = new FormacaoGrupoDao();
            return _formaDao.ObterTodasFormacoes();
        }

        public FormaGrupo ObterTurmaPeloId(int id)
        {
            _formaDao = new FormacaoGrupoDao();

            var forma = _formaDao.ObterTurmaPeloId(id);

            if (forma == null)
            {
                throw new FormacaoNaoEncontradoException();
            }

            return forma;

        }
    }
}
