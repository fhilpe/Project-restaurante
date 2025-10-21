using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebadiseño
{
    internal class ReservaDAL
    {
        public static int AgregarReserva(Reserva reserva)
        {
            int resultado = 0;
            using (SqlConnection conexion = General.obtenerConexion())
            {
                string query = @"INSERT INTO reserva 
                         (nombre, celular, correo, cantidad_personas, fecha, hora, id_cliente)
                         VALUES (@nombre, @celular, @correo, @cantidad_personas, @fecha, @hora, @id_cliente)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", reserva.nombre);
                    comando.Parameters.AddWithValue("@celular", reserva.celular);
                    comando.Parameters.AddWithValue("@correo", reserva.correo);
                    comando.Parameters.AddWithValue("@cantidad_personas", reserva.cantidad_personas);
                    comando.Parameters.AddWithValue("@fecha", reserva.fecha);
                    comando.Parameters.AddWithValue("@hora", reserva.hora);
                    // Si hay sesión, usa Sesion.IdCliente; si no, NULL
                    comando.Parameters.AddWithValue("@id_cliente", !string.IsNullOrEmpty(Sesion.Nombre) ? (object)Sesion.IdCliente : DBNull.Value);
                    resultado = comando.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        public static List<Reserva> MostrarRegistro()
        {
            List<Reserva> Lista = new List<Reserva>();
            using (SqlConnection conexion = General.obtenerConexion())
            {
                string query = "SELECT * FROM reserva";
                // Filtrar por cliente si hay sesión (para PanelUsuario)
                if (!string.IsNullOrEmpty(Sesion.Nombre))
                {
                    query += " WHERE id_cliente = @id_cliente";
                }
                SqlCommand comando = new SqlCommand(query, conexion);
                if (!string.IsNullOrEmpty(Sesion.Nombre))
                {
                    comando.Parameters.AddWithValue("@id_cliente", Sesion.IdCliente);
                }
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Reserva reserva = new Reserva();
                    reserva.id = reader.GetInt32(0);
                    reserva.nombre = reader.GetString(1);
                    reserva.celular = reader.GetString(2);
                    reserva.correo = reader.GetString(3);
                    reserva.cantidad_personas = reader.GetInt32(4);
                    reserva.fecha = reader.GetDateTime(5);
                    reserva.hora = reader.GetTimeSpan(6);
                    Lista.Add(reserva);
                }
            }
            return Lista;
        }

        // Metodo para buscar User
        public static List<Reserva> BuscarReservas(string criterio, string valor, int idCliente)
        {
            List<Reserva> Lista = new List<Reserva>();
            using (SqlConnection conexion = General.obtenerConexion())
            {
                string query = "SELECT * FROM reserva WHERE id_cliente = @id_cliente";
                if (criterio == "Nombre")
                {
                    query += " AND nombre LIKE @valor";
                }
                else if (criterio == "Correo")
                {
                    query += " AND correo LIKE @valor";
                }
                else if (criterio == "Fecha")
                {
                    query += " AND CONVERT(date, fecha) = @valor";
                }
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id_cliente", idCliente);
                comando.Parameters.AddWithValue("@valor", criterio == "Fecha" ? valor : "%" + valor + "%");
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Reserva reserva = new Reserva();
                    reserva.id = reader.GetInt32(0);
                    reserva.nombre = reader.GetString(1);
                    reserva.celular = reader.GetString(2);
                    reserva.correo = reader.GetString(3);
                    reserva.cantidad_personas = reader.GetInt32(4);
                    reserva.fecha = reader.GetDateTime(5);
                    reserva.hora = reader.GetTimeSpan(6);
                    Lista.Add(reserva);
                }
            }
            return Lista;
        }

        //Metodo para buscar Admin

        public static List<Reserva> BuscarReservasAdmin(string criterio, string valor)
        {
            List<Reserva> Lista = new List<Reserva>();
            using (SqlConnection conexion = General.obtenerConexion())
            {
                string query = "";
                if (criterio == "Nombre")
                {
                    query = "SELECT * FROM reserva WHERE nombre LIKE @valor";
                }
                else if (criterio == "Correo")
                {
                    query = "SELECT * FROM reserva WHERE correo LIKE @valor";
                }
                else if (criterio == "Fecha")
                {
                    query = "SELECT * FROM reserva WHERE CONVERT(date, fecha) = @valor";
                }
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@valor", criterio == "Fecha" ? valor : "%" + valor + "%");
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Reserva reserva = new Reserva();
                    reserva.id = reader.GetInt32(0);
                    reserva.nombre = reader.GetString(1);
                    reserva.celular = reader.GetString(2);
                    reserva.correo = reader.GetString(3);
                    reserva.cantidad_personas = reader.GetInt32(4);
                    reserva.fecha = reader.GetDateTime(5);
                    reserva.hora = reader.GetTimeSpan(6);
                    Lista.Add(reserva);
                }
            }
            return Lista;
        }




        public static int ModificarReserva(Reserva reserva)
        {
            int result = 0;
            using (SqlConnection conexion = General.obtenerConexion())
            {

                string query = @"UPDATE reserva 
                 SET nombre=@nombre, celular=@celular, correo=@correo, 
                     cantidad_personas=@cantidad_personas, fecha=@fecha, hora=@hora
                 WHERE id=@id";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", reserva.nombre);
                comando.Parameters.AddWithValue("@celular", reserva.celular);
                comando.Parameters.AddWithValue("@correo", reserva.correo);
                comando.Parameters.AddWithValue("@cantidad_personas", reserva.cantidad_personas);
                comando.Parameters.AddWithValue("@fecha", reserva.fecha);
                comando.Parameters.AddWithValue("@hora", reserva.hora);
                comando.Parameters.AddWithValue("@id", reserva.id);

                result = comando.ExecuteNonQuery();
                conexion.Close();

            }
            return result;
        }




        public static int EliminarReserva(int id)
        {
            int resultado = 0;

            using (SqlConnection conexion = General.obtenerConexion())
            {


                string query = "delete from reserva where id=" + id + "  ";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    resultado = comando.ExecuteNonQuery();
                }
            }

            return resultado;
        }





    }
}
