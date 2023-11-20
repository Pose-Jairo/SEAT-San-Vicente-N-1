namespace Presentacion.Formularios
{
    partial class BajaDocenteFrm
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
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBajaDocente = new System.Windows.Forms.Button();
            this.txtDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AllowUserToResizeColumns = false;
            this.dgvDocentes.AllowUserToResizeRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDocentes.Location = new System.Drawing.Point(0, 0);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersVisible = false;
            this.dgvDocentes.Size = new System.Drawing.Size(824, 333);
            this.dgvDocentes.TabIndex = 7;
            this.dgvDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(498, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 44);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Tag = "cancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnBajaDocente
            // 
            this.btnBajaDocente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBajaDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBajaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaDocente.ForeColor = System.Drawing.Color.White;
            this.btnBajaDocente.Location = new System.Drawing.Point(639, 470);
            this.btnBajaDocente.Name = "btnBajaDocente";
            this.btnBajaDocente.Size = new System.Drawing.Size(155, 64);
            this.btnBajaDocente.TabIndex = 22;
            this.btnBajaDocente.Tag = "registrar";
            this.btnBajaDocente.Text = "Borrar \r\nDocente";
            this.btnBajaDocente.UseVisualStyleBackColor = false;
            this.btnBajaDocente.Click += new System.EventHandler(this.btnBajaDocente_Click);
            // 
            // txtDocente
            // 
            this.txtDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocente.Location = new System.Drawing.Point(826, 351);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(114, 13);
            this.txtDocente.TabIndex = 24;
            this.txtDocente.Tag = "DNI";
            this.txtDocente.Visible = false;
            // 
            // BajaDocenteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(824, 570);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBajaDocente);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.txtDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaDocenteFrm";
            this.Text = "BajaDocenteFrm";
            this.Load += new System.EventHandler(this.BajaDocenteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBajaDocente;
        private System.Windows.Forms.TextBox txtDocente;
    }
}