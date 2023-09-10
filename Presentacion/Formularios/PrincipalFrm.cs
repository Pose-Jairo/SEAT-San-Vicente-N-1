using Presentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diseño.Formularios
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

        private void OpenFormHijo(Form formHijo)
        {
            FormActivo?.Close();
            FormActivo = formHijo;
            FormActivo.TopLevel = false;
            FormActivo.FormBorderStyle = FormBorderStyle.None;
            FormActivo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(FormActivo);
            panelContenedor.Tag = formHijo;
            FormActivo.BringToFront();
            FormActivo.Show();
        }

        private Button BotonAnterior { get; set; }

        private void SeleccionButtons(object sender, EventArgs e)
        {
            if (BotonAnterior != null)
                BotonAnterior.BackColor = Color.FromArgb(23, 42, 51);

            var button = ((Button)sender);
            button.BackColor = Color.FromArgb(94, 145, 169);
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
            }
        }
    }
}
