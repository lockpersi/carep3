using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.StringsBD
{
    public class frmSysModulos
    {
        public DataTable DadosRetorno(DataTable DadosModulos)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select id_modulo, nome_modulo, descricao, data_cad from mnt_modulo";
                cn.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(DadosModulos);
            }
            catch (SqlException ex)
            {
                throw new Exception ("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return DadosModulos;
        }

        public void AdicionaDados(Models.frmSysModulos DadosModulo)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select count(*) from mnt_modulo where nome_modulo = '" + DadosModulo.NomeModulo + "';";
                cn.Open();
                int resultado = (int)cmd.ExecuteScalar();
                if (resultado != 0)
                {
                    throw new Exception("Módulo já cadastrado");
                }
                DateTime time = DateTime.Now;
                string format = "yyyy-MM-dd HH:MM:ss";
                cmd.CommandText = "insert into mnt_modulo(nome_modulo, descricao, data_cad) " +
                                  "values (@nome, @descricao, @data);";
                cmd.Parameters.AddWithValue("@nome", DadosModulo.NomeModulo);
                cmd.Parameters.AddWithValue("@descricao", DadosModulo.Descricao);
                cmd.Parameters.AddWithValue("@data", time.ToString(format));
                cmd.ExecuteScalar();
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
        }

        public void DeletarModulo(int idModulo)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from mnt_modulo where id_modulo = " + idModulo;
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o módulo");
                }
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
        }
    }
}
