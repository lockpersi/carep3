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
            try
            {
                StringsBD.frmSysModulos obj = new StringsBD.frmSysModulos();
                obj.DadosRetorno(DadosModulos);
                return DadosModulos;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AdicionaDados(Models.frmSysModulos DadosModulo)
        {
            try
            {
                if(DadosModulo.Chamada.Trim().Length == 0)
                {
                    throw new Exception("O campo Chamada é obrigatório");
                }

                if(DadosModulo.Descricao.Trim().Length == 0)
                {
                    throw new Exception("O campo Descrição é obrigatório");
                }

                if(DadosModulo.NomeModulo.Trim().Length == 0)
                {
                    throw new Exception("O campo Nome Módulo é obrigatório");
                }

                //Se tudo está ok chamada a rotina
                StringsBD.frmSysModulos obj = new StringsBD.frmSysModulos();
                obj.AdicionaDados(DadosModulo);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletarModulo(int idmodulo)
        {
            try
            {
                StringsBD.frmSysModulos obj = new StringsBD.frmSysModulos();
                obj.DeletarModulo(idmodulo);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
