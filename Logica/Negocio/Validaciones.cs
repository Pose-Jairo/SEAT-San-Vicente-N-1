using System;
using Datos.Conexion;
using System.Windows.Forms;
using System.Reflection;

namespace Logica.Negocio
{
    public class Validaciones
    {
        ConexionConBD BDConexion = new ConexionConBD();
        Metodos metodos = new Metodos();

        public void PruebaAlta(string consulta)
        {
            bool Alta = false;

            Alta = BDConexion.EjecutarConsulta(consulta);

            if (Alta == true)
            {
                MessageBox.Show("Alta Creada");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

       public bool VerificarSiObjetoEsVacio(GroupBox groupBox, ErrorProvider error)
        {
            bool algunObjetoVacio = true;

            foreach (Control control in groupBox.Controls)
            {
                string textoDecorativo = control.Tag.ToString();

                if (control is TextBox)
                {                    
                    if (string.IsNullOrWhiteSpace(control.Text) || (control.Text == textoDecorativo))
                    {
                        algunObjetoVacio = false;
                        error.SetError(control, "Campo Obligatorio");                                           
                    }
                }
                else if (control is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text) || (control.Text == textoDecorativo))
                    {
                        algunObjetoVacio = false;
                        error.SetError(control, "Campo Obligatorio");              
                    }

                }             
            }

            return algunObjetoVacio;
        }
    }
}
