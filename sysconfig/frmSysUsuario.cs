using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysconfig
{
    public partial class frmSysUsuario : Form
    {
        int idusu;

        public frmSysUsuario(frmSysConfig frmSys)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento do botão sair do frmSysUsuario
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Construtor do frmSysUsuario
        /// </summary>
        private void frmSysUsuario_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            DadosRetorno();
        }

        /// <summary>
        /// Metodo que tras os Dados do banco de dados
        /// </summary>
        public void DadosRetorno()
        {
            try
            {
                DataTable dadosRetorno = new DataTable();
                Regras.frmSysUsuario obj = new Regras.frmSysUsuario();
                obj.DadosRetorno(dadosRetorno);
                dataGridViewUsu.DataSource = dadosRetorno;
                dataGridViewUsu.ReadOnly = true;
                //Nomeia os nomes das colunas
                dataGridViewUsu.Columns[0].HeaderText = "ID";
                dataGridViewUsu.Columns[1].HeaderText = "Usuário";
                dataGridViewUsu.Columns[2].HeaderText = "Nome";
                dataGridViewUsu.Columns[3].HeaderText = "Email";
                dataGridViewUsu.Columns[4].HeaderText = "Info";
                //Padrão do tamanho das colunas
                dataGridViewUsu.Columns[0].Width = 25;
                dataGridViewUsu.Columns[1].Width = 100;
                dataGridViewUsu.Columns[2].Width = 200;
                dataGridViewUsu.Columns[3].Width = 200;
                dataGridViewUsu.Columns[4].Width = 73;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento do botão Adicionar usuario
        /// </summary>
        private void btnAdicionarUsu_Click(object sender, EventArgs e)
        {
            frmSysAddUsu frmSysAddUsu = new frmSysAddUsu(this, "novo");
            frmSysAddUsu.ShowDialog();
        }

        /// <summary>
        /// Evento do botão Ativar e Inativar
        /// </summary>
        private void btnAtivarInativar_Click(object sender, EventArgs e)
        {

            string usuativa = dataGridViewUsu.CurrentRow.Cells[4].Value.ToString();
            idusu = Convert.ToInt32(dataGridViewUsu.CurrentRow.Cells[0].Value.ToString());
            string message;
            if (usuativa == "Ativo")
            {
                usuativa = "Inativo";
                message = "Inativar";
            }
            else
            {
                usuativa = "Ativo";
                message = "Ativar";
            }

            if (MessageBox.Show("Você deseja realmente " + message + " o usuario ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Regras.frmSysUsuario obj = new Regras.frmSysUsuario();
                obj.AtivarInativar(usuativa, idusu);
                DadosRetorno();
            }

        }

        /// <summary>
        /// Evento do botão Editar Usuario do frmSysUsuario
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmSysAddUsu frmSysAddUsu = new frmSysAddUsu(this, "editar");
            frmSysAddUsu.ShowDialog();

        }

        public int RetornaIDSelecionado()
        {
            return idusu = Convert.ToInt32(dataGridViewUsu.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
