namespace sysconfig
{
    partial class frmSysAddMod
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
            this.btnAdicionarModulo = new System.Windows.Forms.Button();
            this.lblIdModulo = new System.Windows.Forms.Label();
            this.txtIdModulo = new System.Windows.Forms.TextBox();
            this.gbAtivoInativo = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbDadosMod = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbAtivoInativo.SuspendLayout();
            this.gbDadosMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(390, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionarModulo
            // 
            this.btnAdicionarModulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarModulo.Location = new System.Drawing.Point(274, 185);
            this.btnAdicionarModulo.Name = "btnAdicionarModulo";
            this.btnAdicionarModulo.Size = new System.Drawing.Size(110, 23);
            this.btnAdicionarModulo.TabIndex = 1;
            this.btnAdicionarModulo.Text = "Adicionar Módulo";
            this.btnAdicionarModulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarModulo.UseVisualStyleBackColor = true;
            this.btnAdicionarModulo.Click += new System.EventHandler(this.btnAdicionarModulo_Click);
            // 
            // lblIdModulo
            // 
            this.lblIdModulo.AutoSize = true;
            this.lblIdModulo.Location = new System.Drawing.Point(12, 9);
            this.lblIdModulo.Name = "lblIdModulo";
            this.lblIdModulo.Size = new System.Drawing.Size(62, 13);
            this.lblIdModulo.TabIndex = 2;
            this.lblIdModulo.Text = "ID Módulo :";
            // 
            // txtIdModulo
            // 
            this.txtIdModulo.Location = new System.Drawing.Point(15, 25);
            this.txtIdModulo.Name = "txtIdModulo";
            this.txtIdModulo.ReadOnly = true;
            this.txtIdModulo.Size = new System.Drawing.Size(100, 20);
            this.txtIdModulo.TabIndex = 3;
            // 
            // gbAtivoInativo
            // 
            this.gbAtivoInativo.Controls.Add(this.rbInativo);
            this.gbAtivoInativo.Controls.Add(this.rbAtivo);
            this.gbAtivoInativo.Enabled = false;
            this.gbAtivoInativo.Location = new System.Drawing.Point(289, 9);
            this.gbAtivoInativo.Name = "gbAtivoInativo";
            this.gbAtivoInativo.Size = new System.Drawing.Size(176, 48);
            this.gbAtivoInativo.TabIndex = 5;
            this.gbAtivoInativo.TabStop = false;
            this.gbAtivoInativo.Text = "Configuração Módulo";
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
            // gbDadosMod
            // 
            this.gbDadosMod.Controls.Add(this.txtDescricao);
            this.gbDadosMod.Controls.Add(this.lblDescricao);
            this.gbDadosMod.Controls.Add(this.txtNome);
            this.gbDadosMod.Controls.Add(this.lblNome);
            this.gbDadosMod.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosMod.Location = new System.Drawing.Point(15, 63);
            this.gbDadosMod.Name = "gbDadosMod";
            this.gbDadosMod.Size = new System.Drawing.Size(450, 116);
            this.gbDadosMod.TabIndex = 6;
            this.gbDadosMod.TabStop = false;
            this.gbDadosMod.Text = "Dados do Módulo";
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
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome :";
            // 
            // frmSysAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 214);
            this.ControlBox = false;
            this.Controls.Add(this.gbDadosMod);
            this.Controls.Add(this.gbAtivoInativo);
            this.Controls.Add(this.txtIdModulo);
            this.Controls.Add(this.lblIdModulo);
            this.Controls.Add(this.btnAdicionarModulo);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysAddMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar novo Módulo";
            this.TopMost = true;
            this.gbAtivoInativo.ResumeLayout(false);
            this.gbAtivoInativo.PerformLayout();
            this.gbDadosMod.ResumeLayout(false);
            this.gbDadosMod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionarModulo;
        private System.Windows.Forms.Label lblIdModulo;
        private System.Windows.Forms.TextBox txtIdModulo;
        private System.Windows.Forms.GroupBox gbAtivoInativo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbDadosMod;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}