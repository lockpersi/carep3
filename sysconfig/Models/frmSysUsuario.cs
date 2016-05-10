using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Models
{
    public class frmSysUsuario
    {
        private string _login;
        private string _nome;
        private string _senha;
        private string _descricao;
        private string _email;
        private int _idusuario;
        private int _ativoinativo;

        public string Login
        {
            get { return _login ; }
            set { _login = value; }
        }

        public string Nome
        {
            get { return _nome ; }
            set { _nome = value; }
        }

        public string Senha
        {
            get { return _senha ; }
            set { _senha = value; }
        }

        public string Descricao
        {
            get { return _descricao ; }
            set { _descricao = value; }
        }

        public string Email
        {
            get { return _email ; }
            set { _email = value; }
        }

        public int IdUsuario
        {
            get { return _idusuario ; }
            set { _idusuario = value; }
        }

        public int AtivoInativo
        {
            get { return _ativoinativo ; }
            set { _ativoinativo = value; }
        }
    }
}
