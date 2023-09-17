namespace Diseño.Formularios
{
    partial class PrincipalFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFrm));
            this.panelDerecha = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelPortaLogo = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelDerecha.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelPortaLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDerecha
            // 
            this.panelDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.panelDerecha.Controls.Add(this.panelBotones);
            this.panelDerecha.Controls.Add(this.panelPortaLogo);
            this.panelDerecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDerecha.Location = new System.Drawing.Point(0, 0);
            this.panelDerecha.Name = "panelDerecha";
            this.panelDerecha.Size = new System.Drawing.Size(220, 561);
            this.panelDerecha.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.panelBotones.Controls.Add(this.btnUsuarios);
            this.panelBotones.Controls.Add(this.btnMatricula);
            this.panelBotones.Controls.Add(this.btnMenu);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(0, 178);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(220, 383);
            this.panelBotones.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 160);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(220, 80);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnMatricula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.ForeColor = System.Drawing.Color.White;
            this.btnMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnMatricula.Image")));
            this.btnMatricula.Location = new System.Drawing.Point(0, 80);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(220, 80);
            this.btnMatricula.TabIndex = 3;
            this.btnMatricula.Text = " Matricula";
            this.btnMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatricula.UseVisualStyleBackColor = true;
            this.btnMatricula.Click += new System.EventHandler(this.SeleccionButtons);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu.Size = new System.Drawing.Size(220, 80);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.SeleccionButtons);
            // 
            // panelPortaLogo
            // 
            this.panelPortaLogo.Controls.Add(this.panelLogo);
            this.panelPortaLogo.Controls.Add(this.panel1);
            this.panelPortaLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPortaLogo.Location = new System.Drawing.Point(0, 0);
            this.panelPortaLogo.Name = "panelPortaLogo";
            this.panelPortaLogo.Size = new System.Drawing.Size(220, 178);
            this.panelPortaLogo.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(30, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 170);
            this.panelLogo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(173)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 4);
            this.panel1.TabIndex = 1;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(220, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(788, 25);
            this.panelEncabezado.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(200)))), ((int)(((byte)(201)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 25);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(788, 536);
            this.panelContenedor.TabIndex = 2;
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelEncabezado);
            this.Controls.Add(this.panelDerecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "PrincipalFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEAT Nº1 San Vicente";
            this.Load += new System.EventHandler(this.PrincipalFrm_Load);
            this.panelDerecha.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelPortaLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDerecha;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelPortaLogo;
        private System.Windows.Forms.Panel panelLogo;
    }
}