using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sysconfig.Regras
{
    public class frmSysUsuario
    {
        public DataTable DadosRetorno(DataTable DadosRetorno)
        {
            StringsBD.frmSysUsuario obj = new StringsBD.frmSysUsuario();
            obj.DadosRetorno(DadosRetorno);
            return DadosRetorno;
        }

        public void AdicionaUsuario(Models.frmSysUsuario DadosUsuario)
        {
            //O campo usuário é obrigatorio
            if (DadosUsuario.Login.Trim().Length == 0)
            {
                throw new Exception("O campo Usuário é obrigatório");
            }

            //O campo senha é obrigatorio
            if (DadosUsuario.Senha.Trim().Length == 0)
            {
                throw new Exception("O campo Senha é obrigatório");
            }

            //O campo nome é obrigatorio
            if (DadosUsuario.Nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome é obrigatório");
            }

            //O campo Email é obrigatorio
            if (DadosUsuario.Email.Trim().Length == 0)
            {
                throw new Exception("O campo Email é obrigatório");
            }

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(DadosUsuario.Email))
            {
                throw new Exception("O campo Email está incorreto");
            }
            
            //se tudo esta certo chama o DAL
            StringsBD.frmSysUsuario obj = new StringsBD.frmSysUsuario();
            obj.AdicionarUsuario(DadosUsuario);
        }

        public void AtivarInativar(string usuativa, int idusu)
        {
            //se tudo esta certo chama o dal
            StringsBD.frmSysUsuario obj = new StringsBD.frmSysUsuario();
            obj.AtivarInativar(usuativa, idusu);
        }

        public Models.frmSysUsuario PopulaEditar(Models.frmSysUsuario DadosUsuario)
        {
            //se tudo esta certo chama o dal
            StringsBD.frmSysUsuario obj = new StringsBD.frmSysUsuario();
            obj.PupulaEdit(DadosUsuario);
            return DadosUsuario;
        }

        public void SalvarDados(Models.frmSysUsuario DadosUsuarios)
        {
            //se tudo esta certo chama o dal
            StringsBD.frmSysUsuario obj = new StringsBD.frmSysUsuario();
            obj.SalvaDados(DadosUsuarios);
        }
    }
}
