using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Models
{
    public class frmSysPermissao
    {
        private int _idprograma;
        private string _nome_formulario;
        private string _login;
        private string _nome_chamada;
        private int _id_modulo;
        private string _nome_modulo;
        private int _inserir;
        private int _alterar;
        private int _deletar;

        public int IdPrograma
        {
            get { return _idprograma ; }
            set { _idprograma = value; }
        }

        public string Nome_Formulario
        {
            get { return _nome_formulario ; }
            set { _nome_formulario = value; }
        }

        public string Login
        {
            get { return _login ; }
            set { _login = value; }
        }

        public string Nome_Chamada
        {
            get { return _nome_chamada ; }
            set { _nome_chamada = value; }
        }

        public int Id_Modulo
        {
            get { return _id_modulo ; }
            set { _id_modulo = value; }
        }

        public string Nome_Modulo
        {
            get { return _nome_modulo ; }
            set { _nome_modulo = value; }
        }

        public int Inserir
        {
            get { return _inserir ; }
            set { _inserir = value; }
        }

        public int Alterar
        {
            get { return _alterar ; }
            set { _alterar = value; }
        }

        public int Deletar
        {
            get { return _deletar ; }
            set { _deletar = value; }
        }
    }
}
