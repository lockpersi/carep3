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
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.gbEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(758, 331);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.Controls.Add(this.txtRazaoSocial);
            this.gbEmpresa.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmpresa.Location = new System.Drawing.Point(12, 12);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(690, 140);
            this.gbEmpresa.TabIndex = 1;
            this.gbEmpresa.TabStop = false;
            this.gbEmpresa.Text = "Empresa";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(21, 43);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(100, 24);
            this.txtRazaoSocial.TabIndex = 2;
            // 
            // frmSysSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 360);
            this.ControlBox = false;
            this.Controls.Add(this.gbEmpresa);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbEmpresa;
        private System.Windows.Forms.TextBox txtRazaoSocial;
    }
}