namespace sysconfig
{
    partial class frmSysSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.gbRegimeTributario = new System.Windows.Forms.GroupBox();
            this.rbLucroReal = new System.Windows.Forms.RadioButton();
            this.rbSimplesNacional = new System.Windows.Forms.RadioButton();
            this.rbLucroPresumido = new System.Windows.Forms.RadioButton();
            this.txtMunicipal = new System.Windows.Forms.TextBox();
            this.lblMunicipal = new System.Windows.Forms.Label();
            this.txtEstadual = new System.Windows.Forms.TextBox();
            this.lblEstadual = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbEmpresa.SuspendLayout();
            this.gbRegimeTributario.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(749, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.gbEmpresa.Controls.Add(this.gbRegimeTributario);
            this.gbEmpresa.Controls.Add(this.txtMunicipal);
            this.gbEmpresa.Controls.Add(this.lblMunicipal);
            this.gbEmpresa.Controls.Add(this.txtEstadual);
            this.gbEmpresa.Controls.Add(this.lblEstadual);
            this.gbEmpresa.Controls.Add(this.txtCNPJ);
            this.gbEmpresa.Controls.Add(this.lblCNPJ);
            this.gbEmpresa.Controls.Add(this.lblEstado);
            this.gbEmpresa.Controls.Add(this.cbUF);
            this.gbEmpresa.Controls.Add(this.txtCidade);
            this.gbEmpresa.Controls.Add(this.lblCidade);
            this.gbEmpresa.Controls.Add(this.txtBairro);
            this.gbEmpresa.Controls.Add(this.lblBairro);
            this.gbEmpresa.Controls.Add(this.txtComplemento);
            this.gbEmpresa.Controls.Add(this.lblComplemento);
            this.gbEmpresa.Controls.Add(this.txtNumero);
            this.gbEmpresa.Controls.Add(this.lblNumero);
            this.gbEmpresa.Controls.Add(this.txtLogradouro);
            this.gbEmpresa.Controls.Add(this.lblLogradouro);
            this.gbEmpresa.Controls.Add(this.txtCEP);
            this.gbEmpresa.Controls.Add(this.lblCEP);
            this.gbEmpresa.Controls.Add(this.txtFantasia);
            this.gbEmpresa.Controls.Add(this.lblFantasia);
            this.gbEmpresa.Controls.Add(this.lblRazaoSocial);
            this.gbEmpresa.Controls.Add(this.txtRazaoSocial);
            this.gbEmpresa.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmpresa.Location = new System.Drawing.Point(15, 8);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(807, 260);
            this.gbEmpresa.TabIndex = 1;
            this.gbEmpresa.TabStop = false;
            this.gbEmpresa.Text = "Empresa";
            // 
            // gbRegimeTributario
            // 
            this.gbRegimeTributario.Controls.Add(this.rbLucroReal);
            this.gbRegimeTributario.Controls.Add(this.rbSimplesNacional);
            this.gbRegimeTributario.Controls.Add(this.rbLucroPresumido);
            this.gbRegimeTributario.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegimeTributario.Location = new System.Drawing.Point(483, 119);
            this.gbRegimeTributario.Name = "gbRegimeTributario";
            this.gbRegimeTributario.Size = new System.Drawing.Size(260, 100);
            this.gbRegimeTributario.TabIndex = 28;
            this.gbRegimeTributario.TabStop = false;
            this.gbRegimeTributario.Text = "Regime Tributário";
            // 
            // rbLucroReal
            // 
            this.rbLucroReal.AutoSize = true;
            this.rbLucroReal.Location = new System.Drawing.Point(15, 71);
            this.rbLucroReal.Name = "rbLucroReal";
            this.rbLucroReal.Size = new System.Drawing.Size(86, 19);
            this.rbLucroReal.TabIndex = 28;
            this.rbLucroReal.TabStop = true;
            this.rbLucroReal.Text = "Lucro Real";
            this.rbLucroReal.UseVisualStyleBackColor = true;
            // 
            // rbSimplesNacional
            // 
            this.rbSimplesNacional.AutoSize = true;
            this.rbSimplesNacional.Location = new System.Drawing.Point(15, 21);
            this.rbSimplesNacional.Name = "rbSimplesNacional";
            this.rbSimplesNacional.Size = new System.Drawing.Size(124, 19);
            this.rbSimplesNacional.TabIndex = 26;
            this.rbSimplesNacional.TabStop = true;
            this.rbSimplesNacional.Text = "Simples Nacional";
            this.rbSimplesNacional.UseVisualStyleBackColor = true;
            // 
            // rbLucroPresumido
            // 
            this.rbLucroPresumido.AutoSize = true;
            this.rbLucroPresumido.Location = new System.Drawing.Point(15, 46);
            this.rbLucroPresumido.Name = "rbLucroPresumido";
            this.rbLucroPresumido.Size = new System.Drawing.Size(123, 19);
            this.rbLucroPresumido.TabIndex = 27;
            this.rbLucroPresumido.TabStop = true;
            this.rbLucroPresumido.Text = "Lucro Presumido";
            this.rbLucroPresumido.UseVisualStyleBackColor = true;
            // 
            // txtMunicipal
            // 
            this.txtMunicipal.Location = new System.Drawing.Point(313, 179);
            this.txtMunicipal.Name = "txtMunicipal";
            this.txtMunicipal.Size = new System.Drawing.Size(148, 24);
            this.txtMunicipal.TabIndex = 24;
            this.txtMunicipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMunicipal
            // 
            this.lblMunicipal.AutoSize = true;
            this.lblMunicipal.BackColor = System.Drawing.Color.Transparent;
            this.lblMunicipal.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipal.Location = new System.Drawing.Point(310, 162);
            this.lblMunicipal.Name = "lblMunicipal";
            this.lblMunicipal.Size = new System.Drawing.Size(87, 15);
            this.lblMunicipal.TabIndex = 23;
            this.lblMunicipal.Text = "Insc. Municipal : ";
            // 
            // txtEstadual
            // 
            this.txtEstadual.Location = new System.Drawing.Point(153, 179);
            this.txtEstadual.Name = "txtEstadual";
            this.txtEstadual.Size = new System.Drawing.Size(154, 24);
            this.txtEstadual.TabIndex = 22;
            this.txtEstadual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEstadual
            // 
            this.lblEstadual.AutoSize = true;
            this.lblEstadual.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadual.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadual.Location = new System.Drawing.Point(150, 161);
            this.lblEstadual.Name = "lblEstadual";
            this.lblEstadual.Size = new System.Drawing.Size(80, 15);
            this.lblEstadual.TabIndex = 21;
            this.lblEstadual.Text = "Insc. Estatual : ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(13, 179);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(134, 24);
            this.txtCNPJ.TabIndex = 20;
            this.txtCNPJ.Text = "00000000/0000-00";
            this.txtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(10, 161);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(40, 15);
            this.lblCNPJ.TabIndex = 19;
            this.lblCNPJ.Text = "CNPJ : ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(411, 116);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(30, 15);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "UF : ";
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(414, 134);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(47, 25);
            this.cbUF.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(205, 135);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(203, 24);
            this.txtCidade.TabIndex = 17;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(202, 116);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(51, 15);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade : ";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(13, 134);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(186, 24);
            this.txtBairro.TabIndex = 15;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(10, 116);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(45, 15);
            this.lblBairro.TabIndex = 14;
            this.lblBairro.Text = "Bairro : ";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(483, 89);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(318, 24);
            this.txtComplemento.TabIndex = 13;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(480, 71);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(85, 15);
            this.lblComplemento.TabIndex = 12;
            this.lblComplemento.Text = "Complemento :";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(414, 89);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 24);
            this.txtNumero.TabIndex = 11;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(411, 71);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 15);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "Número :";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(106, 89);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(302, 24);
            this.txtLogradouro.TabIndex = 9;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.BackColor = System.Drawing.Color.Transparent;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(103, 70);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(76, 15);
            this.lblLogradouro.TabIndex = 8;
            this.lblLogradouro.Text = "Logradouro : ";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(13, 89);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(87, 24);
            this.txtCEP.TabIndex = 7;
            this.txtCEP.Text = "00000-000";
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCEP.Click += new System.EventHandler(this.txtCEP_Click);
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(10, 71);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 15);
            this.lblCEP.TabIndex = 6;
            this.lblCEP.Text = "CEP : ";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(414, 43);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(387, 24);
            this.txtFantasia.TabIndex = 5;
            // 
            // lblFantasia
            // 
            this.lblFantasia.AutoSize = true;
            this.lblFantasia.BackColor = System.Drawing.Color.Transparent;
            this.lblFantasia.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantasia.Location = new System.Drawing.Point(411, 25);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(54, 15);
            this.lblFantasia.TabIndex = 4;
            this.lblFantasia.Text = "Fantasia :";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(10, 25);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(76, 15);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = "Razão Social :";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(13, 43);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(395, 24);
            this.txtRazaoSocial.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabEmpresa);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(832, 322);
            this.tabControl.TabIndex = 2;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.tabEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabEmpresa.Controls.Add(this.gbEmpresa);
            this.tabEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpresa.Size = new System.Drawing.Size(824, 293);
            this.tabEmpresa.TabIndex = 0;
            this.tabEmpresa.Text = "Cadastro Empresa";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(668, 328);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmSysSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 354);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysSystem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysSystem_Load);
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            this.gbRegimeTributario.ResumeLayout(false);
            this.gbRegimeTributario.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtEstadual;
        private System.Windows.Forms.Label lblEstadual;
        private System.Windows.Forms.TextBox txtMunicipal;
        private System.Windows.Forms.Label lblMunicipal;
        private System.Windows.Forms.GroupBox gbRegimeTributario;
        private System.Windows.Forms.RadioButton rbLucroReal;
        private System.Windows.Forms.RadioButton rbSimplesNacional;
        private System.Windows.Forms.RadioButton rbLucroPresumido;
        private System.Windows.Forms.Button btnSalvar;
    }
}