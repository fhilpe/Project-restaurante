using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebadiseño.Formularios
{
    public partial class PanelUsuario : Form
    {
        public PanelUsuario()
        {
            InitializeComponent();
        }

        Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        private void PanelUsuario_Load(object sender, EventArgs e)
        {
            // Mostrar el nombre del usuario logueado en el Label
            if (!string.IsNullOrEmpty(Sesion.Nombre))
            {
                idNameUser.Text = $"{Sesion.Nombre}";
                CargarReservasUsuario();
            }
            else
            {
                idNameUser.Text = "Usuario no identificado";
                dgvReservasUsuario.Visible = false;
            }
        }

        private void CargarReservasUsuario()
        {
            // Cargar las reservas filtradas por el cliente logueado
            dgvReservasUsuario.DataSource = ReservaDAL.MostrarRegistro();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildFrom(new ReservaForm());
        }

        private void btnCerrarCuenta_Click(object sender, EventArgs e)
        {
            Sesion.Correo = null;
            Sesion.Nombre = null;
            Sesion.IdCliente = 0;
            Sesion.Celular = null;

            this.Hide();
            mainForm.OpenChildFrom(new Login());

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = cbBuscarPor.SelectedItem?.ToString();
            string valor = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(criterio) && !string.IsNullOrEmpty(valor))
            {
                dgvReservasUsuario.DataSource = ReservaDAL.BuscarReservas(criterio, valor, Sesion.IdCliente);
            }
            else
            {
                CargarReservasUsuario();
            }
        }
    }
}
