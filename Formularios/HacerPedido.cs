using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebadiseño.Formularios;
using System.Windows.Media.Media3D;
using static pruebadiseño.Formularios.MenuUsuario;

namespace pruebadiseño.Formularios
{
    public partial class HacerPedido : Form
    {
        private List<DetallePedido> carrito = new List<DetallePedido>();
        private decimal total = 0;
        public HacerPedido()
        {
            InitializeComponent();
        }

        private void HacerPedido_Load(object sender, EventArgs e)
        {
            carrito = Carrito.Items;  // Carga del carrito global
            total = Carrito.Total;
            ActualizarCarrito();

            cbTipoPedido.Items.Add("Mesa");
            cbTipoPedido.Items.Add("Domicilio");
            cbTipoPedido.SelectedIndex = 0;
            ActualizarCarrito();
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            // Abre MenuUsuario para seleccionar plato
            MenuUsuario menu = new MenuUsuario();
            if (menu.ShowDialog() == DialogResult.OK)
            {
                // Asume que MenuUsuario tiene propiedad para devolver plato seleccionado
                // Por simplicidad, agrega manualmente o integra
                MessageBox.Show("Integra selección de plato aquí.");
            }
        }

        private void btnQuitarPlato_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                int index = dgvCarrito.SelectedRows[0].Index;
                carrito.RemoveAt(index);
                ActualizarCarrito();
            }
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("Agregue platos al carrito.");
                return;
            }

            string tipo = cbTipoPedido.SelectedItem.ToString();
            string direccion = tipo == "Domicilio" ? txtDireccion.Text : null;
            int idMesa = tipo == "Mesa" ? (int)cbMesa.SelectedValue : 0;

            Pedido p = new Pedido
            {
                IdCliente = Sesion.IdCliente,
                Total = total,
                Estado = "Pendiente",
                TipoPedido = tipo,
                Direccion = direccion,
                IdMesa = idMesa
            };

            int idPedido = PedidoDAL.CrearPedido(p);
            foreach (var d in carrito)
            {
                d.IdPedido = idPedido;
                PedidoDAL.AgregarDetallePedido(idPedido, d);
            }
            Carrito.Items.Clear();  // Limpia después de confirmar
            Carrito.Total = 0;

            MessageBox.Show("Pedido confirmado!");
            this.Close();
        }

        private void ActualizarCarrito()
        {
            // Crear DataTable personalizado para mostrar solo nombre, cantidad, precio
            var dt = new System.Data.DataTable();
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio Unitario");
            dt.Columns.Add("Subtotal");
            foreach (var item in carrito)
            {
                var producto = ProductoDAL.MostrarProductos().Find(p => p.IdProducto == item.IdProducto);
                if (producto != null)
                {
                    dt.Rows.Add(producto.Nombre, item.Cantidad, item.PrecioUnitario, item.Cantidad * item.PrecioUnitario);
                }
            }
            dgvCarrito.DataSource = dt;
            total = carrito.Sum(d => d.Cantidad * d.PrecioUnitario);
            lblTotal.Text = $"Total: {total}$";
        }

        private void cbTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPedido.SelectedItem.ToString() == "Domicilio")
            {
                txtDireccion.Visible = true;
                cbMesa.Visible = false;
            }
            else
            {
                txtDireccion.Visible = false;
                cbMesa.Visible = true;
                cbMesa.DataSource = ReservaDAL.ObtenerMesasDisponibles(DateTime.Now.Date, DateTime.Now.TimeOfDay);
                cbMesa.DisplayMember = "NumeroMesa";
                cbMesa.ValueMember = "IdMesa";
            }
        }







        // fin
    }
}