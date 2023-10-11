namespace Presentacion.Formularios
{
    partial class MatriculaFrm
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
            this.btnBajaEstudiante = new System.Windows.Forms.Button();
            this.btnModificarEstudiante = new System.Windows.Forms.Button();
            this.btnAltaEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBajaEstudiante
            // 
            this.btnBajaEstudiante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBajaEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnBajaEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnBajaEstudiante.Image = global::Presentacion.Properties.Resources.icons8_preschool_32;
            this.btnBajaEstudiante.Location = new System.Drawing.Point(56, 302);
            this.btnBajaEstudiante.Name = "btnBajaEstudiante";
            this.btnBajaEstudiante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBajaEstudiante.Size = new System.Drawing.Size(330, 130);
            this.btnBajaEstudiante.TabIndex = 7;
            this.btnBajaEstudiante.Text = " Baja de Estudiante";
            this.btnBajaEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBajaEstudiante.UseVisualStyleBackColor = false;
            this.btnBajaEstudiante.Click += new System.EventHandler(this.BotonesClick);
            // 
            // btnModificarEstudiante
            // 
            this.btnModificarEstudiante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnModificarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnModificarEstudiante.Image = global::Presentacion.Properties.Resources.icons8_preschool_32;
            this.btnModificarEstudiante.Location = new System.Drawing.Point(452, 119);
            this.btnModificarEstudiante.Name = "btnModificarEstudiante";
            this.btnModificarEstudiante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificarEstudiante.Size = new System.Drawing.Size(330, 130);
            this.btnModificarEstudiante.TabIndex = 6;
            this.btnModificarEstudiante.Text = "Modificar Estudiante";
            this.btnModificarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarEstudiante.UseVisualStyleBackColor = false;
            this.btnModificarEstudiante.Click += new System.EventHandler(this.BotonesClick);
            // 
            // btnAltaEstudiante
            // 
            this.btnAltaEstudiante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnAltaEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnAltaEstudiante.Image = global::Presentacion.Properties.Resources.icons8_preschool_32;
            this.btnAltaEstudiante.Location = new System.Drawing.Point(56, 119);
            this.btnAltaEstudiante.Name = "btnAltaEstudiante";
            this.btnAltaEstudiante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAltaEstudiante.Size = new System.Drawing.Size(330, 130);
            this.btnAltaEstudiante.TabIndex = 5;
            this.btnAltaEstudiante.Text = " Nuevo Estudiante";
            this.btnAltaEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaEstudiante.UseVisualStyleBackColor = false;
            this.btnAltaEstudiante.Click += new System.EventHandler(this.BotonesClick);
            // 
            // MatriculaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(824, 570);
            this.Controls.Add(this.btnBajaEstudiante);
            this.Controls.Add(this.btnModificarEstudiante);
            this.Controls.Add(this.btnAltaEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatriculaFrm";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.MatriculaFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEstudiante;
        private System.Windows.Forms.Button btnModificarEstudiante;
        private System.Windows.Forms.Button btnBajaEstudiante;

    }
}