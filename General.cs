using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebadiseño
{
    public class General
    {
        public static SqlConnection obtenerConexion()
        {
                                                                 //Reemplazar esta cadena:
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBrestaurant;Data Source=Felipe");
            
            conexion.Open();
            return conexion;
        }

        /*         
          A veces, la conexión mediante localhost puede generar errores. entonces recomiendo crear un archivo 
          con extension .udl, ejecutarlo y establecer la conexión directamente con la base de datos, por ultimo 
          abre el archivo .udl con el block de notas y copia la cadena de conexión que contiene la dirección 
          del servidor SQL y reemplaza la que estás utilizando actualmente en tu proyecto
        */

    }
}
