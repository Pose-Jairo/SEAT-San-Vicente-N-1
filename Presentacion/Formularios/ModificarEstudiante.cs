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
    public partial class ModificarEstudiante : Form
    {
        public ModificarEstudiante()
        {
            InitializeComponent();
        }

        private string consultaEstudiantes = "SELECT Cuil,Nombre,Apellido,Direccion,entreCalles FROM Estudiante";


        //Genero,Descripcion.Categoria,Especificacion.Caracterizacion,//

            /*"+
        "fechaIngreso,fechaNac,Nomlocal.Localidad,Nomnacion.Nacionalidad,turno From Estudiante inner join Categoria on Id_categ = Id_categ inner join" + 
        " Caracterizacion on Id_carac = Id_carac inner join Localidad on Cod_post = Cod_post inner join Nacionalidad on Cod_nacion = Cod_nacion";
            */
        Metodos metodo = new Metodos();

        DataTable Tabla = new DataTable();

        private void ModificarEstudiante_Load(object sender, EventArgs e)
        {
            dgvModificarAlumno.DataSource = metodo.Actualizar(Tabla, consultaEstudiantes);
            dgvModificarAlumno.ClearSelection();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }


    }
}
