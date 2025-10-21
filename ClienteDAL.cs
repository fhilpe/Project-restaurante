using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebadiseño
{
    internal class ClienteDAL
    {
        public static int AgregarCliente(Cliente cliente)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "INSERT INTO cliente (nombre, correo, celular, contraseña) VALUES (@n, @c, @ce, @p)";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@n", cliente.Nombre);
                cmd.Parameters.AddWithValue("@c", cliente.Correo);
                cmd.Parameters.AddWithValue("@ce", cliente.Celular);
                cmd.Parameters.AddWithValue("@p", cliente.Contraseña);
                return cmd.ExecuteNonQuery();
            }
        }

        public static List<Cliente> MostrarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "SELECT id_cliente, nombre, correo, celular, contraseña FROM cliente";
                SqlCommand cmd = new SqlCommand(q, c);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Cliente
                    {
                        IdCliente = r.GetInt32(0),
                        Nombre = r.GetString(1),
                        Correo = r.GetString(2),
                        Celular = r.GetString(3),
                        Contraseña = r.GetString(4)
                    });
                }
            }
            return lista;
        }

        public static int ModificarCliente(Cliente cliente)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "UPDATE cliente SET nombre=@n, correo=@c, celular=@ce, contraseña=@p WHERE id_cliente=@id";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@n", cliente.Nombre);
                cmd.Parameters.AddWithValue("@c", cliente.Correo);
                cmd.Parameters.AddWithValue("@ce", cliente.Celular);
                cmd.Parameters.AddWithValue("@p", cliente.Contraseña);
                cmd.Parameters.AddWithValue("@id", cliente.IdCliente);
                return cmd.ExecuteNonQuery();
            }
        }

        public static int EliminarCliente(int id)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "DELETE FROM cliente WHERE id_cliente=@id";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery();
            }
        }

        //Metodo para buscar cliente

        public static List<Cliente> BuscarClientes(string criterio, string valor)
        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "";
                if (criterio == "Nombre")
                {
                    q = "SELECT id_cliente, nombre, correo, celular, contraseña FROM cliente WHERE nombre LIKE @valor";
                }
                else if (criterio == "Correo")
                {
                    q = "SELECT id_cliente, nombre, correo, celular, contraseña FROM cliente WHERE correo LIKE @valor";
                }
                else if (criterio == "Celular")
                {
                    q = "SELECT id_cliente, nombre, correo, celular, contraseña FROM cliente WHERE celular LIKE @valor";
                }
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Cliente
                    {
                        IdCliente = r.GetInt32(0),
                        Nombre = r.GetString(1),
                        Correo = r.GetString(2),
                        Celular = r.GetString(3),
                        Contraseña = r.GetString(4)
                    });
                }
            }
            return lista;
        }



    }
}
