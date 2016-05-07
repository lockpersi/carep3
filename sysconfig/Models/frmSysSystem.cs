using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Models
{
    public class frmSysSystem
    {
        private string _RazaoSocial;
        private string _NomeFantasia;
        private string _Cep;
        private string _Logradouro;
        private int _Numero;
        private string _Complemento;
        private string _Bairro;
        private string _Cidade;
        private string _UF;
        private string _CNPJ;
        private string _InscEstadual;
        private string _InscMunicipal;
        private string _RegimeTributario;

        /// <summary>
        /// Abaixo Modelos para string 
        /// </summary>
        public string RazaoSocial
        {
            get { return _RazaoSocial ; }
            set { _RazaoSocial = value; }
        }

        public string NomeFantasia
        {
            get { return _NomeFantasia ; }
            set { _NomeFantasia = value; }
        }

        public string Bairro
        {
            get { return _Bairro ; }
            set { _Bairro = value; }
        }

        public string Cep
        {
            get { return _Cep ; }
            set { _Cep = value; }
        }

        public string Cidade
        {
            get { return _Cidade ; }
            set { _Cidade = value; }
        }

        public string CNPJ
        {
            get { return _CNPJ ; }
            set { _CNPJ = value; }
        }

        public string Complemento
        {
            get { return _Complemento ; }
            set { _Complemento = value; }
        }

        public string InscEstadual
        {
            get { return _InscEstadual ; }
            set { _InscEstadual = value; }
        }

        public string InscMunicipal
        {
            get { return _InscMunicipal ; }
            set { _InscMunicipal = value; }
        }

        public string Logradouro
        {
            get { return _Logradouro ; }
            set { _Logradouro = value; }
        }

        public int Numero
        {
            get { return _Numero ; }
            set { _Numero = value; }
        }

        public string RegimeTributario
        {
            get { return _RegimeTributario ; }
            set { _RegimeTributario = value; }
        }

        public string UF
        {
            get { return _UF ; }
            set { _UF = value; }
        }
    }
}
