namespace sysconfig
{
    partial class frmSysProgramas
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
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.dataGridViewPro = new System.Windows.Forms.DataGridView();
            this.btnAdicionarPermissao = new System.Windows.Forms.Button();
            this.btnAdicionarProg = new System.Windows.Forms.Button();
            this.gbModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPro)).BeginInit();
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
            // gbModulos
            // 
            this.gbModulos.Controls.Add(this.dataGridViewPro);
            this.gbModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModulos.Location = new System.Drawing.Point(156, 5);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(661, 321);
            this.gbModulos.TabIndex = 4;
            this.gbModulos.TabStop = false;
            this.gbModulos.Text = "Programas Cadastrados";
            // 
            // dataGridViewPro
            // 
            this.dataGridViewPro.AllowUserToOrderColumns = true;
            this.dataGridViewPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPro.Location = new System.Drawing.Point(9, 21);
            this.dataGridViewPro.Name = "dataGridViewPro";
            this.dataGridViewPro.Size = new System.Drawing.Size(652, 293);
            this.dataGridViewPro.TabIndex = 1;
            // 
            // btnAdicionarPermissao
            // 
            this.btnAdicionarPermissao.Image = global::sysconfig.Properties.Resources.users_edit;
            this.btnAdicionarPermissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarPermissao.Location = new System.Drawing.Point(4, 51);
            this.btnAdicionarPermissao.Name = "btnAdicionarPermissao";
            this.btnAdicionarPermissao.Size = new System.Drawing.Size(148, 53);
            this.btnAdicionarPermissao.TabIndex = 6;
            this.btnAdicionarPermissao.Text = "Permissões";
            this.btnAdicionarPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarPermissao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarPermissao.UseVisualStyleBackColor = true;
            this.btnAdicionarPermissao.Click += new System.EventHandler(this.btnAdicionarPermissao_Click);
            // 
            // btnAdicionarProg
            // 
            this.btnAdicionarProg.Image = global::sysconfig.Properties.Resources.add1;
            this.btnAdicionarProg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProg.Location = new System.Drawing.Point(4, 10);
            this.btnAdicionarProg.Name = "btnAdicionarProg";
            this.btnAdicionarProg.Size = new System.Drawing.Size(148, 35);
            this.btnAdicionarProg.TabIndex = 5;
            this.btnAdicionarProg.Text = "Adicionar Programa";
            this.btnAdicionarProg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarProg.UseVisualStyleBackColor = true;
            this.btnAdicionarProg.Click += new System.EventHandler(this.btnAdicionarProg_Click);
            // 
            // frmSysProgramas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 354);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdicionarPermissao);
            this.Controls.Add(this.btnAdicionarProg);
            this.Controls.Add(this.gbModulos);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysProgramas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmSysProgramas_Load);
            this.gbModulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.DataGridView dataGridViewPro;
        private System.Windows.Forms.Button btnAdicionarProg;
        private System.Windows.Forms.Button btnAdicionarPermissao;
    }
}