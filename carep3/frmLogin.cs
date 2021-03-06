﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carep3
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// Variaveis do formulario
        /// </summary>
        private DateTime DataHoje = DateTime.Today;
        public bool logado = false;

        /// <summary>
        /// Construtor do frmLogin
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            //Chamada do metodo horaedata para atualizar data e hora do frmLogin
            horaedata();
        }

        /// <summary>
        /// Evento do botão Sair do frmLogin
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evento KeyDown no txtLogin
        /// </summary>
        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F10:
                    sysconfig.frmSysLogin frmSysLogin = new sysconfig.frmSysLogin();
                    frmSysLogin.ShowDialog();
                    break;

            }
        }
 
        /// <summary>
        /// Metodo que faz a atualização da hora e da data
        /// </summary>
        private void horaedata()
        {
            lblHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
            lblData.Text = DataHoje.ToString("D");
        }

        /// <summary>
        /// Timer que atualiza hora e data
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            horaedata();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Models.frmLogin DadosLogin = new Models.frmLogin();
                DadosLogin.Usu = txtLogin.Text;
                DadosLogin.Pwd = txtSenha.Text;

                Regras.frmLogin obj = new Regras.frmLogin();
                obj.validar(DadosLogin);
                logado = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnLogin_Click(sender, e);
                    break;

            }
        }
    }
}
