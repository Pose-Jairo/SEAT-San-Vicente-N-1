using System;
using System.Data;
using System.Data.OleDb;

namespace Datos.Conexion
{
    public class ConexionConBD
    {
        private static OleDbConnection conexion;
        private static OleDbCommand comando;

        private static string stringConexion = "Provider= Microsoft.Jet.OLEDB.4.0; " +
            "Data Source = Estudiantes.mdb;";

        public OleDbConnection Conexion
        {
            get{return conexion;}
            set { conexion = value; }
        }

        public OleDbCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }

        public OleDbDataReader Lector(string Consulta)
        {
            Conexion = new OleDbConnection(stringConexion);

            Comando = new OleDbCommand(Consulta, Conexion);

            try
            {
                Conexion.Open();
                return Comando.ExecuteReader();
            }
            catch
            {
                OleDbDataReader error = null;
                return error;
            }
        }

        public void Desconectar()
        {
            if(Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        public bool EjecutarConsulta(string Consulta)
        {
            bool Resultado = false;

            Conexion = new OleDbConnection(stringConexion);

            Comando = new OleDbCommand(Consulta, Conexion);

            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Resultado = true;
            }
            catch
            {
                Resultado = false;
            }

            Desconectar();
            return Resultado;
        }
    }
}
