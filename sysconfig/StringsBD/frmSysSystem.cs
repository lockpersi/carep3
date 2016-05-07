using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysconfig.StringsBD
{
    public class frmSysSystem
    {
        public void Alterar(sysconfig.Models.frmSysSystem System)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update org_cadempresa set razaosocial = @empresa where cod_empresa = 1;";
                cmd.Parameters.AddWithValue("@empresa", System.RazaoSocial);
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
        //

        public sysconfig.Models.frmSysSystem DadosRetorno(sysconfig.Models.frmSysSystem DadosSystemEmpresa)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select razaosocial, nome_fantasia, cep, logradouro, numero, complemento, bairro, "+
                                  "cidade, uf, cnpj, insc_estadual, insc_municipal, regime_tributario from org_cadempresa "+
                                  "WHERE cod_empresa = 1;";

                cn.Open();
                //enquanto leitor lê 
                SqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    //que será retornado 
                    DadosSystemEmpresa.RazaoSocial = leitor["razaosocial"].ToString();
                    DadosSystemEmpresa.NomeFantasia = leitor["nome_fantasia"].ToString();
                    DadosSystemEmpresa.Cep = leitor["cep"].ToString();
                    DadosSystemEmpresa.Logradouro = leitor["logradouro"].ToString();
                    DadosSystemEmpresa.Numero = Convert.ToInt32(leitor["numero"].ToString());
                    DadosSystemEmpresa.Complemento = leitor["complemento"].ToString();
                    DadosSystemEmpresa.Bairro = leitor["bairro"].ToString();
                    DadosSystemEmpresa.Cidade = leitor["cidade"].ToString();
                    DadosSystemEmpresa.UF = leitor["uf"].ToString();
                    DadosSystemEmpresa.CNPJ = leitor["cnpj"].ToString();
                    DadosSystemEmpresa.InscEstadual = leitor["insc_estadual"].ToString();
                    DadosSystemEmpresa.InscMunicipal = leitor["insc_municipal"].ToString();
                    DadosSystemEmpresa.RegimeTributario = leitor["regime_tributario"].ToString();
               
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
            return DadosSystemEmpresa;
        }
    }
}
