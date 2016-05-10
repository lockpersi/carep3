using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.StringsBD
{
    public class frmSysUsuario
    {
        
        public DataTable DadosRetorno(DataTable DadosUsuarios)
        {
            SqlConnection cn = new SqlConnection();
                try
                {
                    cn.ConnectionString = bd.dados.StringDeConexao;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "select id_usuario, login, nome, email, ativo from mnt_usuario order by id_usuario";
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(DadosUsuarios);
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
                return DadosUsuarios;
            }
        public void AdicionarUsuario(Models.frmSysUsuario DadosUsuario)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into mnt_usuario(login, senha, nome, email, descricao, ativo) "+
                                  "values (@login, @senha, @nome, @email, @descricao, 'Ativo');";
                cmd.Parameters.AddWithValue("@login", DadosUsuario.Login);
                cmd.Parameters.AddWithValue("@senha", DadosUsuario.Senha);
                cmd.Parameters.AddWithValue("@nome", DadosUsuario.Nome);
                cmd.Parameters.AddWithValue("@email", DadosUsuario.Email);
                cmd.Parameters.AddWithValue("@descricao", DadosUsuario.Descricao);
                cn.Open();
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

        public void AtivarInativar(string usuativa, int idusu)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update mnt_usuario set ativo = '" + usuativa + "' where id_usuario = " + idusu +";";
                cn.Open();
                cmd.ExecuteNonQuery();
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


