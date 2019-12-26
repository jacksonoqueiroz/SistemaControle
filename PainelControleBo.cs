using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControleOnLine.DAL;
using SistemaControleOnLine.Entities;

namespace SistemaControleOnLine.BLL
{
    public class PainelControleBo
    {
        private PainelControleDao _painelDao;

        public List<PainelControle> ObterTodosOsControles()
        {
            _painelDao = new PainelControleDao();
            return _painelDao.ObterTodosOsControles();
        }
    }
}
