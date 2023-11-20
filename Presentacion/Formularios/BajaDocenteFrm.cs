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
    public partial class BajaDocenteFrm : Form
    {
        public BajaDocenteFrm()
        {
            InitializeComponent();
        }


        Metodos Metodo = new Metodos();

        DataTable Tabla = new DataTable();

        Validaciones validacion = new Validaciones();

        string consulta = "SELECT Docente.DNI, Docente.Nombre, Docente.Apellido, Docente.Email, Docente.Contraseña, Tel_doc.Telefono FROM Docente INNER JOIN Tel_doc ON Tel_doc.Id_docente = Docente.Id_docente";

        int indice = -1;

        private void BajaDocenteFrm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDocentes.DataSource = Metodo.Actualizar(Tabla, consulta);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void dgvDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnBajaDocente_Click(object sender, EventArgs e)
        {
            if (indice == -1)
            {
                DialogResult error = MessageBox.Show("Debe seleccionar un campo a eliminar!!!", "Error!!!"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtDocente.Text = Convert.ToString(dgvDocentes[0, indice].Value);

                DialogResult pregunta = MessageBox.Show("Esta seguro de eliminar el campo?", "Eliminar",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (pregunta == DialogResult.OK)
                {
                    validacion.PruebaAbm("DELETE * FROM Docente WHERE Id_docente='" + Metodo.ValorCodigo(txtDocente) + "';");
                    
                    dgvDocentes.DataSource = Metodo.Actualizar(Tabla, consulta);                                                               
                }
            }
        }

    }
}
