using System;
using System.Data;
using System.Collections.Generic;
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

        private string consultaEstudiantes = "SELECT Cuil,Nombre,Apellido,Direccion,entreCalles,fechaIngreso,fechaNac From Estudiante";
        private string consultaResponsables = "SELECT Nombre,Apellido,Direccion,Ocupacion From Responsable";

        private void MatriculaFrm_Load(object sender, EventArgs e)
        {
           // dgvMatricula.DataSource = metodos.Actualizar(Tabla, consultaEstudiantes);
           // dgvResponsables.DataSource = metodos.Actualizar(Tabla, consultaResponsables);
           // dgvMatricula.ClearSelection();
           // dgvResponsables.ClearSelection();
        }
      
        private void btnCargaEstudiante_Click(object sender, EventArgs e)
        {
            if (metodos.Alta == true)
            {
               // dgvMatricula.DataSource = metodos.Actualizar(Tabla, consultaEstudiantes);
            }
            else
            {
                DialogResult error = MessageBox.Show("Error en el procedimiento...", "Error!!!"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Object> ListadeObjetos()
        {
            List<Object> listaObjetos = new List<object> 
            {
                
            };
            return listaObjetos;
        }
    }
}
