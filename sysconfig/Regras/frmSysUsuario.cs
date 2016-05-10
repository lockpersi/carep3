using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
    }
}
