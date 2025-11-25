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
            CargarImagenPerfil();
        }

        private void CargarImagenPerfil()
        {
            var cliente = ClienteDAL.MostrarClientes().Find(c => c.IdCliente == Sesion.IdCliente);
            if (cliente != null && !string.IsNullOrEmpty(cliente.Imagen))
            {
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        byte[] bytes = wc.DownloadData(cliente.Imagen);
                        using (var ms = new System.IO.MemoryStream(bytes))
                        {
                            pbPerfil.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
                catch
                {
                    pbPerfil.Image = Properties.Resources.default_user;
                }
            }
            else
            {
                pbPerfil.Image = Properties.Resources.default_user;
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

        private void btnVerMenu_Click(object sender, EventArgs e)
        {          
            this.Hide();
            mainForm.OpenChildFrom(new MenuUsuario());
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.OpenChildFrom(new VerPedidos());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            btnPerfil.Enabled = false;    

            EditarPerfil editar = new EditarPerfil();
            editar.FormClosed += (s, args) => btnPerfil.Enabled = true; 
            editar.Show();
        }
    }
}
