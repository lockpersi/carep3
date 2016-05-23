using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysconfig
{
    public partial class frmSysModulos : Form
    {
        public frmSysModulos(frmSysConfig frmSys)
        {
            InitializeComponent();
        }

        private void frmSysModulos_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            DadosRetorno();
        }

        /// <summary>
        /// Evento do botão Sair do frmSysModulo
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Dados de Retorno do Banco de Dados (Modulos)
        /// </summary>
        public void DadosRetorno()
        {
            try
            {
                DataTable dadosRetorno = new DataTable();
                Regras.frmSysModulos obj = new Regras.frmSysModulos();
                obj.DadosRetorno(dadosRetorno);
                dataGridViewMod.DataSource = dadosRetorno;
                dataGridViewMod.ReadOnly = true;
                //Nomeia o nome das Colunas
                dataGridViewMod.Columns[0].HeaderText = "ID";
                dataGridViewMod.Columns[1].HeaderText = "Módulo";
                dataGridViewMod.Columns[2].HeaderText = "Descrição";
                dataGridViewMod.Columns[3].HeaderText = "Data do Cadastro";
                //Tamanho das colunas
                dataGridViewMod.Columns[0].Width = 25;
                dataGridViewMod.Columns[1].Width = 100;
                dataGridViewMod.Columns[2].Width = 350;
                dataGridViewMod.Columns[3].Width = 123;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Evento do botão Adicionar frmSysModulos
        /// </summary>
        private void btnAdicionarMod_Click(object sender, EventArgs e)
        {
            try
            {
                frmSysAddMod frmSysAddMod = new frmSysAddMod(this);
                frmSysAddMod.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento do botão Deletar Modulo do frmSysModulos
        /// </summary>
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                int idmod = Convert.ToInt32(dataGridViewMod.CurrentRow.Cells[0].Value.ToString());
                string nome_modulo = dataGridViewMod.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("Você deseja realmente deletar o módulo " + nome_modulo + "", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Regras.frmSysModulos obj = new Regras.frmSysModulos();
                    obj.DeletarModulo(idmod);
                    DadosRetorno();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento do botão Adicionar Permissao do frmSysModulos
        /// </summary>
        private void btnAdicionarPermissao_Click(object sender, EventArgs e)
        {
            int idmodulo = Convert.ToInt32(dataGridViewMod.CurrentRow.Cells[0].Value.ToString());
            string nomemodulo = dataGridViewMod.CurrentRow.Cells[1].Value.ToString();

            frmSysPermissaoModulo obj = new frmSysPermissaoModulo(idmodulo, nomemodulo);
            obj.ShowDialog();
        }
    }
}
