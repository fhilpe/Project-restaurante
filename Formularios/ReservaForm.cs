using System;
using System.Windows.Forms;
using pruebadiseño;

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
            LimpiarCampos();
            dtpFecha.MinDate = DateTime.Today;
            dtpHora.Value = DateTime.Today.AddHours(9);  // 9 AM
            RecargarMesas();

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

        private void dtpHora_ValueChanged(object sender, EventArgs e)  /*Sirve para limitar la hora */
        {
            RecargarMesasConFiltro();
            TimeSpan minTime = new TimeSpan(9, 0, 0);  // 9 AM
            TimeSpan maxTime = new TimeSpan(20, 0, 0); // 8 PM
            TimeSpan currentTime = dtpHora.Value.TimeOfDay;

            int minutes = currentTime.Minutes;
            //int roundedMinutes = (minutes < 15) ? 0 : (minutes < 45) ? 30 : 0;  // 0 o 30
            int roundedMinutes;

            if (minutes > 1 && minutes <= 20)
            {
                roundedMinutes = 20;

            }else if (minutes > 20 && minutes <= 40 )
            {
                roundedMinutes = 40;
            }
            else
            {
                roundedMinutes = 0;
            }


            if (roundedMinutes == 0 && minutes >= 45) currentTime = currentTime.Add(TimeSpan.FromHours(1));  // Si >=45, sube hora
            TimeSpan roundedTime = new TimeSpan(currentTime.Hours, roundedMinutes, 0);
            // Aplicar límites
            if (roundedTime < minTime)
            {
                roundedTime = minTime;
            }
            else if (roundedTime > maxTime)
            {
                roundedTime = maxTime;
            }
            dtpHora.Value = dtpHora.Value.Date + roundedTime;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación: Mesa seleccionada
            if (cbMesas.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una mesa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Reserva reserva = new Reserva();
                reserva.nombre = txtNombre.Text;
                reserva.celular = txtCelular.Text;
                reserva.correo = txtCorreo.Text;
                reserva.cantidad_personas = int.Parse(txtCantidad.Text);
                reserva.fecha = dtpFecha.Value.Date;
                reserva.hora = dtpHora.Value.TimeOfDay;
                reserva.id_mesa = (int)cbMesas.SelectedValue;
           
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtCantidad.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            cbMesas.SelectedIndex = -1;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            RecargarMesasConFiltro();
        }

        private void RecargarMesas()
        {
            cbMesas.DataSource = ReservaDAL.ObtenerMesasDisponibles();  // Sin parámetros
            cbMesas.DisplayMember = "NumeroMesa";
            cbMesas.ValueMember = "IdMesa";
        }

        private void RecargarMesasConFiltro()
        {
            cbMesas.DataSource = ReservaDAL.ObtenerMesasDisponibles(dtpFecha.Value.Date, dtpHora.Value.TimeOfDay);  // Con parámetros
            cbMesas.DisplayMember = "NumeroMesa";
            cbMesas.ValueMember = "IdMesa";
            if (cbMesas.Items.Count == 0)
            {
                MessageBox.Show("No hay mesas disponibles para esta fecha y hora.");
            }
        }




    }
}

