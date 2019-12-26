using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControleOnLine.DAL;
using SistemaControleOnLine.Entities;

namespace SistemaControleOnLine.BLL
{
    public class InstrumentoBo
    {
        private InstrumentoDao _instrumentoDao;

        public List<Instrumento> ObterTodosOsInstrumentos()
        {
            _instrumentoDao = new InstrumentoDao();
            return _instrumentoDao.ObterTodosOsInstrumentos();
        }
    }
}
