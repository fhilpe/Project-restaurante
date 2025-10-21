using System;
using System.Windows.Forms;

namespace pruebadiseño
{
    public partial class ReservaForm : Form
    {
        public ReservaForm()
        {
            InitializeComponent();
        }

        private void ReservaForm_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            LimpiarCampos();

            // Rellenar campos solo si hay sesión activa
            if (!string.IsNullOrEmpty(Sesion.Nombre))
            {
                txtNombre.Text = Sesion.Nombre;
                txtCelular.Text = Sesion.Celular;
                txtCorreo.Text = Sesion.Correo;

                txtNombre.ReadOnly = true;
                txtCelular.ReadOnly = true;
                txtCorreo.Enabled = false;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Reserva exitosa");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
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
    }
}