using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.Regras
{
    public class frmSysModulos
    {
        public DataTable DadosRetorno(DataTable DadosModulos)
        {
            StringsBD.frmSysModulos obj = new StringsBD.frmSysModulos();
            obj.DadosRetorno(DadosModulos);
            return DadosModulos;
        }

        public void AdicionaDados(Models.frmSysModulos DadosModulo)
        {
            StringsBD.frmSysModulos obj = new StringsBD.frmSysModulos();
            obj.AdicionaDados(DadosModulo);
        }

        public void DeletarModulo(int idmodulo)
        {
            StringsBD.frmSysModulos obj = new StringsBD.frmSysModulos();
            obj.DeletarModulo(idmodulo);
        }
    }
}
