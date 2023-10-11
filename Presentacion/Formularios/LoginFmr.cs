using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class LoginFmr : Form
    {
        public static LoginFmr Instancia { get; private set; }

        public LoginFmr()
        {
            InitializeComponent();
            Instancia = this;
        }
      
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "1234" & txtPassword.Text == "1234")
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
