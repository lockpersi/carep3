using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Regras
{
    public class frmSysSystem
    {
        public sysconfig.Models.frmSysSystem Pesquisar(sysconfig.Models.frmSysSystem System)
        {
            sysconfig.StringsBD.frmSysSystem obj = new sysconfig.StringsBD.frmSysSystem();
            obj.DadosRetorno(System);
            return System;
        }
    }
}
