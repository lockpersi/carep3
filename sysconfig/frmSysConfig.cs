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
    public partial class frmSysConfig : Form
    {



        public frmSysConfig()
        {
            InitializeComponent();
            AtualizaInfo("Teste de funcionamento");
        }

        /// <summary>
        /// Evento do botão sair do frmSysConfig
        /// </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Atualiza Status Info
        /// </summary>
        /// <param name="infoatualiza"></param>
        public void AtualizaInfo(string infoatualiza)
        {
            lblInfo.Text = infoatualiza;
        }

        /// <summary>
        /// Evento de click do botão Sistema do frmSysConfig
        /// </summary>
        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSysSystem>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                frmSysSystem frmSysSystem = new frmSysSystem(this);
                frmSysSystem.MdiParent = this;
                frmSysSystem.Show();
            }
        }
    }
}
