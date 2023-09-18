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
    public partial class MatriculaFrm : Form
    {
        public MatriculaFrm()
        {
            InitializeComponent();
        }

        Metodos metodos = new Metodos();
        DataTable Tabla = new DataTable();

        string consulta = "SELECT * FROM Estudiante";

        private void MatriculaFrm_Load(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = metodos.Actualizar(Tabla, consulta);
            dgvEstudiantes.ClearSelection();
        }
    }
}
