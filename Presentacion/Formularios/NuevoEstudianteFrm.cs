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
                "','" + txtOcupacion.Text.Trim() + "','" + cmbParentesco.Text + "'," + ValorCodigo(cmbLocalidadResponsable) + "," + ValorCodigo(cmbNacionalidadResponsable) + ")";

                validacion.PruebaAlta(consultaAltaResponsable);

                string consultaAltaTelefonos = "INSERT INTO Tel_resp(Telefono,Id_resp)VALUES(" + txtTelefono1.Text + "," + ValorCodigo(txtDNI) + ")";

                validacion.PruebaAlta(consultaAltaTelefonos);

                string consultaAltaEstudiante = "INSERT INTO Estudiante(CUIL,Nombre,Apellido,Direccion,entreCalles,fechaIngreso,fechaNac,genero"
                + ",turno,Id_caract,Id_categ,Cod_post,Cod_nacion,Id_resp)VALUES('" + txtCuil.Text.Trim() + "','" + txtNombresEstudiante.Text.Trim() + "','" +
                txtApellidosEstudiante.Text.Trim() + "','" + txtDireccionEstudiante.Text.Trim() + "','" + txtEntreCallesEstudiante.Text.Trim() + "','" + dtpFechaIngreso.Text +
                "','" + dtpFechaNacimiento.Text + "','" + cmbGenero.Text + "','" + cmbTurno.Text + "'," + ValorCodigo(cmbCaracterizacion) + "," + ValorCodigo(cmbCategoria) + ","+
                ValorCodigo(cmbLocalidadEstudiante) + ","+ ValorCodigo(cmbNacionalidadEstudiante) + "," + ValorCodigo(txtDNI) + ")";

                validacion.PruebaAlta(consultaAltaEstudiante);
            }
            
        }


        public int ValorCodigo(Control objeto)
        {
            int codigoDeTabla = 0;

            codigoDeTabla = metodo.ConseguirCodigoDeTabla(objeto.Tag.ToString(), objeto.Text);

            return codigoDeTabla;
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
