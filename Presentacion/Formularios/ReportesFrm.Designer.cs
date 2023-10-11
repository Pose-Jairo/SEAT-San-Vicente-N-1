namespace Presentacion.Formularios
{
    partial class ReportesFrm
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
            this.btnListaResponsables = new System.Windows.Forms.Button();
            this.btnListaDocentes = new System.Windows.Forms.Button();
            this.btnListaAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaResponsables
            // 
            this.btnListaResponsables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaResponsables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnListaResponsables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaResponsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaResponsables.ForeColor = System.Drawing.Color.White;
            this.btnListaResponsables.Image = global::Presentacion.Properties.Resources.icons8_book_32;
            this.btnListaResponsables.Location = new System.Drawing.Point(70, 229);
            this.btnListaResponsables.Name = "btnListaResponsables";
            this.btnListaResponsables.Size = new System.Drawing.Size(688, 80);
            this.btnListaResponsables.TabIndex = 11;
            this.btnListaResponsables.Text = " Lista de Responsables";
            this.btnListaResponsables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaResponsables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaResponsables.UseVisualStyleBackColor = false;
            // 
            // btnListaDocentes
            // 
            this.btnListaDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnListaDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaDocentes.ForeColor = System.Drawing.Color.White;
            this.btnListaDocentes.Image = global::Presentacion.Properties.Resources.icons8_people_32;
            this.btnListaDocentes.Location = new System.Drawing.Point(428, 109);
            this.btnListaDocentes.Name = "btnListaDocentes";
            this.btnListaDocentes.Size = new System.Drawing.Size(330, 80);
            this.btnListaDocentes.TabIndex = 10;
            this.btnListaDocentes.Text = " Lista de Docentes";
            this.btnListaDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaDocentes.UseVisualStyleBackColor = false;
            // 
            // btnListaAlumnos
            // 
            this.btnListaAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.btnListaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnListaAlumnos.Image = global::Presentacion.Properties.Resources.icons8_book_32;
            this.btnListaAlumnos.Location = new System.Drawing.Point(70, 109);
            this.btnListaAlumnos.Name = "btnListaAlumnos";
            this.btnListaAlumnos.Size = new System.Drawing.Size(330, 80);
            this.btnListaAlumnos.TabIndex = 9;
            this.btnListaAlumnos.Text = " Lista de Alumnos";
            this.btnListaAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaAlumnos.UseVisualStyleBackColor = false;
            // 
            // ReportesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(824, 570);
            this.Controls.Add(this.btnListaResponsables);
            this.Controls.Add(this.btnListaDocentes);
            this.Controls.Add(this.btnListaAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesFrm";
            this.Text = "ReportesFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaResponsables;
        private System.Windows.Forms.Button btnListaDocentes;
        private System.Windows.Forms.Button btnListaAlumnos;
    }
}