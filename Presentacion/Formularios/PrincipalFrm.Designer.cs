namespace Presentacion.Formularios
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
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelPortaLogo = new System.Windows.Forms.Panel();
            this.panelLogo2 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbTamañoNormal = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelDerecha.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelPortaLogo.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamañoNormal)).BeginInit();
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
            this.panelDerecha.Size = new System.Drawing.Size(220, 600);
            this.panelDerecha.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.panelBotones.Controls.Add(this.btnDocentes);
            this.panelBotones.Controls.Add(this.btnMatricula);
            this.panelBotones.Controls.Add(this.btnMenu);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(0, 220);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(220, 380);
            this.panelBotones.TabIndex = 0;
            // 
            // btnDocentes
            // 
            this.btnDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.Color.White;
            this.btnDocentes.Image = global::Presentacion.Properties.Resources.icons8_people_32;
            this.btnDocentes.Location = new System.Drawing.Point(0, 160);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(220, 80);
            this.btnDocentes.TabIndex = 2;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocentes.UseVisualStyleBackColor = false;
            this.btnDocentes.Click += new System.EventHandler(this.SeleccionButtons);
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnMatricula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.ForeColor = System.Drawing.Color.White;
            this.btnMatricula.Image = global::Presentacion.Properties.Resources.icons8_book_32;
            this.btnMatricula.Location = new System.Drawing.Point(0, 80);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(220, 80);
            this.btnMatricula.TabIndex = 3;
            this.btnMatricula.Text = " Matricula";
            this.btnMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.Click += new System.EventHandler(this.SeleccionButtons);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::Presentacion.Properties.Resources.icons8_circled_menu_32;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu.Size = new System.Drawing.Size(220, 80);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.SeleccionButtons);
            // 
            // panelPortaLogo
            // 
            this.panelPortaLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.panelPortaLogo.Controls.Add(this.panelLogo2);
            this.panelPortaLogo.Controls.Add(this.labelTitulo);
            this.panelPortaLogo.Controls.Add(this.panelLogo);
            this.panelPortaLogo.Controls.Add(this.panel1);
            this.panelPortaLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPortaLogo.Location = new System.Drawing.Point(0, 0);
            this.panelPortaLogo.Name = "panelPortaLogo";
            this.panelPortaLogo.Size = new System.Drawing.Size(220, 220);
            this.panelPortaLogo.TabIndex = 0;
            // 
            // panelLogo2
            // 
            this.panelLogo2.BackgroundImage = global::Presentacion.Properties.Resources.icons8_school_100;
            this.panelLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo2.Location = new System.Drawing.Point(3, 5);
            this.panelLogo2.Name = "panelLogo2";
            this.panelLogo2.Size = new System.Drawing.Size(15, 15);
            this.panelLogo2.TabIndex = 3;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(22, 6);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(117, 13);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "SEAT Nº1 San Vicente";
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Presentacion.Properties.Resources.icons8_school_100;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(25, 30);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 170);
            this.panelLogo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 4);
            this.panel1.TabIndex = 1;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.panelEncabezado.Controls.Add(this.pbMinimizar);
            this.panelEncabezado.Controls.Add(this.pbSalir);
            this.panelEncabezado.Controls.Add(this.pbMaximizar);
            this.panelEncabezado.Controls.Add(this.pbTamañoNormal);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(220, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(804, 30);
            this.panelEncabezado.TabIndex = 1;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Image = global::Presentacion.Properties.Resources.icons8_minimize_48;
            this.pbMinimizar.Location = new System.Drawing.Point(653, 1);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(50, 25);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 4;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            this.pbMinimizar.MouseLeave += new System.EventHandler(this.ColorNormal);
            this.pbMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarColor);
            // 
            // pbSalir
            // 
            this.pbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSalir.Image = global::Presentacion.Properties.Resources.icons8_multiply_48;
            this.pbSalir.Location = new System.Drawing.Point(753, 1);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(50, 25);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalir.TabIndex = 2;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            this.pbSalir.MouseLeave += new System.EventHandler(this.ColorNormal);
            this.pbSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarColor);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.Image = global::Presentacion.Properties.Resources.Mesa_de_trabajo_1;
            this.pbMaximizar.Location = new System.Drawing.Point(703, 1);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(50, 25);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizar.TabIndex = 5;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            this.pbMaximizar.MouseLeave += new System.EventHandler(this.ColorNormal);
            this.pbMaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarColor);
            // 
            // pbTamañoNormal
            // 
            this.pbTamañoNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTamañoNormal.Image = global::Presentacion.Properties.Resources.Mesa_de_trabajo_2;
            this.pbTamañoNormal.Location = new System.Drawing.Point(703, 1);
            this.pbTamañoNormal.Name = "pbTamañoNormal";
            this.pbTamañoNormal.Size = new System.Drawing.Size(50, 25);
            this.pbTamañoNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTamañoNormal.TabIndex = 3;
            this.pbTamañoNormal.TabStop = false;
            this.pbTamañoNormal.Click += new System.EventHandler(this.pbTamañoNormal_Click);
            this.pbTamañoNormal.MouseLeave += new System.EventHandler(this.ColorNormal);
            this.pbTamañoNormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarColor);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 30);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(804, 570);
            this.panelContenedor.TabIndex = 2;
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelEncabezado);
            this.Controls.Add(this.panelDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "PrincipalFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEAT Nº1 San Vicente";
            this.Load += new System.EventHandler(this.PrincipalFrm_Load);
            this.panelDerecha.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelPortaLogo.ResumeLayout(false);
            this.panelPortaLogo.PerformLayout();
            this.panelEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamañoNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDerecha;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelPortaLogo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelLogo2;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbTamañoNormal;
    }
}