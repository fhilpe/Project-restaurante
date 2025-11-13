using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebadiseño;

namespace pruebadiseño.Formularios
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            this.dgvMenu.SelectionChanged += new System.EventHandler(this.dgvMenu_SelectionChanged);
            CargarCategorias();  // Primero llena el ComboBox
            cbCategoria.SelectedIndex = 0;  // Luego selecciona
            CargarMenu();  // Finalmente carga menú
        }

       

        private void CargarMenu()
        {
            if (cbCategoria.SelectedItem == null) return;  // Verificación adicional
            string categoria = cbCategoria.SelectedItem.ToString();
            if (categoria == "Todas")
            {
                dgvMenu.DataSource = ProductoDAL.MostrarProductos();
            }
            else
            {
                dgvMenu.DataSource = ProductoDAL.MostrarProductosPorCategoria(categoria);
            }

            // Configurar columnas
            if (dgvMenu.Columns.Count > 0)
            {
                dgvMenu.Columns["IdProducto"].Visible = false;
                dgvMenu.Columns["Descripcion"].Visible = false;
                dgvMenu.Columns["Precio"].Visible = false;
                dgvMenu.Columns["Categoria"].Visible = false;
                dgvMenu.Columns["Disponible"].Visible = false;
                dgvMenu.Columns["Imagen"].Visible = false;
                dgvMenu.Columns["Nombre"].HeaderText = "Platos Disponibles";
            }
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;
            int idProducto = Convert.ToInt32(dgvMenu.CurrentRow.Cells["IdProducto"].Value);
            string nombre = Convert.ToString(dgvMenu.CurrentRow.Cells["Nombre"].Value);
            decimal precio = Convert.ToDecimal(dgvMenu.CurrentRow.Cells["Precio"].Value);
            // Agrega o incrementa cantidad
            var existente = Carrito.Items.Find(d => d.IdProducto == idProducto);
            if (existente != null)
            {
                existente.Cantidad++;
            }
            else
            {
                Carrito.Items.Add(new DetallePedido { IdProducto = idProducto, Cantidad = 1, PrecioUnitario = precio });
            }
            Carrito.Total += precio;
            MessageBox.Show($"Agregado: {nombre}");
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMenu();
        }

        //                 txtNombre.Text = Convert.ToString(dgvMenu.CurrentRow.Cells["Nombre"].Value);

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow != null)
            {
                txtNombre.Text = Convert.ToString(dgvMenu.CurrentRow.Cells["Nombre"].Value);
                rtbDescripcion.Text = Convert.ToString(dgvMenu.CurrentRow.Cells["Descripcion"].Value);
                txtPrecio.Text = Convert.ToString(dgvMenu.CurrentRow.Cells["Precio"].Value) + " $";

                // Cargar imagen desde URL
                string imagenUrl = Convert.ToString(dgvMenu.CurrentRow.Cells["Imagen"].Value);
                if (!string.IsNullOrEmpty(imagenUrl))
                {
                    try
                    {
                        using (WebClient wc = new WebClient())
                        {
                            byte[] bytes = wc.DownloadData(imagenUrl);
                            using (var ms = new System.IO.MemoryStream(bytes))
                            {
                                pbImagen.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    catch
                    {
                        pbImagen.Image = Properties.Resources.default_food;  // Si falla, sin imagen
                    }
                }
                else
                {
                    pbImagen.Image = Properties.Resources.default_food;
                }
            }
            else
            {
                rtbDescripcion.Clear();
                txtPrecio.Clear();
                pbImagen.Image = null;
            }
        }

        private void CargarCategorias()
        {
            cbCategoria.Items.Clear();
            cbCategoria.Items.Add("Todas");
            List<string> categorias = ProductoDAL.ObtenerCategorias();
            foreach (string cat in categorias)
            {
                cbCategoria.Items.Add(cat);
            }
        }

        public static class Carrito
        {
            public static List<DetallePedido> Items = new List<DetallePedido>();
            public static decimal Total = 0;
        }

        private void btnIrCarrito_Click(object sender, EventArgs e)
        {
            HacerPedido hacerPedido = new HacerPedido();
            this.Hide();
            hacerPedido.Show();
        }




        // fin
    }
}