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
        //Carrega Combo Box Usuario do frmSysPermissao
        public DataTable CarregaCBUsuario(DataTable DadosUsuarios)
        {
            try
            {
                StringsBD.frmSysPermissao obj = new StringsBD.frmSysPermissao();
                obj.CarregaCBUsuario(DadosUsuarios);
                return DadosUsuarios;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable CarregaGridDados(DataTable DadosGrid, string nome_modulo, string nome_formulario)
        {
            try
            {
                StringsBD.frmSysPermissao obj = new StringsBD.frmSysPermissao();
                obj.CarregaGridDados(DadosGrid, nome_modulo, nome_formulario);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return DadosGrid;
        }

        public void InserirDados(Models.frmSysPermissao DadosPermissao)
        {
            try
            {
                StringsBD.frmSysPermissao obj = new StringsBD.frmSysPermissao();
                obj.InsereDados(DadosPermissao);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletarPermissao(string login, string nome_formulario, string nome_modulo)
        {
            try
            {
                StringsBD.frmSysPermissao obj = new StringsBD.frmSysPermissao();
                obj.DeletarPermissao(login, nome_formulario, nome_modulo);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
