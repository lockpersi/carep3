using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Models
{
    public class frmSysProgramas
    {
        private string _nome_form;
        private string _form_descricao;
        private string _nome_chamada;
        private string _modulo;
        private int _id_modulo;

        public string Nome_Form
        {
            get { return _nome_form ; }
            set { _nome_form = value; }
        }

        public string Form_Descricao
        {
            get { return _form_descricao ; }
            set { _form_descricao = value; }
        }

        public string Nome_Chamada
        {
            get { return _nome_chamada ; }
            set { _nome_chamada = value; }
        }

        public string Modulo
        {
            get { return _modulo ; }
            set { _modulo = value; }
        }

        public int Id_Modulo
        {
            get { return _id_modulo ; }
            set { _id_modulo = value; }
        }
    }
}
