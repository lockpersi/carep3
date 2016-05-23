namespace sysconfig
{
    partial class frmSysPermissao
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
            this.dataGridViewPer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.gbPermissaoUsuario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbExcluir = new System.Windows.Forms.CheckBox();
            this.chbAlterar = new System.Windows.Forms.CheckBox();
            this.chbInserir = new System.Windows.Forms.CheckBox();
            this.txtNomeModulo = new System.Windows.Forms.TextBox();
            this.lblNomeModulo = new System.Windows.Forms.Label();
            this.txtNomeFormulario = new System.Windows.Forms.TextBox();
            this.lblNomeFormulario = new System.Windows.Forms.Label();
            this.txtIdPrograma = new System.Windows.Forms.TextBox();
            this.lblIdPrograma = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPer)).BeginInit();
            this.gbPermissaoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPer
            // 
            this.dataGridViewPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPer.Location = new System.Drawing.Point(8, 228);
            this.dataGridViewPer.Name = "dataGridViewPer";
            this.dataGridViewPer.Size = new System.Drawing.Size(498, 217);
            this.dataGridViewPer.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(431, 199);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(431, 451);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(175, 96);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cbUsuarios.TabIndex = 5;
            // 
            // gbPermissaoUsuario
            // 
            this.gbPermissaoUsuario.Controls.Add(this.label1);
            this.gbPermissaoUsuario.Controls.Add(this.chbExcluir);
            this.gbPermissaoUsuario.Controls.Add(this.chbAlterar);
            this.gbPermissaoUsuario.Controls.Add(this.chbInserir);
            this.gbPermissaoUsuario.Controls.Add(this.txtNomeModulo);
            this.gbPermissaoUsuario.Controls.Add(this.lblNomeModulo);
            this.gbPermissaoUsuario.Controls.Add(this.txtNomeFormulario);
            this.gbPermissaoUsuario.Controls.Add(this.lblNomeFormulario);
            this.gbPermissaoUsuario.Controls.Add(this.txtIdPrograma);
            this.gbPermissaoUsuario.Controls.Add(this.lblIdPrograma);
            this.gbPermissaoUsuario.Controls.Add(this.lblNomeUsuario);
            this.gbPermissaoUsuario.Controls.Add(this.cbUsuarios);
            this.gbPermissaoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissaoUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbPermissaoUsuario.Name = "gbPermissaoUsuario";
            this.gbPermissaoUsuario.Size = new System.Drawing.Size(494, 181);
            this.gbPermissaoUsuario.TabIndex = 6;
            this.gbPermissaoUsuario.TabStop = false;
            this.gbPermissaoUsuario.Text = "Permissões de Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Permissão do Usuário :";
            // 
            // chbExcluir
            // 
            this.chbExcluir.AutoSize = true;
            this.chbExcluir.Location = new System.Drawing.Point(140, 144);
            this.chbExcluir.Name = "chbExcluir";
            this.chbExcluir.Size = new System.Drawing.Size(64, 17);
            this.chbExcluir.TabIndex = 15;
            this.chbExcluir.Text = "Excluir";
            this.chbExcluir.UseVisualStyleBackColor = true;
            // 
            // chbAlterar
            // 
            this.chbAlterar.AutoSize = true;
            this.chbAlterar.Location = new System.Drawing.Point(76, 144);
            this.chbAlterar.Name = "chbAlterar";
            this.chbAlterar.Size = new System.Drawing.Size(63, 17);
            this.chbAlterar.TabIndex = 14;
            this.chbAlterar.Text = "Alterar";
            this.chbAlterar.UseVisualStyleBackColor = true;
            // 
            // chbInserir
            // 
            this.chbInserir.AutoSize = true;
            this.chbInserir.Location = new System.Drawing.Point(9, 144);
            this.chbInserir.Name = "chbInserir";
            this.chbInserir.Size = new System.Drawing.Size(61, 17);
            this.chbInserir.TabIndex = 13;
            this.chbInserir.Text = "Inserir";
            this.chbInserir.UseVisualStyleBackColor = true;
            // 
            // txtNomeModulo
            // 
            this.txtNomeModulo.Location = new System.Drawing.Point(9, 96);
            this.txtNomeModulo.Name = "txtNomeModulo";
            this.txtNomeModulo.ReadOnly = true;
            this.txtNomeModulo.Size = new System.Drawing.Size(160, 20);
            this.txtNomeModulo.TabIndex = 12;
            // 
            // lblNomeModulo
            // 
            this.lblNomeModulo.AutoSize = true;
            this.lblNomeModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeModulo.Location = new System.Drawing.Point(6, 80);
            this.lblNomeModulo.Name = "lblNomeModulo";
            this.lblNomeModulo.Size = new System.Drawing.Size(79, 13);
            this.lblNomeModulo.TabIndex = 11;
            this.lblNomeModulo.Text = "Nome Módulo :";
            // 
            // txtNomeFormulario
            // 
            this.txtNomeFormulario.Location = new System.Drawing.Point(115, 44);
            this.txtNomeFormulario.Name = "txtNomeFormulario";
            this.txtNomeFormulario.ReadOnly = true;
            this.txtNomeFormulario.Size = new System.Drawing.Size(160, 20);
            this.txtNomeFormulario.TabIndex = 10;
            // 
            // lblNomeFormulario
            // 
            this.lblNomeFormulario.AutoSize = true;
            this.lblNomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFormulario.Location = new System.Drawing.Point(112, 28);
            this.lblNomeFormulario.Name = "lblNomeFormulario";
            this.lblNomeFormulario.Size = new System.Drawing.Size(92, 13);
            this.lblNomeFormulario.TabIndex = 9;
            this.lblNomeFormulario.Text = "Nome Formulário :";
            // 
            // txtIdPrograma
            // 
            this.txtIdPrograma.Location = new System.Drawing.Point(9, 44);
            this.txtIdPrograma.Name = "txtIdPrograma";
            this.txtIdPrograma.ReadOnly = true;
            this.txtIdPrograma.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrograma.TabIndex = 8;
            // 
            // lblIdPrograma
            // 
            this.lblIdPrograma.AutoSize = true;
            this.lblIdPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPrograma.Location = new System.Drawing.Point(6, 28);
            this.lblIdPrograma.Name = "lblIdPrograma";
            this.lblIdPrograma.Size = new System.Drawing.Size(72, 13);
            this.lblIdPrograma.TabIndex = 7;
            this.lblIdPrograma.Text = "ID Programa :";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(172, 80);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(95, 13);
            this.lblNomeUsuario.TabIndex = 6;
            this.lblNomeUsuario.Text = "Nome do Usuário :";
            // 
            // frmSysPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 477);
            this.ControlBox = false;
            this.Controls.Add(this.gbPermissaoUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPer);
            this.Name = "frmSysPermissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissões de Usuários";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSysPermissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPer)).EndInit();
            this.gbPermissaoUsuario.ResumeLayout(false);
            this.gbPermissaoUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.GroupBox gbPermissaoUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtIdPrograma;
        private System.Windows.Forms.Label lblIdPrograma;
        private System.Windows.Forms.TextBox txtNomeFormulario;
        private System.Windows.Forms.Label lblNomeFormulario;
        private System.Windows.Forms.TextBox txtNomeModulo;
        private System.Windows.Forms.Label lblNomeModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbExcluir;
        private System.Windows.Forms.CheckBox chbAlterar;
        private System.Windows.Forms.CheckBox chbInserir;
    }
}