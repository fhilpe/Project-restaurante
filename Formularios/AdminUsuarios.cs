using System;
using System.Windows.Forms;

namespace pruebadiseño.Formularios
{
    public partial class AdminUsuarios : Form
    {
        public AdminUsuarios()
        {
            InitializeComponent();
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            LimpiarCampos();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                txtIdCliente.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[0].Value);
                txtNombre.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[1].Value);
                txtCorreo.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[2].Value);
                txtCelular.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[3].Value);
                txtContraseña.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[4].Value);
            }
        }

        public void refrescarPantalla()
        {
            try
            {
                var clientes = ClienteDAL.MostrarClientes();
                //MessageBox.Show($"Clientes cargados: {clientes.Count}");  // Debug
                dgvClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtCelular.Clear();
            txtContraseña.Clear();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cliente cliente = new Cliente();
                cliente.IdCliente = int.Parse(txtIdCliente.Text);
                cliente.Nombre = txtNombre.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Celular = txtCelular.Text;
                cliente.Contraseña = txtContraseña.Text;

                int result = ClienteDAL.ModificarCliente(cliente);
                if (result > 0)
                {
                    MessageBox.Show("Modificado correctamente");
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
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            int resultado = ClienteDAL.EliminarCliente(id);
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtCelular.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Celular = txtCelular.Text;
                cliente.Contraseña = txtContraseña.Text;

                int result = ClienteDAL.AgregarCliente(cliente);
                if (result > 0)
                {
                    MessageBox.Show("Cliente guardado");
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

        private void AdminUsuarios_Load_1(object sender, EventArgs e)
        {
            refrescarPantalla();
            dgvClientes.Refresh();
            txtIdCliente.Enabled = false;
            LimpiarCampos();
            dgvClientes.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = cbBuscarPor.SelectedItem?.ToString();
            string valor = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(criterio) && !string.IsNullOrEmpty(valor))
            {
                dgvClientes.DataSource = ClienteDAL.BuscarClientes(criterio, valor);
            }
            else
            {
                refrescarPantalla();
            }
        }
    }
}