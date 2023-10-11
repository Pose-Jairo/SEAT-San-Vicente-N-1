namespace Presentacion.Formularios
{
    partial class DocentesFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBajaDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnAltaDocente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(710, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(18, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(16, 25);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(52, 13);
            this.lblBuscar.TabIndex = 6;
            // 
            // btnBajaDocente
            // 
            this.btnBajaDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBajaDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnBajaDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaDocente.ForeColor = System.Drawing.Color.White;
            this.btnBajaDocente.Image = global::Presentacion.Properties.Resources.icons8_preschool_32;
            this.btnBajaDocente.Location = new System.Drawing.Point(49, 312);
            this.btnBajaDocente.Name = "btnBajaDocente";
            this.btnBajaDocente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBajaDocente.Size = new System.Drawing.Size(330, 130);
            this.btnBajaDocente.TabIndex = 10;
            this.btnBajaDocente.Text = " Baja de Docente";
            this.btnBajaDocente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBajaDocente.UseVisualStyleBackColor = false;
            this.btnBajaDocente.Click += new System.EventHandler(this.BotonesClick);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnModificarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocente.ForeColor = System.Drawing.Color.White;
            this.btnModificarDocente.Image = global::Presentacion.Properties.Resources.icons8_preschool_32;
            this.btnModificarDocente.Location = new System.Drawing.Point(445, 129);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificarDocente.Size = new System.Drawing.Size(330, 130);
            this.btnModificarDocente.TabIndex = 9;
            this.btnModificarDocente.Text = "Modificar Docente";
            this.btnModificarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarDocente.UseVisualStyleBackColor = false;
            this.btnModificarDocente.Click += new System.EventHandler(this.BotonesClick);
            // 
            // btnAltaDocente
            // 
            this.btnAltaDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnAltaDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaDocente.ForeColor = System.Drawing.Color.White;
            this.btnAltaDocente.Image = global::Presentacion.Properties.Resources.icons8_preschool_32;
            this.btnAltaDocente.Location = new System.Drawing.Point(49, 129);
            this.btnAltaDocente.Name = "btnAltaDocente";
            this.btnAltaDocente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAltaDocente.Size = new System.Drawing.Size(330, 130);
            this.btnAltaDocente.TabIndex = 8;
            this.btnAltaDocente.Text = " Nuevo Docente";
            this.btnAltaDocente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaDocente.UseVisualStyleBackColor = false;
            this.btnAltaDocente.Click += new System.EventHandler(this.BotonesClick);
            // 
            // DocentesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(824, 570);
            this.Controls.Add(this.btnBajaDocente);
            this.Controls.Add(this.btnModificarDocente);
            this.Controls.Add(this.btnAltaDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocentesFrm";
            this.Text = "DocentesFrm";
            this.Load += new System.EventHandler(this.DocentesFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBajaDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnAltaDocente;


    }
}