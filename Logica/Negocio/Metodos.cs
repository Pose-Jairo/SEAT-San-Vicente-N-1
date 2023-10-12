using System;
using System.Data;
using Datos.Conexion;
using Datos.Consultas;

namespace Logica.Negocio
{
    public class Metodos
    {
        ConexionConBD BDConexion = new ConexionConBD();
        ABM abm = new ABM();
        
        public DataTable Actualizar(DataTable Tabla, string consulta)
        {
            Tabla = new DataTable();

            Tabla.Clear();

            Tabla.Load(BDConexion.Lector(consulta));

            BDConexion.Desconectar();

            return (Tabla);
        }

        public int ConseguirNacionalidad(string nacionalidad)
        {
            int codNacionalidad = 0;

            string cadenaNacionalidad = "SELECT Cod_nacion FROM Nacionalidad WHERE NomNacion=" + "'" + nacionalidad + "'";

            codNacionalidad = BDConexion.ObtenerValor(cadenaNacionalidad);

            return codNacionalidad;
        }

        public int ConseguirLocalidad(string localidad)
        {
            int codLocalidad = 0;

            string cadenaLocalidad = "SELECT Cod_post FROM Localidad WHERE NomLocal=" + "'" + localidad + "'";

            codLocalidad = BDConexion.ObtenerValor(cadenaLocalidad);

            return codLocalidad;
        }
    }
}
