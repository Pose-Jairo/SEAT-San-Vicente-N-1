using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos.Conexion;

namespace Logica.Negocio
{
    public class Metodos
    {
        ConexionConBD BDConexion = new ConexionConBD();

        public DataTable Actualizar(DataTable Tabla, string consulta)
        {
            Tabla = new DataTable();

            Tabla.Clear();

            Tabla.Load(BDConexion.Lector(consulta));

            BDConexion.Desconectar();

            return (Tabla);
        }




    }
}
