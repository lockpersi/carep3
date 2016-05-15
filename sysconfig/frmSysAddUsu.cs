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
        string finalidade;

        public frmSysAddUsu(frmSysUsuario frmSysUsu, string finalidad)
        {
            InitializeComponent();
            frmSysUsuarioPar = frmSysUsu;
            finalidade = finalidad;
            VerificaFinalidade();
        }

        /// <summary>
        /// Evento do botao sair do frmSysAddUsu
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do botao Criar ou Salvar do frmSysAddUsu
        /// </summary>
        private void btnCriarouSalvar_Click(object sender, EventArgs e)
        {
            try {
                if (finalidade == "novo")
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
                else
                {
                    Models.frmSysUsuario DadosUsuario = new Models.frmSysUsuario();

                    //atribiu dados ao modelo;
                    DadosUsuario.Descricao = txtDescricao.Text.ToString();
                    DadosUsuario.Email = txtEmail.Text.ToString();
                    DadosUsuario.IdUsuario = Convert.ToInt32(txtCodUsu.Text);
                    DadosUsuario.Login = txtUsuario.Text.ToString();
                    DadosUsuario.Nome = txtNome.Text.ToString();
                    DadosUsuario.Senha = txtSenha.Text.ToString();

                    Regras.frmSysUsuario obj = new Regras.frmSysUsuario();
                    obj.SalvarDados(DadosUsuario);

                    MessageBox.Show("Dados alterados com sucesso");
                    frmSysUsuarioPar.DadosRetorno();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VerificaFinalidade()
        {
            if(finalidade == "novo")
            {
                btnCriarouSalvar.Text = "Criar Usuário";
            }
            else
            {
                try {
                    btnCriarouSalvar.Text = "Salvar Usuário";
                    this.Text = "Editando Usuário";

                    int idselecionado = frmSysUsuarioPar.RetornaIDSelecionado();
                    Models.frmSysUsuario DadosUsuario = new Models.frmSysUsuario();
                    Regras.frmSysUsuario obj = new Regras.frmSysUsuario();
                    DadosUsuario.IdUsuario = idselecionado;
                    obj.PopulaEditar(DadosUsuario);

                    txtCodUsu.Text = DadosUsuario.IdUsuario.ToString();
                    txtDescricao.Text = DadosUsuario.Descricao.ToString();
                    txtEmail.Text = DadosUsuario.Email.ToString();
                    txtNome.Text = DadosUsuario.Nome.ToString();
                    txtSenha.Text = DadosUsuario.Senha.ToString();
                    txtUsuario.Text = DadosUsuario.Login.ToString();

                    txtCodUsu.ReadOnly = true;
                    txtUsuario.ReadOnly = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
