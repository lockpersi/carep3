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
            RetornaDados();
        }

        /// <summary>
        /// Retorna dados da base de dados para preencher tela
        /// </summary>
        private void RetornaDados()
        {
            try
            {
                sysconfig.Models.frmSysSystem DadosSystemEmpresa = new sysconfig.Models.frmSysSystem();
                sysconfig.Regras.frmSysSystem obj = new sysconfig.Regras.frmSysSystem();
                obj.Pesquisar(DadosSystemEmpresa);
                
                //Atribui valores
                txtRazaoSocial.Text = DadosSystemEmpresa.RazaoSocial.ToString();
                txtFantasia.Text = DadosSystemEmpresa.NomeFantasia.ToString();
                txtCEP.Text = DadosSystemEmpresa.Cep.ToString();
                txtLogradouro.Text = DadosSystemEmpresa.Logradouro.ToString();
                txtNumero.Text = DadosSystemEmpresa.Numero.ToString();
                txtComplemento.Text = DadosSystemEmpresa.Complemento.ToString();
                txtBairro.Text = DadosSystemEmpresa.Bairro.ToString();
                txtCidade.Text = DadosSystemEmpresa.Cidade.ToString();
                cbUF.Text = DadosSystemEmpresa.UF.ToString();
                txtCNPJ.Text = DadosSystemEmpresa.CNPJ.ToString();
                txtEstadual.Text = DadosSystemEmpresa.InscEstadual.ToString();
                txtMunicipal.Text = DadosSystemEmpresa.InscMunicipal.ToString();
                if (DadosSystemEmpresa.RegimeTributario == "Simples Nacional")
                {
                    rbSimplesNacional.Select();
                }
                else if (DadosSystemEmpresa.RegimeTributario == "Lucro Presumido")
                {
                    rbLucroPresumido.Select();
                }
                else
                {
                    rbLucroReal.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Metodo para cor do TabControl
        /// </summary>
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage CurrentTab = tabControl.TabPages[e.Index];
            Rectangle ItemRect = tabControl.GetTabRect(e.Index);

            //Muda a cor do objeto nao selecionado
            SolidBrush FillBrush = new SolidBrush(SystemColors.Control);
            SolidBrush TextBrush = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //Muda a cor do objeto selecionado
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = SystemColors.Control;
                TextBrush.Color = Color.DarkSlateGray;
                ItemRect.Inflate(2, 2);
            }

            if (tabControl.Alignment == TabAlignment.Left || tabControl.Alignment == TabAlignment.Right)
            {
                float RotateAngle = 90;
                if (tabControl.Alignment == TabAlignment.Left)
                    RotateAngle = 270;
                PointF cp = new PointF(ItemRect.Left + (ItemRect.Width / 2), ItemRect.Top + (ItemRect.Height / 2));
                e.Graphics.TranslateTransform(cp.X, cp.Y);
                e.Graphics.RotateTransform(RotateAngle);
                ItemRect = new Rectangle(-(ItemRect.Height / 2), -(ItemRect.Width / 2), ItemRect.Height, ItemRect.Width);
            }

            e.Graphics.FillRectangle(FillBrush, ItemRect);

            e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);

            e.Graphics.ResetTransform();

            FillBrush.Dispose();
            TextBrush.Dispose();
        }

        /// <summary>
        /// Metodo que move o cursor para o final, para evitar edição do usuario incorreta
        /// </summary>
        private void txtCEP_Click(object sender, EventArgs e)
        {
            txtCEP.SelectionStart = txtCEP.Text.Length + 1;
        }

        /// <summary>
        /// Evento KeyPress do txtCEP
        /// </summary>
        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            mascaras mascara = atribuiMascara((char)e.KeyChar, txtCEP.Text);

            if (!(e.Handled = mascara.mascaraNumero(9)))
            {
                txtCEP.Text = mascara.mascaraCEP();
            }
            txtCEP.SelectionStart = txtCEP.Text.Length + 1;
        }

        /// <summary>
        /// Evento atribuir mascaras 
        /// </summary>
        private mascaras atribuiMascara(char caractere, string texto)
        {
            mascaras objetoMascara = new mascaras();
            objetoMascara.recebeTecla(caractere);
            objetoMascara.recebePalavra(texto);
            return objetoMascara;
        }

        /// <summary>
        /// Evento KeyPress do txtCNPJ
        /// </summary>
        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            mascaras mascara = atribuiMascara((char)e.KeyChar, txtCNPJ.Text);
            if (!(e.Handled = mascara.mascaraNumero(16)))
            txtCNPJ.Text = mascara.mascaraCNPJ();
            txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1;
        }

    }

}
