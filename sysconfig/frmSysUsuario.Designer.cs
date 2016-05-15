namespace sysconfig
{
    partial class frmSysUsuario
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
            this.dataGridViewUsu = new System.Windows.Forms.DataGridView();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtivarInativar = new System.Windows.Forms.Button();
            this.btnAdicionarUsu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsu)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(740, 325);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewUsu
            // 
            this.dataGridViewUsu.AllowUserToOrderColumns = true;
            this.dataGridViewUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsu.Location = new System.Drawing.Point(9, 21);
            this.dataGridViewUsu.Name = "dataGridViewUsu";
            this.dataGridViewUsu.Size = new System.Drawing.Size(641, 293);
            this.dataGridViewUsu.TabIndex = 1;
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.dataGridViewUsu);
            this.gbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarios.Location = new System.Drawing.Point(166, 2);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(659, 322);
            this.gbUsuarios.TabIndex = 2;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Lista de Usuários";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::sysconfig.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(12, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 35);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar Usuário";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtivarInativar
            // 
            this.btnAtivarInativar.Image = global::sysconfig.Properties.Resources.ativarinativar;
            this.btnAtivarInativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivarInativar.Location = new System.Drawing.Point(12, 93);
            this.btnAtivarInativar.Name = "btnAtivarInativar";
            this.btnAtivarInativar.Size = new System.Drawing.Size(148, 35);
            this.btnAtivarInativar.TabIndex = 4;
            this.btnAtivarInativar.Text = "Ativar / Inativar";
            this.btnAtivarInativar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivarInativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtivarInativar.UseVisualStyleBackColor = true;
            this.btnAtivarInativar.Click += new System.EventHandler(this.btnAtivarInativar_Click);
            // 
            // btnAdicionarUsu
            // 
            this.btnAdicionarUsu.Image = global::sysconfig.Properties.Resources.add1;
            this.btnAdicionarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarUsu.Location = new System.Drawing.Point(12, 9);
            this.btnAdicionarUsu.Name = "btnAdicionarUsu";
            this.btnAdicionarUsu.Size = new System.Drawing.Size(148, 35);
            this.btnAdicionarUsu.TabIndex = 3;
            this.btnAdicionarUsu.Text = "Adicionar Usuário";
            this.btnAdicionarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarUsu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarUsu.UseVisualStyleBackColor = true;
            this.btnAdicionarUsu.Click += new System.EventHandler(this.btnAdicionarUsu_Click);
            // 
            // frmSysUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(827, 353);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAtivarInativar);
            this.Controls.Add(this.btnAdicionarUsu);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmSysUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsu)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridViewUsu;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.Button btnAdicionarUsu;
        private System.Windows.Forms.Button btnAtivarInativar;
        private System.Windows.Forms.Button btnEditar;
    }
}