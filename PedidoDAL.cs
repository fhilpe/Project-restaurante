using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pruebadiseño
{
    public class PedidoDAL
    {
        // Crear pedido
        public static int CrearPedido(Pedido p)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = @"INSERT INTO pedidos (id_cliente, total, estado, tipo_pedido, direccion, id_mesa) 
                             VALUES (@idc, @tot, @est, @tp, @dir, @idm); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@idc", p.IdCliente);
                cmd.Parameters.AddWithValue("@tot", p.Total);
                cmd.Parameters.AddWithValue("@est", p.Estado);
                cmd.Parameters.AddWithValue("@tp", p.TipoPedido);
                cmd.Parameters.AddWithValue("@dir", p.Direccion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@idm", p.IdMesa == 0 ? (object)DBNull.Value : p.IdMesa);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Agregar detalle
        public static void AgregarDetallePedido(int idPedido, DetallePedido d)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "INSERT INTO detalle_pedido (id_pedido, id_producto, cantidad, precio_unitario) VALUES (@idp, @idprod, @cant, @pu)";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@idp", idPedido);
                cmd.Parameters.AddWithValue("@idprod", d.IdProducto);
                cmd.Parameters.AddWithValue("@cant", d.Cantidad);
                cmd.Parameters.AddWithValue("@pu", d.PrecioUnitario);
                cmd.ExecuteNonQuery();
            }
        }

        // Mostrar pedidos por cliente
        public static List<Pedido> MostrarPedidosPorCliente(int idCliente)
        {
            List<Pedido> lista = new List<Pedido>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "SELECT * FROM pedidos WHERE id_cliente = @idc";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@idc", idCliente);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Pedido
                    {
                        IdPedido = r.GetInt32(0),
                        IdCliente = r.GetInt32(1),
                        Fecha = r.GetDateTime(2),
                        Total = r.GetDecimal(3),
                        Estado = r.GetString(4),
                        TipoPedido = r.GetString(5),
                        Direccion = r.IsDBNull(6) ? null : r.GetString(6),
                        IdMesa = r.IsDBNull(7) ? 0 : r.GetInt32(7)
                    });
                }
            }
            return lista;
        }

        // Mostrar todos los pedidos (admin)
        public static List<Pedido> MostrarTodosPedidos()
        {
            List<Pedido> lista = new List<Pedido>();
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "SELECT * FROM pedidos";
                SqlCommand cmd = new SqlCommand(q, c);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(new Pedido
                    {
                        IdPedido = r.GetInt32(0),
                        IdCliente = r.GetInt32(1),
                        Fecha = r.GetDateTime(2),
                        Total = r.GetDecimal(3),
                        Estado = r.GetString(4),
                        TipoPedido = r.GetString(5),
                        Direccion = r.IsDBNull(6) ? null : r.GetString(6),
                        IdMesa = r.IsDBNull(7) ? 0 : r.GetInt32(7)
                    });
                }
            }
            return lista;
        }

        // Actualizar estado de pedido
        public static int ActualizarEstadoPedido(int idPedido, string estado)
        {
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "UPDATE pedidos SET estado = @est WHERE id_pedido = @id";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@est", estado);
                cmd.Parameters.AddWithValue("@id", idPedido);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}