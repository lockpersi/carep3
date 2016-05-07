using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bd
{
    public class dados
    {
        /// <summary>
        /// Variaveis Globais
        /// </summary>
       static string ip, banco, usuario, senha, porta;
        //Declaracao do XML
        static XmlDocument _SysConfigXML;

        public static string StringDeConexao
        {
            get
            {
                xmlsysconfigleitura();
                return @"Data Source = " + ip + "," + porta + "; Initial Catalog = " + banco + "; User ID = " + usuario + "; Password = " + senha + ";";
            }
        }

        /// <summary>
        /// Metodo de leitura do sysconfig.xml
        /// </summary>
        public static void xmlsysconfigleitura()
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
                            ipconfig = sysconfig.md5crypt.Descriptografar(ipconfig);
                            ip = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb2"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = sysconfig.md5crypt.Descriptografar(ipconfig);
                            porta = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb3"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = sysconfig.md5crypt.Descriptografar(ipconfig);
                            usuario = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb4"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = sysconfig.md5crypt.Descriptografar(ipconfig);
                            senha = ipconfig;
                        }

                        if (node2.ParentNode.Name.Equals("mb5"))
                        {
                            string ipconfig = null;
                            ipconfig = node2.InnerText;
                            ipconfig = sysconfig.md5crypt.Descriptografar(ipconfig);
                            banco = ipconfig;
                        }

                    }
                }
            }

        }

        /// <summary>
        /// Metodo de pegar o xml sysconfig.xml
        /// </summary>
        private static XmlDocument GetXML()
        {
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(@"bin/sysconfig.xml");
                return xml;
            }
            catch
            {
                return null;
            }
        }

    }
}
