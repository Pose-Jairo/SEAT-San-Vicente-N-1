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
    public partial class ModificarDocenteFrm : Form
    {
        public ModificarDocenteFrm()
        {
            InitializeComponent();
        }

        Metodos Metodo = new Metodos();

        char activo;

        DataTable TablaUPD = new DataTable();

        Validaciones validacion = new Validaciones();

        string consultaUPD = "SELECT Docente.DNI, Docente.Nombre, Docente.Apellido,Docente.Telefono, Docente.Email, Docente.Contraseña, Docente.EnActividad FROM Docente";

        private void ModificarDocenteFrm_Load(object sender, EventArgs e)
        {
            //llama la tabla docente y tel, lo muestra en el DGV...
            try
            {
                dgvDocenteVistaUPD.DataSource = Metodo.Actualizar(TablaUPD,consultaUPD);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void dgvDocenteVistaUPD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;


            if (indice !=-1)
            {
                try
                {
                    carga_tabla(indice);
                }
                catch
                {
                    MessageBox.Show("error al cargar los datos de la tabla");
                }
            }
        }

        private void carga_tabla(int val)
        {
            txt_DocDNIUPD.Text = Convert.ToString(dgvDocenteVistaUPD[0, val].Value);
            txt_docNomUPD.Text = Convert.ToString(dgvDocenteVistaUPD[1, val].Value);
            txt_docApellUPD.Text = Convert.ToString(dgvDocenteVistaUPD[2, val].Value);
            txt_docTel1UPD.Text = Convert.ToString(dgvDocenteVistaUPD[3, val].Value);
            txt_docEmailUPD.Text = Convert.ToString(dgvDocenteVistaUPD[4, val].Value);
            txt_DocContraUPD.Text = Convert.ToString(dgvDocenteVistaUPD[5, val].Value);
            cb_Activo.Checked = Convert.ToBoolean(dgvDocenteVistaUPD[6, val].Value);
        }

        private void btn_docUPDATE_Click(object sender, EventArgs e)
        {
            //arma la consulta de UPDATE
            if (cb_Activo.Checked) activo = '1';
            else activo = '0';

            string UpdateDocente = "UPDATE Docente SET DNI='" + txt_DocDNIUPD.Text
            + "',Nombre='" + txt_docNomUPD.Text
            + "',Apellido='" + txt_docApellUPD.Text
            + "',Telefono='" + txt_docTel1UPD.Text
            + "',Email='" + txt_docEmailUPD.Text
            + "',Contraseña='" + txt_DocContraUPD.Text
            + "',EnActividad='" + activo
            + "' WHERE Id_docente=" + Metodo.ValorCodigo(txt_DocDNIUPD) + ";";

            validacion.PruebaAbm(UpdateDocente);
            dgvDocenteVistaUPD.DataSource = Metodo.Actualizar(TablaUPD, consultaUPD);
        }

        private void gbDocentesUPD_Enter(object sender, EventArgs e)
        {

        }

        //Metodo que busca la Id de una tabla
   
    }
}
