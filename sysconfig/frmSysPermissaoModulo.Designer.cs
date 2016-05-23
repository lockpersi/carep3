namespace sysconfig
{
    partial class frmSysPermissaoModulo
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
            this.dataGridViewPerMod = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.txtNomeModulo = new System.Windows.Forms.TextBox();
            this.lblIdPrograma = new System.Windows.Forms.Label();
            this.lblNomeModulo = new System.Windows.Forms.Label();
            this.txtIdModulo = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerMod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPerMod
            // 
            this.dataGridViewPerMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerMod.Location = new System.Drawing.Point(12, 192);
            this.dataGridViewPerMod.Name = "dataGridViewPerMod";
            this.dataGridViewPerMod.Size = new System.Drawing.Size(446, 225);
            this.dataGridViewPerMod.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomeUsuario);
            this.groupBox1.Controls.Add(this.cbUsuarios);
            this.groupBox1.Controls.Add(this.txtNomeModulo);
            this.groupBox1.Controls.Add(this.lblIdPrograma);
            this.groupBox1.Controls.Add(this.lblNomeModulo);
            this.groupBox1.Controls.Add(this.txtIdModulo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões de Módulo";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(6, 76);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(95, 13);
            this.lblNomeUsuario.TabIndex = 16;
            this.lblNomeUsuario.Text = "Nome do Usuário :";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(9, 92);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cbUsuarios.TabIndex = 15;
            // 
            // txtNomeModulo
            // 
            this.txtNomeModulo.Location = new System.Drawing.Point(115, 44);
            this.txtNomeModulo.Name = "txtNomeModulo";
            this.txtNomeModulo.ReadOnly = true;
            this.txtNomeModulo.Size = new System.Drawing.Size(160, 20);
            this.txtNomeModulo.TabIndex = 14;
            // 
            // lblIdPrograma
            // 
            this.lblIdPrograma.AutoSize = true;
            this.lblIdPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPrograma.Location = new System.Drawing.Point(6, 28);
            this.lblIdPrograma.Name = "lblIdPrograma";
            this.lblIdPrograma.Size = new System.Drawing.Size(62, 13);
            this.lblIdPrograma.TabIndex = 11;
            this.lblIdPrograma.Text = "ID Modulo :";
            // 
            // lblNomeModulo
            // 
            this.lblNomeModulo.AutoSize = true;
            this.lblNomeModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeModulo.Location = new System.Drawing.Point(112, 28);
            this.lblNomeModulo.Name = "lblNomeModulo";
            this.lblNomeModulo.Size = new System.Drawing.Size(79, 13);
            this.lblNomeModulo.TabIndex = 13;
            this.lblNomeModulo.Text = "Nome Módulo :";
            // 
            // txtIdModulo
            // 
            this.txtIdModulo.Location = new System.Drawing.Point(9, 44);
            this.txtIdModulo.Name = "txtIdModulo";
            this.txtIdModulo.ReadOnly = true;
            this.txtIdModulo.Size = new System.Drawing.Size(100, 20);
            this.txtIdModulo.TabIndex = 12;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(383, 157);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 157);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(383, 423);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmSysPermissaoModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridViewPerMod);
            this.Name = "frmSysPermissaoModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissões de Módulo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSysPermissaoModulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerMod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPerMod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeModulo;
        private System.Windows.Forms.Label lblIdPrograma;
        private System.Windows.Forms.Label lblNomeModulo;
        private System.Windows.Forms.TextBox txtIdModulo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.ComboBox cbUsuarios;
    }
}