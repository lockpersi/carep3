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
    public partial class frmSysAddUsu : Form
    {
        frmSysUsuario frmSysUsuarioPar;

        public frmSysAddUsu(frmSysUsuario frmSysUsu)
        {
            InitializeComponent();
            frmSysUsuarioPar = frmSysUsu;
        }

        /// <summary>
        /// Evento do botao sair do frmSysAddUsu
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            Models.frmSysUsuario DadosUsuario = new Models.frmSysUsuario();

            DadosUsuario.Nome = txtNome.Text;
            DadosUsuario.Email = txtEmail.Text;
            DadosUsuario.Descricao = txtDescricao.Text;
            DadosUsuario.Login = txtUsuario.Text;
            DadosUsuario.Senha = txtSenha.Text;
            DadosUsuario.IdUsuario = '1';

            Regras.frmSysUsuario obj = new Regras.frmSysUsuario();
            obj.AdicionaUsuario(DadosUsuario);
            MessageBox.Show("Usuário criado com sucesso");
            frmSysUsuarioPar.DadosRetorno();
            this.Close();
        }
    }
}
