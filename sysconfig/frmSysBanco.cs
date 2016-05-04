#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sysconfig
{
    public partial class frmSysBanco : Form
    {

        /// <summary>
        /// Parametros globais do frmSysConfig
        /// </summary>
        // Variavel aux do botão Sair
        int btnSairInfo = 0;
        //Declaracao do XML
        XmlDocument _SysConfigXML;

        public frmSysBanco()
        {
            InitializeComponent();
        }

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
        /// Evento load do formulario
        /// </summary>
        private void frmSysBanco_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //Abertura do xml
            xmlsysconfigleitura();
        }

        /// <summary>
        /// Leitura do documento XML
        /// </summary>
        /// <returns>SysConfig XML</returns>
        private XmlDocument GetXML()
        {
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(@"bin/sysconfig.xml");
                return xml;
            }
            catch
            {
                MessageBox.Show(this, "Arquivo não encontrado, entre em contato com o administrador do sistema", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return null;
            }
        }

        /// <summary>
        /// Metodo de leitura do XML
        /// </summary>
        private void xmlsysconfigleitura()
        {
            _SysConfigXML = GetXML();

            if (_SysConfigXML != null)
            {
                foreach (XmlNode node1 in _SysConfigXML.DocumentElement)
                {
                    foreach (XmlNode node2 in node1)
                    {
                        if (node2.ParentNode.Name.Equals("mb1"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            txtIpServidor.Text = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb2"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            txtPorta.Text = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb3"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            txtNomeUsuario.Text = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb4"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            txtSenhaAcesso.Text = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb5"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            txtBancoDados.Text = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb6"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            txtCaminhoAtu.Text = ipconfig;
                        }
                    }
                }
            }

        }

        /// <summary>
        /// Metodo para salvar o XML
        /// </summary>
        private void xmlsysconfigsalvar()
        {
            _SysConfigXML = GetXML();

            if (_SysConfigXML != null)
            {
                foreach (XmlNode node1 in _SysConfigXML.DocumentElement)
                {
                    foreach (XmlNode node2 in node1)
                    {
                        if (node2.ParentNode.Name.Equals("mb1"))
                        {
                            string ipconfig = null;
                            ipconfig = txtIpServidor.Text;
                            ipconfig = md5crypt.Criptografar(ipconfig);
                            node2.InnerText = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb2"))
                        {
                            string ipconfig = null;
                            ipconfig = txtPorta.Text;
                            ipconfig = md5crypt.Criptografar(ipconfig);
                            node2.InnerText = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb3"))
                        {
                            string ipconfig = null;
                            ipconfig = txtNomeUsuario.Text;
                            ipconfig = md5crypt.Criptografar(ipconfig);
                            node2.InnerText = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb4"))
                        {
                            string ipconfig = null;
                            ipconfig = txtSenhaAcesso.Text;
                            ipconfig = md5crypt.Criptografar(ipconfig);
                            node2.InnerText = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb5"))
                        {
                            string ipconfig = null;
                            ipconfig = txtBancoDados.Text;
                            ipconfig = md5crypt.Criptografar(ipconfig);
                            node2.InnerText = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb6"))
                        {
                            string ipconfig = null;
                            ipconfig = txtCaminhoAtu.Text;
                            ipconfig = md5crypt.Criptografar(ipconfig);
                            node2.InnerText = ipconfig;
                        }
                    }
                }
                _SysConfigXML.Save(@"bin/sysconfig.xml");
                MessageBox.Show(this, "Configuração salva com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento do botão salvar do frmSysBanco
        /// </summary>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            xmlsysconfigsalvar();
            this.Close();
        }

        /// <summary>
        /// Evento do botão testar do frmSysBanco
        /// </summary>
        private void btnTestar_Click(object sender, EventArgs e)
        {
            string ip = txtIpServidor.Text;
            string banco = txtBancoDados.Text;
            string usuario = txtNomeUsuario.Text;
            string senha = txtSenhaAcesso.Text;
            string porta = txtPorta.Text;
            SqlConnection conn = null;
            conn = new SqlConnection(@"Data Source = " + ip + "," + porta +"; Initial Catalog = " + banco + "; User ID = "+ usuario +"; Password = " + senha +";");
            try
            {
                conn.Open();
                MessageBox.Show("Teste de conexão com o banco OK");
                conn.Close();
            }
            catch (SqlException sqle)
            {
                conn = null;
                
                #if DEBUG
                    MessageBox.Show(sqle.ToString());
                #endif

                MessageBox.Show("Verifique os parametros de conexão com o banco !");
            }
        }
    }
}
