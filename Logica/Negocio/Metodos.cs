using System;
using System.Data;
using System.Windows.Forms;
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

        public int ConseguirCodigoDeTabla(string nombreTabla, string valorCampoDeTabla)
        {
            int codigoDeTabla = 0;

            string cadenaParaTabla;

            switch (nombreTabla)
            {
                case "Localidad":
                    cadenaParaTabla = "SELECT Cod_post FROM Localidad WHERE NomLocal=" + "'" + valorCampoDeTabla + "'";
                    codigoDeTabla = BDConexion.ObtenerValor(cadenaParaTabla);
                    break;
                case "Nacionalidad":
                    cadenaParaTabla = "SELECT Cod_nacion FROM Nacionalidad WHERE NomNacion=" + "'" + valorCampoDeTabla + "'";
                    codigoDeTabla = BDConexion.ObtenerValor(cadenaParaTabla);
                    break;
                case "Categoria":
                    cadenaParaTabla = "SELECT Id_categ FROM Categoria WHERE Descripcion=" + "'" + valorCampoDeTabla + "'";
                    codigoDeTabla = BDConexion.ObtenerValor(cadenaParaTabla);
                    break;
                case "Caracterizacion":
                    cadenaParaTabla = "SELECT Id_caract FROM Caracterizacion WHERE Especificacion=" + "'" + valorCampoDeTabla + "'";
                    codigoDeTabla = BDConexion.ObtenerValor(cadenaParaTabla);
                    break;
                case " DNI":
                    cadenaParaTabla = "SELECT Id_resp FROM Responsable WHERE DNI=" + valorCampoDeTabla;
                    codigoDeTabla = BDConexion.ObtenerValor(cadenaParaTabla);
                    break;
                case "DNI":
                    cadenaParaTabla = "SELECT Id_docente FROM Docente WHERE DNI='" + valorCampoDeTabla + "'";
                    codigoDeTabla = BDConexion.ObtenerValor(cadenaParaTabla);
                    break;
                case " CUIL":
                    cadenaParaTabla = "SELECT Id_estudiante FROM Estudiante WHERE CUIL='" + valorCampoDeTabla + "'";
                    codigoDeTabla = BDConexion.ObtenerValor(cadenaParaTabla);
                    break;
            }
            return codigoDeTabla;
        }

        public int ValorCodigo(Control objeto)
        {
            int codigoDeTabla = 0;

            codigoDeTabla = ConseguirCodigoDeTabla(objeto.Tag.ToString(), objeto.Text);

            return codigoDeTabla;
        }

    }
}
