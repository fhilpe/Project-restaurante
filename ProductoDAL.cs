using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pruebadiseño
{
    public class ProductoDAL
    {
        // Mostrar todos los productos disponibles
        public static List<Producto> MostrarProductos()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "SELECT id_producto, nombre, descripcion, precio, categoria, disponible, imagen FROM productos WHERE disponible = 1";
                SqlCommand cmd = new SqlCommand(q, c);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Producto
                    {
                        IdProducto = r.GetInt32(0),
                        Nombre = r.GetString(1),
                        Descripcion = r.GetString(2),
                        Precio = r.GetDecimal(3),
                        Categoria = r.GetString(4),
                        Disponible = r.GetBoolean(5),
                        Imagen = r.IsDBNull(6) ? null : r.GetString(6)
                    });
                }
            }
            return lista;
        }

        // Mostrar productos por categoría
        public static List<Producto> MostrarProductosPorCategoria(string categoria)
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "SELECT id_producto, nombre, descripcion, precio, categoria, disponible, imagen FROM productos WHERE categoria = @categoria AND disponible = 1";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Producto
                    {
                        IdProducto = r.GetInt32(0),
                        Nombre = r.GetString(1),
                        Descripcion = r.GetString(2),
                        Precio = r.GetDecimal(3),
                        Categoria = r.GetString(4),
                        Disponible = r.GetBoolean(5),
                        Imagen = r.IsDBNull(6) ? null : r.GetString(6)
                    });
                }
            }
            return lista;
        }

        // Agregar producto
        public static int AgregarProducto(Producto p)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "INSERT INTO productos (nombre, descripcion, precio, categoria, disponible, imagen) VALUES (@n, @d, @p, @c, @disp, @img)";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@d", p.Descripcion);
                cmd.Parameters.AddWithValue("@p", p.Precio);
                cmd.Parameters.AddWithValue("@c", p.Categoria);
                cmd.Parameters.AddWithValue("@disp", p.Disponible);
                cmd.Parameters.AddWithValue("@img", p.Imagen ?? (object)DBNull.Value);
                return cmd.ExecuteNonQuery();
            }
        }

        // Modificar producto
        public static int ModificarProducto(Producto p)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "UPDATE productos SET nombre=@n, descripcion=@d, precio=@p, categoria=@c, disponible=@disp, imagen=@img WHERE id_producto=@id";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@d", p.Descripcion);
                cmd.Parameters.AddWithValue("@p", p.Precio);
                cmd.Parameters.AddWithValue("@c", p.Categoria);
                cmd.Parameters.AddWithValue("@disp", p.Disponible);
                cmd.Parameters.AddWithValue("@img", p.Imagen ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id", p.IdProducto);
                return cmd.ExecuteNonQuery();
            }
        }

        // Eliminar producto (lógico)
        public static int EliminarProducto(int id)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "UPDATE productos SET disponible = 0 WHERE id_producto = @id";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery();
            }
        }

        // Buscar productos por nombre
        public static List<Producto> BuscarProductos(string nombre)
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "SELECT id_producto, nombre, descripcion, precio, categoria, disponible, imagen FROM productos WHERE nombre LIKE @nombre AND disponible = 1";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Producto
                    {
                        IdProducto = r.GetInt32(0),
                        Nombre = r.GetString(1),
                        Descripcion = r.GetString(2),
                        Precio = r.GetDecimal(3),
                        Categoria = r.GetString(4),
                        Disponible = r.GetBoolean(5),
                        Imagen = r.IsDBNull(6) ? null : r.GetString(6)
                    });
                }
            }
            return lista;
        }

        public static List<string> ObtenerCategorias()
        {
            List<string> categorias = new List<string>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "SELECT DISTINCT categoria FROM productos WHERE disponible = 1";
                SqlCommand cmd = new SqlCommand(q, c);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    categorias.Add(r.GetString(0));
                }
            }
            return categorias;
        }



        // fin
    }
}