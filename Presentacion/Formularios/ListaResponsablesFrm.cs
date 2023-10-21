using System;
using System.Data;
using System.Windows.Forms;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class ListaResponsablesFrm : Form
    {
        public ListaResponsablesFrm()
        {
            InitializeComponent();
        }

        private string consultaResponsables = "SELECT Nombre,Apellido,Direccion,Ocupacion From Responsable";

        Metodos metodo = new Metodos();

        DataTable Tabla = new DataTable();

        private void ListaResponsablesFrm_Load(object sender, EventArgs e)
        {
            dgvResponsables.DataSource = metodo.Actualizar(Tabla, consultaResponsables);
            dgvResponsables.ClearSelection();
        }
    }
}
