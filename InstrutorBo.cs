using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControleOnLine.DAL;
using SistemaControleOnLine.Entities;

namespace SistemaControleOnLine.BLL
{
    public class InstrutorBo
    {
        private InstrutorDao _instrutorDao;

        public List<Instrutor> ObterTodosOsInstrutores()
        {
            _instrutorDao = new InstrutorDao();
            return _instrutorDao.ObterTodosOsInstrutores();
        }
    }
}
