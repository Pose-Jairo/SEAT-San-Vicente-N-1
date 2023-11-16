namespace Presentacion.Formularios
{
    partial class ListaResponsablesFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.dgvResponsables = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.textBox17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 107);
            this.panel2.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(21, 30);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Buscador";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(23, 46);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(179, 20);
            this.textBox17.TabIndex = 3;
            // 
            // dgvResponsables
            // 
            this.dgvResponsables.AllowUserToAddRows = false;
            this.dgvResponsables.AllowUserToDeleteRows = false;
            this.dgvResponsables.AllowUserToResizeColumns = false;
            this.dgvResponsables.AllowUserToResizeRows = false;
            this.dgvResponsables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResponsables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.dgvResponsables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResponsables.Location = new System.Drawing.Point(0, 0);
            this.dgvResponsables.Name = "dgvResponsables";
            this.dgvResponsables.ReadOnly = true;
            this.dgvResponsables.RowHeadersVisible = false;
            this.dgvResponsables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResponsables.Size = new System.Drawing.Size(824, 570);
            this.dgvResponsables.TabIndex = 8;
            // 
            // ListaResponsablesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(824, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvResponsables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaResponsablesFrm";
            this.Text = "ListaResponsables";
            this.Load += new System.EventHandler(this.ListaResponsablesFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.DataGridView dgvResponsables;
    }
}