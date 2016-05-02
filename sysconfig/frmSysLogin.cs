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
    public partial class frmSysLogin : Form
    {
        /// <summary>
        /// Construtor do frmSysLogin
        /// </summary>
        public frmSysLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento do botão entrar do frmSysLogin
        /// </summary>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string verifica = txtSenha.Text.ToString();

            if(verifica == "opcr2wzscar")
            {
                MessageBox.Show("Teste ok");
            }
            else
            {
                MessageBox.Show("Você digitou a senha errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        /// <summary>
        /// Metodo que pega o evento "Enter" do teclado com foco no txtSenha
        /// </summary>
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}
