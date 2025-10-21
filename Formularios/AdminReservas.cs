using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Windows.Forms;

namespace pruebadiseño.Formularios
{
    public partial class AdminReservas : Form
    {
        public AdminReservas()
        {
            InitializeComponent();
            this.dgvReservas.SelectionChanged += new System.EventHandler(this.dgvReservas_SelectionChanged);
            LimpiarCampos();
        }

        private void AdminReservas_Load(object sender, EventArgs e)
        {
            refrescarPantalla();
            txtId.Enabled = false;
            LimpiarCampos();
        }

        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                txtId.Text = Convert.ToString(dgvReservas.CurrentRow.Cells["id"].Value);
                txtNombre.Text = Convert.ToString(dgvReservas.CurrentRow.Cells["nombre"].Value);
                txtCelular.Text = Convert.ToString(dgvReservas.CurrentRow.Cells["celular"].Value);
                txtCorreo.Text = Convert.ToString(dgvReservas.CurrentRow.Cells["correo"].Value);
                txtCantidad.Text = Convert.ToString(dgvReservas.CurrentRow.Cells["cantidad_personas"].Value);
                dtpFecha.Text = Convert.ToString(dgvReservas.CurrentRow.Cells["fecha"].Value);
                dtpHora.Text = Convert.ToString(dgvReservas.CurrentRow.Cells["hora"].Value);
            }
            else
            {
                MessageBox.Show("CurrentRow es null");
            }
        }


        public void refrescarPantalla()
        {
            var reservas = ReservaDAL.MostrarRegistro();
            //MessageBox.Show($"Reservas cargadas: {reservas.Count}");  
            dgvReservas.DataSource = reservas;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtCantidad.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
        }

        private void AdminReservas_Load_1(object sender, EventArgs e)
        {
            refrescarPantalla();
            txtId.Enabled = false;
            LimpiarCampos();
           
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Reserva reserva = new Reserva();
            reserva.id = int.Parse(txtId.Text);
            reserva.nombre = txtNombre.Text;
            reserva.celular = txtCelular.Text;
            reserva.correo = txtCorreo.Text;
            reserva.cantidad_personas = int.Parse(txtCantidad.Text);
            reserva.fecha = dtpFecha.Value.Date;
            reserva.hora = dtpHora.Value.TimeOfDay;

            int result = ReservaDAL.ModificarReserva(reserva);
            if (result > 0)
            {
                MessageBox.Show("Modificado correctamente");
            }
            else
            {
                MessageBox.Show("Error al modificar");
            }
            refrescarPantalla();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta reserva?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            if (dgvReservas.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvReservas.CurrentRow.Cells["id"].Value);
                int resultado = ReservaDAL.EliminarReserva(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            refrescarPantalla();
            LimpiarCampos();

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validación: Campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCelular.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Reserva reserva = new Reserva();
            reserva.nombre = txtNombre.Text;
            reserva.celular = txtCelular.Text;
            reserva.correo = txtCorreo.Text;
            reserva.cantidad_personas = int.Parse(txtCantidad.Text);
            reserva.fecha = dtpFecha.Value.Date;
            reserva.hora = dtpHora.Value.TimeOfDay;



            int result = ReservaDAL.AgregarReserva(reserva);
            if (result > 0)
            {
                MessageBox.Show("Reserva guardada");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            refrescarPantalla();
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = cbBuscarPor.SelectedItem?.ToString();
            string valor = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(criterio) && !string.IsNullOrEmpty(valor))
            {
                dgvReservas.DataSource = ReservaDAL.BuscarReservasAdmin(criterio, valor);
            }
            else
            {
                refrescarPantalla();
            }
        }




        
    }
}