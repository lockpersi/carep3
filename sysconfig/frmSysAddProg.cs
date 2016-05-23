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
        frmSysProgramas frmSysProgPar;

        public frmSysAddProg(frmSysProgramas frmSysProg)
        {
            InitializeComponent();
            frmSysProgPar = frmSysProg;
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
            try
            {
                Models.frmSysProgramas DadosPrograma = new Models.frmSysProgramas();
                DadosPrograma.Nome_Form = txtNome.Text;
                DadosPrograma.Form_Descricao = txtDescricao.Text;
                DadosPrograma.Nome_Chamada = txtChamada.Text;
                DadosPrograma.Modulo = cbModulos.Text;
                Regras.frmSysProgramas obj = new Regras.frmSysProgramas();
                obj.AdicionaPrograma(DadosPrograma);
                MessageBox.Show("O programa foi adicionado com sucesso");
                frmSysProgPar.DadosRetorno();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
