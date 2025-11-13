using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebadiseño;

namespace pruebadiseño.Formularios
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
        }

        private void MenuAdmin_Load_1(object sender, EventArgs e)
        {
            refrescarPantalla();
            txtIdProducto.Enabled = false;
            LimpiarCampos();
            dgvProductos.ClearSelection();
            CargarCategorias();  // Llama aquí
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) ||
        string.IsNullOrWhiteSpace(cbCategoria.Text))  // Verifica Text
            {
                MessageBox.Show("Complete nombre, precio y categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Producto p = new Producto();
                p.Nombre = txtNombre.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Categoria = cbCategoria.Text;  // Usa Text
                p.Disponible = chkDisponible.Checked;

                int result = ProductoDAL.AgregarProducto(p);
                if (result > 0)
                {
                    MessageBox.Show("Producto guardado");
                    CargarCategorias();
                    refrescarPantalla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbCategoria.Text))  // Verifica Text
            {
                MessageBox.Show("Escriba o seleccione una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Producto p = new Producto();
                p.IdProducto = int.Parse(txtIdProducto.Text);
                p.Nombre = txtNombre.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Categoria = cbCategoria.Text;  // Usa Text
                p.Disponible = chkDisponible.Checked;

                int result = ProductoDAL.ModificarProducto(p);
                if (result > 0)
                {
                    MessageBox.Show("Modificado correctamente");
                    CargarCategorias();
                    refrescarPantalla();
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
            int resultado = ProductoDAL.EliminarProducto(id);
            if (resultado > 0)
            {
                MessageBox.Show("Eliminado correctamente");
                refrescarPantalla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                // Índices: 0=id, 1=nombre, 2=descripcion, 3=precio, 4=categoria, 5=disponible
                txtIdProducto.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);
                txtNombre.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[1].Value);
                txtDescripcion.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[2].Value);
                txtPrecio.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[3].Value);
                cbCategoria.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[4].Value);
                chkDisponible.Checked = Convert.ToBoolean(dgvProductos.CurrentRow.Cells[5].Value);
                txtImagen.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[6].Value);
            }
        }

        public void refrescarPantalla()
        {
            dgvProductos.DataSource = ProductoDAL.MostrarProductos();
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            cbCategoria.Text = "";
            chkDisponible.Checked = true;
            txtImagen.Clear();
        }

        private void CargarCategorias()
        {
            cbCategoria.Items.Clear();
            List<string> categorias = ProductoDAL.ObtenerCategorias();
            foreach (string cat in categorias)
            {
                cbCategoria.Items.Add(cat);
            }
            // Agrega opción para nuevas
            cbCategoria.Items.Add("Otra (escribir)");
            cbCategoria.Text = "";  // Limpia
        }

        // fin
    }
}