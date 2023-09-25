using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Datos.Conexion;

namespace Datos.Consultas
{
    public class ABM
    {
        ConexionConBD BDConexion = new ConexionConBD();

        private string cadena;
        string consulta;

        public void cadenaINSERT(List<TextBox> listaTextBox)
        {
                   
            string nombreTabla = "Estudiante"; // Nombre de la tabla de la base de datos

            StringBuilder insertarCadena = new StringBuilder();
            insertarCadena.Append("INSERT INTO " + nombreTabla + " (");
    
                // Obtiene los nombres de las columnas de la tabla
                consulta=("SELECT Name FROM MSysObjects WHERE Type=1 AND Name='" + nombreTabla + "'");
                using (OleDbDataReader lector = BDConexion.Lector(consulta))
                {
                    while (lector.Read())
                    {
                        insertarCadena.Append(lector["Name"].ToString() + ", ");
                    }
                }

                // Elimina la coma y el espacio extra al final de la cadena
                insertarCadena.Length -= 2;
                insertarCadena.Append(") VALUES (");

                // Agrega los valores de los TextBox
                foreach (TextBox textBox in listaTextBox)
                {
                    insertarCadena.Append("'" + textBox.Text + "', ");
                }

                // Elimina la coma y el espacio extra al final de la cadena
                insertarCadena.Length -= 2;
                insertarCadena.Append(")");

                cadena= insertarCadena.ToString();              
            }
        public string Cadena
        {
            get { return cadena; }
            set { cadena = value; }
        }
            // Luego, ejecutas la consulta en tu base de datos de Access
            // ...
    }
}
