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
        //Declaracao do XML
        XmlDocument _SysConfigXML;

        public frmSysSystem(frmSysConfig frmSys)
        {
            InitializeComponent();
            //Instanciando o frmSysConfigPar com o frmSys(frmSysConfig)
            frmSysConfigPar = frmSys;
            frmSysConfigPar.lblInfo.Text = "teste de abertura ok";
            this.Dock = DockStyle.Fill;
            //Abertura do xml
            //xmlsysconfigleitura();
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
                           // tb_ipconfig.Text = ipconfig;
                        }
                        if (node2.ParentNode.Name.Equals("mb2"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            //ipconfig = MD5Crypt.Descriptografar(ipconfig);
                            //text
                        }
                    }
                }
            }

        }

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
                MessageBox.Show(this, "Arquivo XML não encontrado, entre em contato com o administrador do sistema", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

    }
}
