using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
              
            }
            else
            {

            }
        }

       public bool VerificarSiObjetoEsVacio(Form formulario, ErrorProvider error)
        {
            bool algunObjetoVacio = false;

            foreach (Control control in formulario.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        algunObjetoVacio = true;
                        error.SetError(control, "Campo Obligatorio");                                           
                    }
                }
                else if (control is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        algunObjetoVacio = true;
                        error.SetError(control, "Campo Obligatorio");              
                    }

                }             
            }

            return algunObjetoVacio;
        }
    }
}
