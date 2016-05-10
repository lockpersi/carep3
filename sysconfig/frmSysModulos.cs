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
        }

        /// <summary>
        /// Evento do botão Sair do frmSysModulo
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DadosRetorno()
        {
            try
            {
                DataTable dadosRetorno = new DataTable();
                Regras.frmSysModulos obj = new Regras.frmSysModulos();
                obj.DadosRetorno(dadosRetorno);

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
    }
}
