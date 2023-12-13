namespace Presentacion.Formularios
{
    partial class NuevoDocenteFrm
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
            this.components = new System.ComponentModel.Container();
            this.dgvCargaDocentes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_docTel1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDocentes = new System.Windows.Forms.GroupBox();
            this.txt_docApell = new System.Windows.Forms.TextBox();
            this.txt_docNom = new System.Windows.Forms.TextBox();
            this.txt_DocContra = new System.Windows.Forms.TextBox();
            this.txt_docEmail = new System.Windows.Forms.TextBox();
            this.txt_DocDNI = new System.Windows.Forms.TextBox();
            this.btn_docCancel = new System.Windows.Forms.Button();
            this.btn_docRegistra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_docVista = new System.Windows.Forms.DataGridView();
            this.errorDoc = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaDocentes)).BeginInit();
            this.gbDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCargaDocentes
            // 
            this.dgvCargaDocentes.AllowUserToAddRows = false;
            this.dgvCargaDocentes.AllowUserToDeleteRows = false;
            this.dgvCargaDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargaDocentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.dgvCargaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargaDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCargaDocentes.Location = new System.Drawing.Point(0, 0);
            this.dgvCargaDocentes.Name = "dgvCargaDocentes";
            this.dgvCargaDocentes.ReadOnly = true;
            this.dgvCargaDocentes.RowHeadersVisible = false;
            this.dgvCargaDocentes.Size = new System.Drawing.Size(824, 294);
            this.dgvCargaDocentes.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(308, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 19;
            this.label6.Tag = "Telefono 1";
            this.label6.Text = "Telefono:";
            // 
            // txt_docTel1
            // 
            this.txt_docTel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txt_docTel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_docTel1.Location = new System.Drawing.Point(311, 48);
            this.txt_docTel1.Name = "txt_docTel1";
            this.txt_docTel1.Size = new System.Drawing.Size(120, 13);
            this.txt_docTel1.TabIndex = 0;
            this.txt_docTel1.Tag = "telefono 1";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(449, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 17;
            this.label5.Tag = "DNI";
            this.label5.Text = "DNI:";
            // 
            // gbDocentes
            // 
            this.gbDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.gbDocentes.Controls.Add(this.txt_docTel1);
            this.gbDocentes.Controls.Add(this.txt_docApell);
            this.gbDocentes.Controls.Add(this.txt_docNom);
            this.gbDocentes.Controls.Add(this.txt_DocContra);
            this.gbDocentes.Controls.Add(this.txt_docEmail);
            this.gbDocentes.Controls.Add(this.txt_DocDNI);
            this.gbDocentes.Controls.Add(this.btn_docCancel);
            this.gbDocentes.Controls.Add(this.btn_docRegistra);
            this.gbDocentes.Controls.Add(this.label6);
            this.gbDocentes.Controls.Add(this.label5);
            this.gbDocentes.Controls.Add(this.label4);
            this.gbDocentes.Controls.Add(this.label3);
            this.gbDocentes.Controls.Add(this.label1);
            this.gbDocentes.Controls.Add(this.label2);
            this.gbDocentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDocentes.ForeColor = System.Drawing.Color.White;
            this.gbDocentes.Location = new System.Drawing.Point(0, 294);
            this.gbDocentes.Name = "gbDocentes";
            this.gbDocentes.Size = new System.Drawing.Size(824, 276);
            this.gbDocentes.TabIndex = 4;
            this.gbDocentes.TabStop = false;
            this.gbDocentes.Text = "Datos del Docente";
            // 
            // txt_docApell
            // 
            this.txt_docApell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txt_docApell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_docApell.Location = new System.Drawing.Point(160, 48);
            this.txt_docApell.Name = "txt_docApell";
            this.txt_docApell.Size = new System.Drawing.Size(120, 13);
            this.txt_docApell.TabIndex = 0;
            this.txt_docApell.Tag = "apellido";
            // 
            // txt_docNom
            // 
            this.txt_docNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txt_docNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_docNom.Location = new System.Drawing.Point(19, 48);
            this.txt_docNom.Name = "txt_docNom";
            this.txt_docNom.Size = new System.Drawing.Size(120, 13);
            this.txt_docNom.TabIndex = 0;
            this.txt_docNom.Tag = "nombre";
            // 
            // txt_DocContra
            // 
            this.txt_DocContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txt_DocContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DocContra.Location = new System.Drawing.Point(311, 104);
            this.txt_DocContra.Name = "txt_DocContra";
            this.txt_DocContra.Size = new System.Drawing.Size(261, 13);
            this.txt_DocContra.TabIndex = 0;
            this.txt_DocContra.Tag = "contraseña";
            // 
            // txt_docEmail
            // 
            this.txt_docEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txt_docEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_docEmail.Location = new System.Drawing.Point(19, 104);
            this.txt_docEmail.Name = "txt_docEmail";
            this.txt_docEmail.Size = new System.Drawing.Size(261, 13);
            this.txt_docEmail.TabIndex = 0;
            this.txt_docEmail.Tag = "e mail";
            // 
            // txt_DocDNI
            // 
            this.txt_DocDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txt_DocDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DocDNI.Location = new System.Drawing.Point(452, 48);
            this.txt_DocDNI.Name = "txt_DocDNI";
            this.txt_DocDNI.Size = new System.Drawing.Size(120, 13);
            this.txt_DocDNI.TabIndex = 0;
            this.txt_DocDNI.Tag = "txt_DocDNI";
            // 
            // btn_docCancel
            // 
            this.btn_docCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_docCancel.Location = new System.Drawing.Point(513, 210);
            this.btn_docCancel.Name = "btn_docCancel";
            this.btn_docCancel.Size = new System.Drawing.Size(114, 44);
            this.btn_docCancel.TabIndex = 21;
            this.btn_docCancel.Tag = "cancelar";
            this.btn_docCancel.Text = "Cancelar";
            this.btn_docCancel.UseVisualStyleBackColor = false;
            // 
            // btn_docRegistra
            // 
            this.btn_docRegistra.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_docRegistra.ForeColor = System.Drawing.Color.White;
            this.btn_docRegistra.Location = new System.Drawing.Point(657, 200);
            this.btn_docRegistra.Name = "btn_docRegistra";
            this.btn_docRegistra.Size = new System.Drawing.Size(155, 64);
            this.btn_docRegistra.TabIndex = 20;
            this.btn_docRegistra.Tag = "registrar";
            this.btn_docRegistra.Text = "Registrar\r\nDocente";
            this.btn_docRegistra.UseVisualStyleBackColor = false;
            this.btn_docRegistra.Click += new System.EventHandler(this.btn_docRegistra_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(308, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 15;
            this.label4.Tag = "contraseña";
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 13;
            this.label3.Tag = "Email";
            this.label3.Text = "Email:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 11;
            this.label1.Tag = "Apellidos";
            this.label1.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Tag = "Nombre";
            this.label2.Text = "Nombres:";
            // 
            // dgv_docVista
            // 
            this.dgv_docVista.AllowUserToAddRows = false;
            this.dgv_docVista.AllowUserToDeleteRows = false;
            this.dgv_docVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_docVista.Location = new System.Drawing.Point(0, 0);
            this.dgv_docVista.Name = "dgv_docVista";
            this.dgv_docVista.ReadOnly = true;
            this.dgv_docVista.RowHeadersVisible = false;
            this.dgv_docVista.Size = new System.Drawing.Size(824, 294);
            this.dgv_docVista.TabIndex = 5;
            // 
            // errorDoc
            // 
            this.errorDoc.ContainerControl = this;
            // 
            // NuevoDocenteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(824, 570);
            this.Controls.Add(this.dgv_docVista);
            this.Controls.Add(this.dgvCargaDocentes);
            this.Controls.Add(this.gbDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoDocenteFrm";
            this.Text = "NuevoDocenteFrm";
            this.Load += new System.EventHandler(this.NuevoDocenteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaDocentes)).EndInit();
            this.gbDocentes.ResumeLayout(false);
            this.gbDocentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCargaDocentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_docTel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDocentes;
        private System.Windows.Forms.TextBox txt_DocDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DocContra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_docEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_docApell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_docNom;
        private System.Windows.Forms.Button btn_docCancel;
        private System.Windows.Forms.Button btn_docRegistra;
        private System.Windows.Forms.DataGridView dgv_docVista;
        private System.Windows.Forms.ErrorProvider errorDoc;
    }
}