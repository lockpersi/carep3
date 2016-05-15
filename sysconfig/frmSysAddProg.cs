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
    public partial class frmSysAddProg : Form
    {
        public frmSysAddProg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento do botão cancelar do frmSysAddProg
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
