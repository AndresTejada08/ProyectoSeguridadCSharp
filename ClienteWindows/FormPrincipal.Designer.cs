
namespace ClienteWindows
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnMaximizar = new System.Windows.Forms.PictureBox();
            this.bttnRestaurar = new System.Windows.Forms.PictureBox();
            this.bttnMinimizar = new System.Windows.Forms.PictureBox();
            this.bttnCerrar = new System.Windows.Forms.PictureBox();
            this.bttnMenú = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.bttnUsuario = new System.Windows.Forms.Button();
            this.bttnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnMenú)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.bttnMaximizar);
            this.panel1.Controls.Add(this.bttnRestaurar);
            this.panel1.Controls.Add(this.bttnMinimizar);
            this.panel1.Controls.Add(this.bttnCerrar);
            this.panel1.Controls.Add(this.bttnMenú);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 67);
            this.panel1.TabIndex = 4;
            // 
            // bttnMaximizar
            // 
            this.bttnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("bttnMaximizar.Image")));
            this.bttnMaximizar.Location = new System.Drawing.Point(1404, 12);
            this.bttnMaximizar.Name = "bttnMaximizar";
            this.bttnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.bttnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnMaximizar.TabIndex = 9;
            this.bttnMaximizar.TabStop = false;
            this.bttnMaximizar.Click += new System.EventHandler(this.bttnMaximizar_Click);
            // 
            // bttnRestaurar
            // 
            this.bttnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("bttnRestaurar.Image")));
            this.bttnRestaurar.Location = new System.Drawing.Point(1404, 12);
            this.bttnRestaurar.Name = "bttnRestaurar";
            this.bttnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.bttnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnRestaurar.TabIndex = 12;
            this.bttnRestaurar.TabStop = false;
            this.bttnRestaurar.Click += new System.EventHandler(this.bttnRestaurar_Click);
            // 
            // bttnMinimizar
            // 
            this.bttnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("bttnMinimizar.Image")));
            this.bttnMinimizar.Location = new System.Drawing.Point(1358, 12);
            this.bttnMinimizar.Name = "bttnMinimizar";
            this.bttnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.bttnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnMinimizar.TabIndex = 11;
            this.bttnMinimizar.TabStop = false;
            this.bttnMinimizar.Click += new System.EventHandler(this.bttnMinimizar_Click);
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("bttnCerrar.Image")));
            this.bttnCerrar.Location = new System.Drawing.Point(1450, 12);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(40, 40);
            this.bttnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnCerrar.TabIndex = 10;
            this.bttnCerrar.TabStop = false;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // bttnMenú
            // 
            this.bttnMenú.Image = ((System.Drawing.Image)(resources.GetObject("bttnMenú.Image")));
            this.bttnMenú.Location = new System.Drawing.Point(12, 14);
            this.bttnMenú.Name = "bttnMenú";
            this.bttnMenú.Size = new System.Drawing.Size(38, 38);
            this.bttnMenú.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnMenú.TabIndex = 8;
            this.bttnMenú.TabStop = false;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.panelLateral.Controls.Add(this.bttnUsuario);
            this.panelLateral.Controls.Add(this.bttnDashboard);
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.label3);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 67);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(270, 783);
            this.panelLateral.TabIndex = 5;
            // 
            // bttnUsuario
            // 
            this.bttnUsuario.FlatAppearance.BorderSize = 0;
            this.bttnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUsuario.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUsuario.ForeColor = System.Drawing.Color.White;
            this.bttnUsuario.Location = new System.Drawing.Point(55, 225);
            this.bttnUsuario.Name = "bttnUsuario";
            this.bttnUsuario.Size = new System.Drawing.Size(160, 50);
            this.bttnUsuario.TabIndex = 228;
            this.bttnUsuario.Text = "Usuario";
            this.bttnUsuario.UseVisualStyleBackColor = true;
            this.bttnUsuario.Click += new System.EventHandler(this.bttnUsuario_Click);
            // 
            // bttnDashboard
            // 
            this.bttnDashboard.FlatAppearance.BorderSize = 0;
            this.bttnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDashboard.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDashboard.ForeColor = System.Drawing.Color.White;
            this.bttnDashboard.Location = new System.Drawing.Point(55, 153);
            this.bttnDashboard.Name = "bttnDashboard";
            this.bttnDashboard.Size = new System.Drawing.Size(160, 50);
            this.bttnDashboard.TabIndex = 227;
            this.bttnDashboard.Text = "Dashboard";
            this.bttnDashboard.UseVisualStyleBackColor = true;
            this.bttnDashboard.Click += new System.EventHandler(this.bttnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 33);
            this.label1.TabIndex = 226;
            this.label1.Text = "WIRAKOCHAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 225;
            this.label3.Text = "GRUPO";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(270, 67);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1230, 783);
            this.panelContenedor.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bttnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnMenú)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bttnMaximizar;
        private System.Windows.Forms.PictureBox bttnRestaurar;
        private System.Windows.Forms.PictureBox bttnMinimizar;
        private System.Windows.Forms.PictureBox bttnCerrar;
        private System.Windows.Forms.PictureBox bttnMenú;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button bttnUsuario;
        private System.Windows.Forms.Button bttnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContenedor;
    }
}