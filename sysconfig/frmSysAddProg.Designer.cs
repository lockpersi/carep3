namespace sysconfig
{
    partial class frmSysAddProg
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbAtivoInativo = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.txtIdPrograma = new System.Windows.Forms.TextBox();
            this.lblIdPrograma = new System.Windows.Forms.Label();
            this.gbDadosProg = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomeModulo = new System.Windows.Forms.Label();
            this.cbModulos = new System.Windows.Forms.ComboBox();
            this.btnChamada = new System.Windows.Forms.Label();
            this.txtChamada = new System.Windows.Forms.TextBox();
            this.btnAdicionarPrograma = new System.Windows.Forms.Button();
            this.gbAtivoInativo.SuspendLayout();
            this.gbDadosProg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(400, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbAtivoInativo
            // 
            this.gbAtivoInativo.Controls.Add(this.rbInativo);
            this.gbAtivoInativo.Controls.Add(this.rbAtivo);
            this.gbAtivoInativo.Enabled = false;
            this.gbAtivoInativo.Location = new System.Drawing.Point(299, 4);
            this.gbAtivoInativo.Name = "gbAtivoInativo";
            this.gbAtivoInativo.Size = new System.Drawing.Size(176, 48);
            this.gbAtivoInativo.TabIndex = 8;
            this.gbAtivoInativo.TabStop = false;
            this.gbAtivoInativo.Text = "Configuração Programa";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Enabled = false;
            this.rbInativo.Location = new System.Drawing.Point(101, 19);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Enabled = false;
            this.rbAtivo.Location = new System.Drawing.Point(23, 19);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtIdPrograma
            // 
            this.txtIdPrograma.Location = new System.Drawing.Point(21, 20);
            this.txtIdPrograma.Name = "txtIdPrograma";
            this.txtIdPrograma.ReadOnly = true;
            this.txtIdPrograma.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrograma.TabIndex = 7;
            // 
            // lblIdPrograma
            // 
            this.lblIdPrograma.AutoSize = true;
            this.lblIdPrograma.Location = new System.Drawing.Point(21, 4);
            this.lblIdPrograma.Name = "lblIdPrograma";
            this.lblIdPrograma.Size = new System.Drawing.Size(72, 13);
            this.lblIdPrograma.TabIndex = 6;
            this.lblIdPrograma.Text = "ID Programa :";
            // 
            // gbDadosProg
            // 
            this.gbDadosProg.Controls.Add(this.txtChamada);
            this.gbDadosProg.Controls.Add(this.btnChamada);
            this.gbDadosProg.Controls.Add(this.txtDescricao);
            this.gbDadosProg.Controls.Add(this.lblDescricao);
            this.gbDadosProg.Controls.Add(this.txtNome);
            this.gbDadosProg.Controls.Add(this.lblNome);
            this.gbDadosProg.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosProg.Location = new System.Drawing.Point(15, 51);
            this.gbDadosProg.Name = "gbDadosProg";
            this.gbDadosProg.Size = new System.Drawing.Size(450, 156);
            this.gbDadosProg.TabIndex = 9;
            this.gbDadosProg.TabStop = false;
            this.gbDadosProg.Text = "Dados do Programa";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(9, 81);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(423, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 65);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descição :";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(423, 20);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(201, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome do Formulário ( ex: frmSysBanco ) :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbModulos);
            this.groupBox1.Controls.Add(this.lblNomeModulo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 84);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Módulo :";
            // 
            // lblNomeModulo
            // 
            this.lblNomeModulo.AutoSize = true;
            this.lblNomeModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeModulo.Location = new System.Drawing.Point(6, 26);
            this.lblNomeModulo.Name = "lblNomeModulo";
            this.lblNomeModulo.Size = new System.Drawing.Size(202, 13);
            this.lblNomeModulo.TabIndex = 6;
            this.lblNomeModulo.Text = "Selecione o módulo do programa abaixo :";
            // 
            // cbModulos
            // 
            this.cbModulos.FormattingEnabled = true;
            this.cbModulos.Location = new System.Drawing.Point(9, 42);
            this.cbModulos.Name = "cbModulos";
            this.cbModulos.Size = new System.Drawing.Size(121, 25);
            this.cbModulos.TabIndex = 7;
            // 
            // btnChamada
            // 
            this.btnChamada.AutoSize = true;
            this.btnChamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamada.Location = new System.Drawing.Point(6, 104);
            this.btnChamada.Name = "btnChamada";
            this.btnChamada.Size = new System.Drawing.Size(103, 13);
            this.btnChamada.TabIndex = 10;
            this.btnChamada.Text = "Nome da chamada :";
            // 
            // txtChamada
            // 
            this.txtChamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChamada.Location = new System.Drawing.Point(9, 120);
            this.txtChamada.Name = "txtChamada";
            this.txtChamada.Size = new System.Drawing.Size(423, 20);
            this.txtChamada.TabIndex = 11;
            // 
            // btnAdicionarPrograma
            // 
            this.btnAdicionarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarPrograma.Location = new System.Drawing.Point(283, 315);
            this.btnAdicionarPrograma.Name = "btnAdicionarPrograma";
            this.btnAdicionarPrograma.Size = new System.Drawing.Size(114, 23);
            this.btnAdicionarPrograma.TabIndex = 11;
            this.btnAdicionarPrograma.Text = "Adicionar Programa";
            this.btnAdicionarPrograma.UseVisualStyleBackColor = true;
            this.btnAdicionarPrograma.Click += new System.EventHandler(this.btnAdicionarPrograma_Click);
            // 
            // frmSysAddProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdicionarPrograma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDadosProg);
            this.Controls.Add(this.gbAtivoInativo);
            this.Controls.Add(this.txtIdPrograma);
            this.Controls.Add(this.lblIdPrograma);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysAddProg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar novo Programa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSysAddProg_Load);
            this.gbAtivoInativo.ResumeLayout(false);
            this.gbAtivoInativo.PerformLayout();
            this.gbDadosProg.ResumeLayout(false);
            this.gbDadosProg.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbAtivoInativo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.TextBox txtIdPrograma;
        private System.Windows.Forms.Label lblIdPrograma;
        private System.Windows.Forms.GroupBox gbDadosProg;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbModulos;
        private System.Windows.Forms.Label lblNomeModulo;
        private System.Windows.Forms.TextBox txtChamada;
        private System.Windows.Forms.Label btnChamada;
        private System.Windows.Forms.Button btnAdicionarPrograma;
    }
}