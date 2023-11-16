using System;
using Datos.Conexion;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data.OleDb;

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
            string textoDecorativo = "";

            foreach (Control control in groupBox.Controls)
            {                 
                if (control is TextBox)
                {
                    textoDecorativo = control.Tag.ToString();

                    if (string.IsNullOrWhiteSpace(control.Text) || (control.Text == textoDecorativo))
                    {
                        algunObjetoVacio = false;
                        error.SetError(control, "Campo Obligatorio");                                           
                    }
                }
                else if (control is ComboBox)
                {
                    textoDecorativo = control.Tag.ToString();

                    if (string.IsNullOrWhiteSpace(control.Text) || (control.Text == textoDecorativo))
                    {
                        algunObjetoVacio = false;
                        error.SetError(control, "Campo Obligatorio");              
                    }

                }             
            }

            return algunObjetoVacio;
        }

       public bool ValidarEmail(string email)
       {
           string patron = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";

           if (Regex.IsMatch(email, patron))
            {
                return true;
            }
            else
            {
                return false;
            }         
       }

       public bool ValidadDatosLogin(string email, string contraseña)
       {
           string cadenaEmail = "SELECT Contraseña FROM Docente WHERE Email ='" + email + "'";

           using (OleDbDataReader lector = BDConexion.Lector(cadenaEmail))
               if (lector.Read())
               {
                   // El correo electrónico existe, ahora compara las contraseñas.
                   string contraseñaAlmacenada = lector["Contraseña"].ToString();
                   if (contraseña == contraseñaAlmacenada)
                   {
                       return true;
                   }
                   else
                   {
                       MessageBox.Show("error");
                       return false;
                   }
               }
               else
               {
                   MessageBox.Show("error");
                   return false;
               }         
       }
    }
}
