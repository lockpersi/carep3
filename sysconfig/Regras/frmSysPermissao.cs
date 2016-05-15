using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Regras
{
    public class frmSysPermissao
    {
        public DataTable CarregaCBUsuario(DataTable DadosUsuarios)
        {
            StringsBD.frmSysPermissao obj = new StringsBD.frmSysPermissao();
            obj.CarregaCBUsuario(DadosUsuarios);
            return DadosUsuarios;
        }
    }
}
