using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class LoginFmr : Form
    {
        public static LoginFmr Instancia { get; private set; }

        Validaciones validacion = new Validaciones();

        public LoginFmr()
        {
            InitializeComponent();
            Instancia = this;
        }
      
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (validacion.ValidadDatosLogin(txtEmail.Text, txtPassword.Text))
            {
                PrincipalFrm principal = new PrincipalFrm();
                Instancia.Hide();
                principal.Show();
            }
        }
    
        private void CambiarColor(object sender, MouseEventArgs e)
        {
            var pictureBox = ((PictureBox)sender);
            pictureBox.BackColor = Color.FromArgb(128, 98, 214);
        }
      
        private void ColorNormal(object sender, EventArgs e)
        {
            var pictureBox = ((PictureBox)sender);
            pictureBox.BackColor = Color.FromArgb(50, 38, 83);
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
