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
        public void salvar(sysconfig.Models.frmSysSystem DadosSystemEmpresa)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = bd.dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update org_cadempresa set razaosocial = @razaosocial, nome_fantasia = @nome_fantasia, cep = @cep, "+
                                  "logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro, "+
                                  "cidade = @cidade, uf = @uf, cnpj = @cnpj, insc_estadual = @insc_estadual, insc_municipal = @insc_municipal, "+
                                  "regime_tributario = @regime_tributario where cod_empresa = 1;";

                cmd.Parameters.AddWithValue("@razaosocial", DadosSystemEmpresa.RazaoSocial);
                cmd.Parameters.AddWithValue("@nome_fantasia", DadosSystemEmpresa.NomeFantasia);
                cmd.Parameters.AddWithValue("@cep", DadosSystemEmpresa.Cep);
                cmd.Parameters.AddWithValue("@logradouro", DadosSystemEmpresa.Logradouro);
                cmd.Parameters.AddWithValue("@numero", DadosSystemEmpresa.Numero);
                cmd.Parameters.AddWithValue("@complemento", DadosSystemEmpresa.Complemento);
                cmd.Parameters.AddWithValue("@bairro", DadosSystemEmpresa.Bairro);
                cmd.Parameters.AddWithValue("@cidade", DadosSystemEmpresa.Cidade);
                cmd.Parameters.AddWithValue("@uf", DadosSystemEmpresa.UF);
                cmd.Parameters.AddWithValue("@cnpj", DadosSystemEmpresa.CNPJ);
                cmd.Parameters.AddWithValue("@insc_estadual", DadosSystemEmpresa.InscEstadual);
                cmd.Parameters.AddWithValue("@insc_municipal", DadosSystemEmpresa.InscMunicipal);
                cmd.Parameters.AddWithValue("@regime_tributario", DadosSystemEmpresa.RegimeTributario);
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
        
        /// <summary>
        /// Dados Retorno do banco
        /// </summary>
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
