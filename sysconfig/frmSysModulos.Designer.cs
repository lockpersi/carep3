namespace sysconfig
{
    partial class frmSysModulos
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
            this.dataGridViewMod = new System.Windows.Forms.DataGridView();
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionarMod = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAdicionarPermissao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMod)).BeginInit();
            this.gbModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMod
            // 
            this.dataGridViewMod.AllowUserToOrderColumns = true;
            this.dataGridViewMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMod.Location = new System.Drawing.Point(9, 21);
            this.dataGridViewMod.Name = "dataGridViewMod";
            this.dataGridViewMod.Size = new System.Drawing.Size(641, 293);
            this.dataGridViewMod.TabIndex = 1;
            // 
            // gbModulos
            // 
            this.gbModulos.Controls.Add(this.dataGridViewMod);
            this.gbModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModulos.Location = new System.Drawing.Point(156, 1);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(661, 321);
            this.gbModulos.TabIndex = 3;
            this.gbModulos.TabStop = false;
            this.gbModulos.Text = "Módulos Cadastrados";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(731, 324);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdicionarMod
            // 
            this.btnAdicionarMod.Image = global::sysconfig.Properties.Resources.add1;
            this.btnAdicionarMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarMod.Location = new System.Drawing.Point(5, 12);
            this.btnAdicionarMod.Name = "btnAdicionarMod";
            this.btnAdicionarMod.Size = new System.Drawing.Size(148, 35);
            this.btnAdicionarMod.TabIndex = 4;
            this.btnAdicionarMod.Text = "Adicionar Módulo";
            this.btnAdicionarMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarMod.UseVisualStyleBackColor = true;
            this.btnAdicionarMod.Click += new System.EventHandler(this.btnAdicionarMod_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::sysconfig.Properties.Resources.deletar;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(5, 53);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(148, 35);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "Deletar Módulo";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAdicionarPermissao
            // 
            this.btnAdicionarPermissao.Image = global::sysconfig.Properties.Resources.users_edit;
            this.btnAdicionarPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarPermissao.Location = new System.Drawing.Point(5, 94);
            this.btnAdicionarPermissao.Name = "btnAdicionarPermissao";
            this.btnAdicionarPermissao.Size = new System.Drawing.Size(148, 53);
            this.btnAdicionarPermissao.TabIndex = 7;
            this.btnAdicionarPermissao.Text = "Permissões";
            this.btnAdicionarPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarPermissao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarPermissao.UseVisualStyleBackColor = true;
            this.btnAdicionarPermissao.Click += new System.EventHandler(this.btnAdicionarPermissao_Click);
            // 
            // frmSysModulos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 343);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdicionarPermissao);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAdicionarMod);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbModulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysModulos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSysModulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMod)).EndInit();
            this.gbModulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMod;
        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionarMod;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAdicionarPermissao;
    }
}