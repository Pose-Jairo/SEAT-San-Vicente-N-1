using System;
using System.Data;
using System.Windows.Forms;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class ListaDocentesFrm : Form
    {
        public ListaDocentesFrm()
        {
            InitializeComponent();
        }

        string consultaDocentes = "SELECT DNI,Nombre,Apellido FROM Docente";

        Metodos metodo = new Metodos();

        DataTable Tabla = new DataTable();

        private void ListaDocentesFrm_Load(object sender, EventArgs e)
        {
            dgvListaDocentes.DataSource = metodo.Actualizar(Tabla, consultaDocentes);
            dgvListaDocentes.ClearSelection();
        }

    }
}
