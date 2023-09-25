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
        public LoginFmr()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "1234" & txtPassword.Text == "1234")
            {
                PrincipalFrm principal = new PrincipalFrm();
                this.Hide();
                principal.Show();
            }
        }
    }
}
