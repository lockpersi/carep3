using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sysconfig
{
    public partial class frmSysSystem : Form
    {
        /// <summary>
        /// Parametros globais do frmSysConfig
        /// </summary>
        // Variavel aux do botão Sair
        int btnSairInfo = 0;
        //Parametro usado para modificar atributos do form Pai.
        frmSysConfig frmSysConfigPar;

        public frmSysSystem(frmSysConfig frmSys)
        {
            InitializeComponent();
            //Instanciando o frmSysConfigPar com o frmSys(frmSysConfig)
            frmSysConfigPar = frmSys;
            frmSysConfigPar.lblInfo.Text = "teste de abertura ok";

        }

        /// <summary>
        /// Evento do botão sair do frmSysSytem 
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSairInfo != 0)
            {
                if (MessageBox.Show("Você deve salvar as informações antes de sair, para sair sem salvar clique em SIM", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        

        /// <summary>
        /// Evento Load do formulario
        /// </summary>
        private void frmSysSystem_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
