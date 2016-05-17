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

        /// <summary>
        /// Metodo carrega CB Modulo
        /// </summary>
        private void CarregaCBModulo()
        {
            DataTable DadosModulo = new DataTable();
            Regras.frmSysProgramas obj = new Regras.frmSysProgramas();
            obj.CarregaCBModulos(DadosModulo);
            cbModulos.ValueMember = "nome_modulo";
            cbModulos.SelectedItem = "";
            cbModulos.DataSource = DadosModulo;
            cbModulos.Refresh();
        }

        /// <summary>
        /// Construtor do frmSysAddProg
        /// </summary>
        private void frmSysAddProg_Load(object sender, EventArgs e)
        {
            CarregaCBModulo();
        }

        /// <summary>
        /// Evento do btnAdicionarPrograma
        /// </summary>
        private void btnAdicionarPrograma_Click(object sender, EventArgs e)
        {

        }
    }
}
