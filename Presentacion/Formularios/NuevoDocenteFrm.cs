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
        //diseño de consulta que trae docentes y sus telefonos
        string consulta = "SELECT Docente.DNI, Docente.Nombre, Docente.Apellido, Docente.Email, Docente.Contraseña, Tel_doc.Telefono FROM Docente INNER JOIN Tel_doc ON Tel_doc.Id_docente = Docente.Id_docente";

        private void NuevoDocenteFrm_Load(object sender, EventArgs e)
        {
            //llama la tabla docente y tel, lo muestra en el DGV...
            try
            {
                dgv_docVista.DataSource = Metodo.Actualizar(Tabla, consulta);
            }
            catch
            {
                MessageBox.Show("error");
            }
            
        }

        private void btn_docRegistra_Click(object sender, EventArgs e)
        {
            //llama al metodo que ejecuta un insert
            consulta = "INSERT INTO Docente (DNI, Nombre,Apellido,Direccion,Telefono,Telefono2) VALUES ('"
                + txt_DocDNI.Text + "','" + txt_docNom.Text + "','" + txt_apell.Text + "','" + txt_direccion.Text + "','"
                    + txt_tel.Text + "','" + txt_tel2.Text + "')";
        }
        
    }
}
