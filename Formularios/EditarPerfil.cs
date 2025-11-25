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
    public partial class EditarPerfil : Form
    {
        public EditarPerfil()
        {
            InitializeComponent();
        }

        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            if (pbFoto.Image == null)
            {
                pbFoto.Image = Properties.Resources.default_user;  // Agrega imagen "default_user.png" a Resources
            }

            // Cargar datos actuales
            txtNombre.Text = Sesion.Nombre;
            txtCelular.Text = Sesion.Celular;
            // Cargar imagen si existe
            var cliente = ClienteDAL.MostrarClientes().Find(c => c.IdCliente == Sesion.IdCliente);
            if (cliente != null && !string.IsNullOrEmpty(cliente.Imagen))
            {
                txtImagenUrl.Text = cliente.Imagen;
                // Cargar imagen
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        byte[] bytes = wc.DownloadData(cliente.Imagen);
                        using (var ms = new System.IO.MemoryStream(bytes))
                        {
                            pbFoto.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
                catch
                {
                    pbFoto.Image = null;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string imagenUrl = txtImagenUrl.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(celular))
            {
                MessageBox.Show("Complete nombre y celular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = new Cliente
            {
                IdCliente = Sesion.IdCliente,
                Nombre = nombre,
                Celular = celular,
                Contraseña = string.IsNullOrEmpty(contraseña) ? null : contraseña,
                Imagen = imagenUrl
            };

            int result = ClienteDAL.ModificarCliente(cliente);
            if (result > 0)
            {
                MessageBox.Show("Perfil actualizado.");
                Sesion.Nombre = nombre;
                Sesion.Celular = celular;
                //this.Close();
                RecargarImagen();
            }
            else
            {
                MessageBox.Show("Error al actualizar.");
            }
        }

        private void txtImagenUrl_TextChanged(object sender, EventArgs e)
        {
            RecargarImagen();
        }


        private void RecargarImagen()
        {
            string url = txtImagenUrl.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        byte[] bytes = wc.DownloadData(url);
                        using (var ms = new System.IO.MemoryStream(bytes))
                        {
                            pbFoto.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
                catch
                {
                    pbFoto.Image = Properties.Resources.default_user;
                }
            }
            else
            {
                pbFoto.Image = Properties.Resources.default_user;
            }
        }

        // Mostrar/Ocultar contraseña
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = chkShowPassword.Checked ? '\0' : '*';

        }

        // fin
    }
}