using System;
using System.Data;
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

        private void btnCargaEstudiante_Click(object sender, EventArgs e)
        {
            if (metodos.Alta == true)
            {
                dgvEstudiantes.DataSource = metodos.Actualizar(Tabla, consulta);
            }
            else
            {
                DialogResult error = MessageBox.Show("Error en el procedimiento...", "Error!!!"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
