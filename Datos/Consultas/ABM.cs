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

        public void cadenaINSERT()
        {

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
