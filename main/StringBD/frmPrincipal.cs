using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.StringBD
{
    public class frmPrincipal
    {
        public ArrayList VerificaPrograma(ArrayList Programas)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                //cmd.CommandText = "select";
                cn.Open();

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return Programas;
        }
    }
}
