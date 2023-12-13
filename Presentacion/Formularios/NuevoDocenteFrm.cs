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
    public partial class NuevoDocenteFrm : Form
    {
        public NuevoDocenteFrm()
        {
            InitializeComponent();
        }

        Metodos Metodo = new Metodos();

        DataTable Tabla = new DataTable();

        Validaciones validacion = new Validaciones();

        //diseño de consulta que trae docentes y sus telefonos
        string consulta = "SELECT Docente.DNI, Docente.Nombre, Docente.Apellido,Docente.Telefono, Docente.Email, Docente.Contraseña, Docente.EnActividad FROM Docente";

        char activo = '1';
        

        private void NuevoDocenteFrm_Load(object sender, EventArgs e)
        {
            //llama la tabla docente y tel, lo muestra en el DGV...
            try
            {
                dgv_docVista.DataSource = Metodo.Actualizar(Tabla, consulta);
            }
            catch
            {
                MessageBox.Show("error al llamar tabla en frm uptade docente");
            }
            
        }

        private void btn_docRegistra_Click(object sender, EventArgs e)
        {
            if ((validacion.VerificarSiObjetoEsVacio(gbDocentes, errorDoc)))
            {

                //arma la consulta de docente
                string AltaDocente = "INSERT INTO Docente (DNI, Nombre, Apellido,Telefono, Email, Contraseña, EnActividad) VALUES ('"
                + txt_DocDNI.Text + "','" + txt_docNom.Text + "','" + txt_docApell.Text + "','"
                + txt_docTel1.Text + "','" + txt_docEmail.Text + "','"
                + txt_DocContra.Text +"','" + activo + "')";
                //procede a verificar la consulta y la ejecuta
                validacion.PruebaAbm(AltaDocente);

                //actualiza la tabla de docentes
                dgv_docVista.DataSource = Metodo.Actualizar(Tabla, consulta);
            }

        }

        //Metodo que busca la Id de una tabla
        public int ValorCodigo(Control objeto)
        {
            int codigoDeTabla = 0;

            codigoDeTabla = Metodo.ConseguirCodigoDeTabla(objeto.Tag.ToString(), objeto.Text);

            return codigoDeTabla;
        }



        
    }
}
