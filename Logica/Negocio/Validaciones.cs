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

        public void PruebaAbm(string consulta)
        {
            bool ABM = false;

            ABM = BDConexion.EjecutarConsulta(consulta);

            if (ABM == true)
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

       public bool ValidadDatosLogin(TextBox email, TextBox pass)
       {
           string cadenaEmail = "SELECT Contraseña FROM Docente WHERE Email ='" + email.Text + "'";

           using (OleDbDataReader lector = BDConexion.Lector(cadenaEmail))
               if (lector.Read())
               {
                   // El correo electrónico existe, ahora compara las contraseñas.
                   string contraseñaAlmacenada = lector["Contraseña"].ToString();
                   if (pass.Text == contraseñaAlmacenada)
                   {
                       return true;
                   }
                   else
                   {                    
                       return false;
                   }
               }
               else
               {                  
                   return false;
               }         
       }

    }
}
