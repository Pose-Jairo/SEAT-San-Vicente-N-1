using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class DocentesFrm : Form
    {
        public DocentesFrm()
        {
            InitializeComponent();
        }

        Metodos metodos = new Metodos();
        DataTable Tabla = new DataTable();

        //string consultaDocente = "SELECT DNI,Nombre,Apellido FROM Docente";

        private void DocentesFrm_Load(object sender, EventArgs e)
        {
            //dgvCargaDocentes.DataSource = metodos.Actualizar(Tabla, consultaDocente);
           // dgvCargaDocentes.ClearSelection();
           // dgvListaDocentes.DataSource = metodos.Actualizar(Tabla, consultaDocente);
           // dgvListaDocentes.ClearSelection();
        }

        private void BotonesClick(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            PrincipalFrm.Instancia.AbrirFormulario(button.Name);
        }
    }
}
