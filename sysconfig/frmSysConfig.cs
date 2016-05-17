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
    public partial class frmSysConfig : Form
    {
        /// <summary>
        /// Variaveis Globais
        /// </summary>
        private XmlDocument _SysConfigXML;
        string IpServidor, Porta, NomeUsuario, SenhaAcesso, BancoDados;

        public frmSysConfig()
        {
            InitializeComponent();
            xmlsysconfigleitura();
            verificaConexaoBanco();
        }

        /// <summary>
        /// Evento do botão sair do frmSysConfig
        /// </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Atualiza Status Info
        /// </summary>
        /// <param name="infoatualiza"></param>
        public void AtualizaInfo(string infoatualiza)
        {
            lblInfo.Text = infoatualiza;
        }

        /// <summary>
        /// Evento de click do botão Sistema do frmSysConfig
        /// </summary>
        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSysSystem>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysBanco>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysUsuario>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysModulos>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysProgramas>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmSysSystem frmSysSystem = new frmSysSystem(this);
                frmSysSystem.MdiParent = this;
                frmSysSystem.Show();
            }
        }

        /// <summary>
        /// Evento que abre o menu frmSysUsuario
        /// </summary>
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSysUsuario>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysBanco>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysSystem>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysModulos>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysProgramas>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmSysUsuario frmSysUsuario = new frmSysUsuario(this);
                frmSysUsuario.MdiParent = this;
                frmSysUsuario.Show();
            }

        }

        /// <summary>
        /// Evento de click do botão Modulos do frmSysConfig
        /// </summary>
        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSysModulos>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysBanco>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysUsuario>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysSystem>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysProgramas>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmSysModulos frmSysModulos = new frmSysModulos(this);
                frmSysModulos.MdiParent = this;
                frmSysModulos.Show();
            }
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSysProgramas>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysSystem>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysUsuario>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysModulos>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysBanco>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmSysProgramas frmSysProgramas = new frmSysProgramas();
                frmSysProgramas.MdiParent = this;
                frmSysProgramas.Show();
            }
        }

        /// <summary>
        /// Evento de click do botão Banco De Dados do frmSysConfig
        /// </summary>
        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSysBanco>().Count() > 0)
            {
                MessageBox.Show("A janela já está aberta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysSystem>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Application.OpenForms.OfType<frmSysUsuario>().Count() > 0){
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysModulos>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Application.OpenForms.OfType<frmSysProgramas>().Count() > 0)
            {
                MessageBox.Show("Você deve fechar a janela aberta para abrir uma nova", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmSysBanco frmSysBanco = new frmSysBanco();
                frmSysBanco.MdiParent = this;
                frmSysBanco.Show();
            }
        }

        /// <summary>
        /// Metodo que faz a leitura do sysconfig.xml
        /// </summary>
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
                return null;
            }
        }

        /// <summary>
        /// Metodo faz a leitura do conteudo do sysconfig.xml
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
                            IpServidor = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb2"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            Porta = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb3"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            NomeUsuario = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb4"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            SenhaAcesso = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb5"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = md5crypt.Descriptografar(ipconfig);
                            BancoDados = ipconfig;
                        }
                        
                    }
                }
            }

        }

        /// <summary>
        /// Metodo que verifica se a conexão do banco está persistente
        /// </summary>
        private void verificaConexaoBanco()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = bd.dados.StringDeConexao;
            try
            {
                conn.Open();

                //Habilita Menus
                sistemaToolStripMenuItem.Enabled = true;
                usuariosToolStripMenuItem.Enabled = true;
                modulosToolStripMenuItem.Enabled = true;
                programasToolStripMenuItem.Enabled = true;
                
                conn.Close();
            }
            catch (SqlException sqle)
            {
                conn = null;

                //Desabilita Menus
                sistemaToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
                modulosToolStripMenuItem.Enabled = false;
                programasToolStripMenuItem.Enabled = false;

                lblInfo.Text = "Verifique os parametros de conexão com o banco";
            }
        }
    }
}
