using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using Presentacion.Formularios;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class MatriculaFrm : Form
    {
        public MatriculaFrm()
        {
            InitializeComponent();
        }        

        private void MatriculaFrm_Load(object sender, EventArgs e)
        {
          
        }
             
        private void BotonesClick(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            PrincipalFrm.Instancia.AbrirFormulario(button.Name);
        }
    }
}
