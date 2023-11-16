using System;
using System.Windows.Forms;
using System.Data;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class ListaEstudiantesFrm : Form
    {
        public ListaEstudiantesFrm()
        {
            InitializeComponent();
        }
        Metodos metodo = new Metodos();

        DataTable Tabla = new DataTable();

        private string consultaEstudiantes = "SELECT Cuil,Nombre,Apellido,Direccion,entreCalles FROM Estudiante";

        private void ListaEstudiantesFrm_Load(object sender, EventArgs e)
        {
            dgvListaEstudiantes.DataSource = metodo.Actualizar(Tabla, consultaEstudiantes);
            dgvListaEstudiantes.ClearSelection();
        }
    }
}
