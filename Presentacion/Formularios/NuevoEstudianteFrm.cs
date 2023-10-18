using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class NuevoEstudianteFrm : Form
    {
        public NuevoEstudianteFrm()
        {
            InitializeComponent();
        }

        Validaciones validacion = new Validaciones();

        Metodos metodo = new Metodos();

        private void NuevoEstudianteFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validacion.VerificarSiObjetoEsVacio(this,error))
            {
                string fechaNacimiento = txtDiaNacimiento.Text.Trim() + "/" + txtMesNacimiento.Text.Trim() + "/" + txtAñoNacimiento.Text.Trim();

                string fechaIngreso = txtDiaIngreso.Text.Trim() + "/" + txtMesIngreso.Text.Trim() + "/" + txtAñoIngreso.Text.Trim();

                int localidad = metodo.ConseguirLocalidad(cmbLocalidadEstudiante.Text.Trim());

                string consultaAlta = "INSERT INTO Estudiante(CUIL,Nombre,Apellido,Direccion,entreCalles,fechaIngreso,fechaNac,genero"
                + ",turno,Id_caract,Id_categ,Cod_post,Cod_nacion,Id_resp)VALUES('" + txtCuil.Text.Trim() + "','" + txtNombresEstudiante.Text.Trim() + "','" +
                txtApellidosEstudiante.Text.Trim() + "','" + txtDireccionEstudiante.Text.Trim() + "','" + txtEntreCallesEstudiante.Text.Trim() + "')";

                validacion.PruebaAlta(consultaAlta);
            }
        }

        
    }
}
