using System;
using System.Windows.Forms;
using System.Drawing;
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
            if((validacion.VerificarSiObjetoEsVacio(gbDatosResponsable,error)) && (validacion.VerificarSiObjetoEsVacio(gbDatosEstudiante,error)))
            {
                string consultaAltaResponsable = "INSERT INTO Responsable(DNI,Nombre,Apellido,Direccion,Ocupacion,Parentesco,Cod_post,Cod_nacion)VALUES(" +
                txtDNI.Text.Trim() + ",'" + txtNombresResponsable.Text.Trim() + "','" + txtApellidosResponsable.Text.Trim() + "','" + txtDireccionResponsable.Text.Trim() +
                "','" + txtOcupacion.Text.Trim() + "','" + cmbParentesco.Text + "'," + metodo.ValorCodigo(cmbLocalidadResponsable) + "," + metodo.ValorCodigo(cmbNacionalidadResponsable) + ")";

                validacion.PruebaAlta(consultaAltaResponsable);

                string consultaAltaTelefonos = "INSERT INTO Tel_resp(Telefono,Id_resp)VALUES(" + txtTelefono1.Text + "," + metodo.ValorCodigo(txtDNI) + ")";

                validacion.PruebaAlta(consultaAltaTelefonos);

                string consultaAltaEstudiante = "INSERT INTO Estudiante(CUIL,Nombre,Apellido,Direccion,entreCalles,fechaIngreso,fechaNac,genero"
                + ",turno,Id_caract,Id_categ,Cod_post,Cod_nacion,Id_resp)VALUES('" + txtCuil.Text.Trim() + "','" + txtNombresEstudiante.Text.Trim() + "','" +
                txtApellidosEstudiante.Text.Trim() + "','" + txtDireccionEstudiante.Text.Trim() + "','" + txtEntreCallesEstudiante.Text.Trim() + "','" + dtpFechaIngreso.Text +
                "','" + dtpFechaNacimiento.Text + "','" + cmbGenero.Text + "','" + cmbTurno.Text + "'," + metodo.ValorCodigo(cmbCaracterizacion) + "," + metodo.ValorCodigo(cmbCategoria) + "," +
                metodo.ValorCodigo(cmbLocalidadEstudiante) + "," + metodo.ValorCodigo(cmbNacionalidadEstudiante) + "," + metodo.ValorCodigo(txtDNI) + ")";

                validacion.PruebaAlta(consultaAltaEstudiante);

                string consultaModificarEstudiante = "UPDATE Estudiante SET CUIL='" + txtCuil.Text + "',Nombre='" + txtNombresEstudiante.Text + "',Apellido='" + txtApellidosEstudiante.Text + 
                "',Direccion='" + txtDireccionEstudiante.Text + "',entreCalles='" + txtEntreCallesEstudiante.Text + "',fechaIngreso='" + dtpFechaIngreso.Text + "',fechaNac='" + dtpFechaNacimiento.Text +
                "',genero='" + cmbGenero.Text + "',turno='" + cmbTurno  .Text + "',Id_caract=" + metodo.ValorCodigo(cmbCaracterizacion) + ",Id_categ=" + metodo.ValorCodigo(cmbCategoria) + 
                ",Cod_post=" + metodo.ValorCodigo(cmbLocalidadEstudiante) + ",Cod_nacion=" + metodo.ValorCodigo(cmbNacionalidadEstudiante) + ",Id_resp=" + metodo.ValorCodigo(txtDNI) +
                " WHERE Id_estudiante=" + metodo.ValorCodigo(txtCuil);
            }
            
        }

        private void VaciarTexto(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == textbox.Tag.ToString())
            {
                textbox.Text = "";
                textbox.ForeColor = Color.White;
            }
        }

        private void RellenarTexto(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.Text = textbox.Tag.ToString();
                textbox.ForeColor = Color.LightGray;
            }
        }


        
    }
}
