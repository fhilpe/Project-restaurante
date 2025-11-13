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
                         (nombre, celular, correo, cantidad_personas, fecha, hora, id_cliente, id_mesa)
                         VALUES (@nombre, @celular, @correo, @cantidad_personas, @fecha, @hora, @id_cliente, @id_mesa)";

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
                    comando.Parameters.AddWithValue("@id_mesa", reserva.id_mesa);
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
                    reserva.id_mesa = reader.IsDBNull(8) ? 0 : reader.GetInt32(8); Lista.Add(reserva);
                }
            }
            return Lista;
        }

        // Mostrar registro Admin
        public static List<Reserva> MostrarRegistroAdmin()
        {
            List<Reserva> Lista = new List<Reserva>();
            using (SqlConnection conexion = General.obtenerConexion())
            {
                string query = "SELECT id, nombre, celular, correo, cantidad_personas, fecha, hora, id_cliente, id_mesa FROM reserva";
                SqlCommand comando = new SqlCommand(query, conexion);
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
                    reserva.id_mesa = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);  // Verificar NULL
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
                    reserva.id_mesa = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
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
                    reserva.id_mesa = reader.IsDBNull(8) ? 0 : reader.GetInt32(8); Lista.Add(reserva);
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
                     cantidad_personas=@cantidad_personas, fecha=@fecha, hora=@hora, id_mesa=@id_mesa
                 WHERE id=@id";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", reserva.nombre);
                comando.Parameters.AddWithValue("@celular", reserva.celular);
                comando.Parameters.AddWithValue("@correo", reserva.correo);
                comando.Parameters.AddWithValue("@cantidad_personas", reserva.cantidad_personas);
                comando.Parameters.AddWithValue("@fecha", reserva.fecha);
                comando.Parameters.AddWithValue("@hora", reserva.hora);
                comando.Parameters.AddWithValue("@id_mesa", reserva.id_mesa);
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

        public static List<Mesa> ObtenerMesasDisponibles() // Sin parametros para cargar todas las mesas inicialmente
        {
            List<Mesa> lista = new List<Mesa>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "SELECT id_mesa, numero_mesa, capacidad FROM mesa WHERE estado = 'Disponible'";
                SqlCommand cmd = new SqlCommand(q, c);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Mesa
                    {
                        IdMesa = r.GetInt32(0),
                        NumeroMesa = r.GetInt32(1),
                        Capacidad = r.GetInt32(2)
                    });
                }
            }
            return lista;
        }



        public static List<Mesa> ObtenerMesasDisponibles(DateTime fecha, TimeSpan hora)
        {
            List<Mesa> lista = new List<Mesa>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = @"SELECT m.id_mesa, m.numero_mesa, m.capacidad 
                     FROM mesa m 
                     WHERE m.estado = 'Disponible' 
                     AND NOT EXISTS (
                         SELECT 1 FROM reserva r 
                         WHERE r.id_mesa = m.id_mesa 
                         AND r.fecha = @fecha 
                         AND r.hora = @hora
                     )";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@hora", hora);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Mesa
                    {
                        IdMesa = r.GetInt32(0),
                        NumeroMesa = r.GetInt32(1),
                        Capacidad = r.GetInt32(2)
                    });
                }
            }
            return lista;
        }






    }
}
