using Presentacion.Formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }
        
        private void PrincipalFrm_Load(object sender, EventArgs e)
        {
            SeleccionButtons(btnMenu, null);
        }

        private Form FormActivo = null;
      
        private Button BotonAnterior { get; set; }

        private void SeleccionButtons(object sender, EventArgs e)
        {
            if (BotonAnterior != null)
                BotonAnterior.BackColor = Color.FromArgb(128, 98, 214);

            var button = ((Button)sender);
            button.BackColor = Color.FromArgb(90, 69, 150);
            BotonAnterior = button;
            AbrirFormulario(button.Name);
        }

        private void AbrirFormulario(string name)
        {
            switch (name)
            {
                case "btnMenu":
                    OpenFormHijo(new MenuFrm());
                    break;
                case "btnMatricula":
                    OpenFormHijo(new MatriculaFrm());
                    break;
                case "btnDocentes":
                     OpenFormHijo(new DocentesFrm());
                    break;
            }
        }

        private void OpenFormHijo(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            FormActivo = formHijo;
            FormActivo.TopLevel = false;
            FormActivo.FormBorderStyle = FormBorderStyle.None;
            FormActivo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(FormActivo);
            panelContenedor.Tag = formHijo;
            FormActivo.BringToFront();
            FormActivo.Show();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbTamañoNormal.Visible = true;
        }

        private void pbTamañoNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbTamañoNormal.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CambiarColor(object sender, MouseEventArgs e)
        {
            var pintureBox = ((PictureBox)sender);
            pintureBox.BackColor = Color.FromArgb(128, 98, 214);
        }

        private void ColorNormal(object sender, EventArgs e)
        {
            var pintureBox = ((PictureBox)sender);
            pintureBox.BackColor = Color.FromArgb(50, 38, 83);
        }
    }
}
