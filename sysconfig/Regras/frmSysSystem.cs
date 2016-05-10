using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Regras
{
    public class frmSysSystem
    {
        public Models.frmSysSystem Pesquisar(Models.frmSysSystem System)
        {
            StringsBD.frmSysSystem obj = new StringsBD.frmSysSystem();
            obj.DadosRetorno(System);
            return System;
        }

        public void Salvar(Models.frmSysSystem DadosSystemEmpresa)
        {

            //se tudo esta ok chamada rotina DAL
            StringsBD.frmSysSystem obj = new StringsBD.frmSysSystem();
            obj.salvar(DadosSystemEmpresa);
        }
    }
}
