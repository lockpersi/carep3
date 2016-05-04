namespace sysconfig
{
    partial class frmSysBanco
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
            this.gbConexao = new System.Windows.Forms.GroupBox();
            this.txtBancoDados = new System.Windows.Forms.TextBox();
            this.lblBancoDados = new System.Windows.Forms.Label();
            this.txtSenhaAcesso = new System.Windows.Forms.TextBox();
            this.lblSenhaAcesso = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtIpServidor = new System.Windows.Forms.TextBox();
            this.lblEnderecoServidor = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnTestar = new System.Windows.Forms.Button();
            this.gbAtualizacao = new System.Windows.Forms.GroupBox();
            this.txtCaminhoAtu = new System.Windows.Forms.TextBox();
            this.lblCaminhoAtu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbConexao.SuspendLayout();
            this.gbAtualizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(743, 325);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbConexao
            // 
            this.gbConexao.Controls.Add(this.txtBancoDados);
            this.gbConexao.Controls.Add(this.lblBancoDados);
            this.gbConexao.Controls.Add(this.txtSenhaAcesso);
            this.gbConexao.Controls.Add(this.lblSenhaAcesso);
            this.gbConexao.Controls.Add(this.txtNomeUsuario);
            this.gbConexao.Controls.Add(this.lblNomeUsuario);
            this.gbConexao.Controls.Add(this.txtPorta);
            this.gbConexao.Controls.Add(this.lblPorta);
            this.gbConexao.Controls.Add(this.txtIpServidor);
            this.gbConexao.Controls.Add(this.lblEnderecoServidor);
            this.gbConexao.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConexao.Location = new System.Drawing.Point(12, 12);
            this.gbConexao.Name = "gbConexao";
            this.gbConexao.Size = new System.Drawing.Size(511, 162);
            this.gbConexao.TabIndex = 1;
            this.gbConexao.TabStop = false;
            this.gbConexao.Text = "Dados de Conexão";
            // 
            // txtBancoDados
            // 
            this.txtBancoDados.Location = new System.Drawing.Point(360, 120);
            this.txtBancoDados.Name = "txtBancoDados";
            this.txtBancoDados.Size = new System.Drawing.Size(131, 25);
            this.txtBancoDados.TabIndex = 11;
            // 
            // lblBancoDados
            // 
            this.lblBancoDados.AutoSize = true;
            this.lblBancoDados.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancoDados.Location = new System.Drawing.Point(357, 102);
            this.lblBancoDados.Name = "lblBancoDados";
            this.lblBancoDados.Size = new System.Drawing.Size(97, 15);
            this.lblBancoDados.TabIndex = 10;
            this.lblBancoDados.Text = "Banco de Dados :";
            // 
            // txtSenhaAcesso
            // 
            this.txtSenhaAcesso.Location = new System.Drawing.Point(183, 120);
            this.txtSenhaAcesso.Name = "txtSenhaAcesso";
            this.txtSenhaAcesso.Size = new System.Drawing.Size(131, 25);
            this.txtSenhaAcesso.TabIndex = 9;
            // 
            // lblSenhaAcesso
            // 
            this.lblSenhaAcesso.AutoSize = true;
            this.lblSenhaAcesso.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAcesso.Location = new System.Drawing.Point(180, 102);
            this.lblSenhaAcesso.Name = "lblSenhaAcesso";
            this.lblSenhaAcesso.Size = new System.Drawing.Size(100, 15);
            this.lblSenhaAcesso.TabIndex = 8;
            this.lblSenhaAcesso.Text = "Senha de Acesso :";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(9, 120);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(131, 25);
            this.txtNomeUsuario.TabIndex = 7;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(6, 102);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(105, 15);
            this.lblNomeUsuario.TabIndex = 6;
            this.lblNomeUsuario.Text = "Nome do Usuário :";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(360, 52);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(131, 25);
            this.txtPorta.TabIndex = 5;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorta.Location = new System.Drawing.Point(357, 34);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(41, 15);
            this.lblPorta.TabIndex = 4;
            this.lblPorta.Text = "Porta :";
            // 
            // txtIpServidor
            // 
            this.txtIpServidor.Location = new System.Drawing.Point(9, 52);
            this.txtIpServidor.Name = "txtIpServidor";
            this.txtIpServidor.Size = new System.Drawing.Size(331, 25);
            this.txtIpServidor.TabIndex = 3;
            // 
            // lblEnderecoServidor
            // 
            this.lblEnderecoServidor.AutoSize = true;
            this.lblEnderecoServidor.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoServidor.Location = new System.Drawing.Point(6, 34);
            this.lblEnderecoServidor.Name = "lblEnderecoServidor";
            this.lblEnderecoServidor.Size = new System.Drawing.Size(153, 15);
            this.lblEnderecoServidor.TabIndex = 2;
            this.lblEnderecoServidor.Text = "Endereço de IP do Servidor :";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(662, 325);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(554, 325);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(102, 23);
            this.btnTestar.TabIndex = 3;
            this.btnTestar.Text = "Testar Conexão";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // gbAtualizacao
            // 
            this.gbAtualizacao.Controls.Add(this.txtCaminhoAtu);
            this.gbAtualizacao.Controls.Add(this.lblCaminhoAtu);
            this.gbAtualizacao.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAtualizacao.Location = new System.Drawing.Point(12, 197);
            this.gbAtualizacao.Name = "gbAtualizacao";
            this.gbAtualizacao.Size = new System.Drawing.Size(511, 98);
            this.gbAtualizacao.TabIndex = 4;
            this.gbAtualizacao.TabStop = false;
            this.gbAtualizacao.Text = "Caminho da Atualização";
            // 
            // txtCaminhoAtu
            // 
            this.txtCaminhoAtu.Location = new System.Drawing.Point(9, 55);
            this.txtCaminhoAtu.Name = "txtCaminhoAtu";
            this.txtCaminhoAtu.ReadOnly = true;
            this.txtCaminhoAtu.Size = new System.Drawing.Size(482, 25);
            this.txtCaminhoAtu.TabIndex = 12;
            // 
            // lblCaminhoAtu
            // 
            this.lblCaminhoAtu.AutoSize = true;
            this.lblCaminhoAtu.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminhoAtu.Location = new System.Drawing.Point(6, 37);
            this.lblCaminhoAtu.Name = "lblCaminhoAtu";
            this.lblCaminhoAtu.Size = new System.Drawing.Size(139, 15);
            this.lblCaminhoAtu.TabIndex = 12;
            this.lblCaminhoAtu.Text = "Caminho da Atualização :";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(553, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 280);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // frmSysBanco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(823, 350);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAtualizacao);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbConexao);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysBanco_Load);
            this.gbConexao.ResumeLayout(false);
            this.gbConexao.PerformLayout();
            this.gbAtualizacao.ResumeLayout(false);
            this.gbAtualizacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbConexao;
        private System.Windows.Forms.Label lblEnderecoServidor;
        private System.Windows.Forms.TextBox txtIpServidor;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSenhaAcesso;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtBancoDados;
        private System.Windows.Forms.Label lblBancoDados;
        private System.Windows.Forms.TextBox txtSenhaAcesso;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.GroupBox gbAtualizacao;
        private System.Windows.Forms.TextBox txtCaminhoAtu;
        private System.Windows.Forms.Label lblCaminhoAtu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}