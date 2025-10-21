using System;
using System.Data.SqlClient;
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

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
