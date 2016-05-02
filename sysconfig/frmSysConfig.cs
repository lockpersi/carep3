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
        }

        /// <summary>
        /// Evento do botão sair do frmSysConfig
        /// </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
