using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControleOnLine.BLL.Exceptions;
using SistemaControleOnLine.DAL;
using SistemaControleOnLine.Entities;

namespace SistemaControleOnLine.BLL.Autenticacao
{
    public class LoginBo
    {
        private UsuarioDao _usuarioDao;

        public Usuario ObterUsuarioParaLogar(string nomeusuario, string senha)
        {
            _usuarioDao = new UsuarioDao();

            var usuario =_usuarioDao.ObterUsuarioPeloUsuarioESenha(nomeusuario, senha);
            
            if (usuario == null)
            {
                throw new UsuarioNaoCadastradoException() ;
            }

            else
            {
                return usuario;      
            }

        }
    }
}
