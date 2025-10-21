using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using pruebadiseño.Formularios;

namespace pruebadiseño
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor ingrese correo y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conexion = General.obtenerConexion())
                {
                    string query = "SELECT id_cliente, nombre, celular FROM cliente WHERE correo=@correo AND contraseña=@contraseña";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.Read())
                    {
                        int idCliente = Convert.ToInt32(lector["id_cliente"]);
                        string nombre = lector["nombre"].ToString();
                        string celular = lector.IsDBNull(lector.GetOrdinal("celular")) ? "" : lector["celular"].ToString();

                        MessageBox.Show($"Bienvenido, {nombre}", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Guardar sesión
                        Sesion.Correo = correo;
                        Sesion.Nombre = nombre;
                        Sesion.IdCliente = idCliente;
                        Sesion.Celular = celular;

                        this.Hide();
                        mainForm.OpenChildFrom(new PanelUsuario());
                    }
                    else
                    {
                        MessageBox.Show("Correo o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.Show();
        }
    }
}