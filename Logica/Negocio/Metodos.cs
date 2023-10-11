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

        bool _alta = false;

        public bool cadenaAlta()
        {           
            _alta = BDConexion.EjecutarConsulta(abm.Cadena);

            return _alta;
        }
        public bool Alta
        {
            get { return _alta; }
            set { _alta = value; }
        }

    }
}
