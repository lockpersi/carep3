using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Models
{
    public class frmSysPermissaoModulo
    {
        private int _idUsuario;
        private int _idModulo;
        private string _nomeModulo;
        private string _nomeUsuario;

        public int IdUsuario
        {
            get { return _idUsuario ; }
            set { _idUsuario = value; }
        }

        public int IdModulo
        {
            get { return _idModulo ; }
            set { _idModulo = value; }
        }

        public string NomeModulo
        {
            get { return _nomeModulo ; }
            set { _nomeModulo = value; }
        }

        public string NomeUsuario
        {
            get { return _nomeUsuario ; }
            set { _nomeUsuario = value; }
        }
    }
}
