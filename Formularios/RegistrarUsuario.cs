using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace pruebadiseño.Formularios
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmarPassword = txtConfirmarPassword.Text.Trim();

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(celular) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmarPassword))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string patronCorreo = @"^[^@\s]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            // Validar formato de correo
            if (!Regex.IsMatch(correo, patronCorreo))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar contraseña fuerte
            if (!ValidarContraseña(password))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, con mayúsculas, minúsculas y números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar confirmación de contraseña
            if (password != confirmarPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conexion = General.obtenerConexion())
                {
                    string queryVerificar = "SELECT COUNT(*) FROM cliente WHERE correo = @correo";
                    SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conexion);
                    cmdVerificar.Parameters.AddWithValue("@correo", correo);
                    int count = (int)cmdVerificar.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El correo ya está registrado. Use otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insertar nuevo usuario
                    string queryInsertar = "INSERT INTO cliente (nombre, correo, celular, contraseña) VALUES (@nombre, @correo, @celular, @contraseña)";
                    SqlCommand cmdInsertar = new SqlCommand(queryInsertar, conexion);
                    cmdInsertar.Parameters.AddWithValue("@nombre", nombre);
                    cmdInsertar.Parameters.AddWithValue("@correo", correo);
                    cmdInsertar.Parameters.AddWithValue("@celular", celular);
                    cmdInsertar.Parameters.AddWithValue("@contraseña", password);

                    int filasAfectadas = cmdInsertar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar campos después del registro
                        txtNombre.Clear();
                        txtCorreo.Clear();
                        txtCelular.Clear();
                        txtPassword.Clear();
                        txtConfirmarPassword.Clear();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarContraseña(string pass)
        {
            return pass.Length >= 8 && pass.Any(char.IsUpper) && pass.Any(char.IsLower) && pass.Any(char.IsDigit);
        }
    }
}