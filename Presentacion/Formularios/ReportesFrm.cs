using System;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class ReportesFrm : Form
    {
        public ReportesFrm()
        {
            InitializeComponent();
        }

        private void BotonesClick(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            PrincipalFrm.Instancia.AbrirFormulario(button.Name);
        }
    }
}
