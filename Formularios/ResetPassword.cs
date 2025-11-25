using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebadiseño;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pruebadiseño.Formularios
{
    public partial class ResetPassword : Form
    {
        private string email;
        public ResetPassword(string emailParam)
        {
            InitializeComponent();
            email = emailParam;
        }

        private void btnCambiar_Click_1(object sender, EventArgs e)
        {
            string code = txtCodigo.Text.Trim();
            string newPass = txtNuevaPassword.Text.Trim();
            string confirmarPassword = txtConfirmarPassword.Text.Trim();


            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (!ValidarContraseña(newPass))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, con mayúsculas, minúsculas y números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass != confirmarPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            using (SqlConnection c = General.obtenerConexion())
            {
                // Verificar código
                string q = "SELECT COUNT(*) FROM password_reset WHERE email=@e AND token=@t AND expires > GETDATE() AND used=0";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@t", code);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    // Verificar que email existe en cliente
                    string qCheck = "SELECT COUNT(*) FROM cliente WHERE correo=@e";
                    SqlCommand cmdCheck = new SqlCommand(qCheck, c);
                    cmdCheck.Parameters.AddWithValue("@e", email);
                    int clientCount = (int)cmdCheck.ExecuteScalar();

                    if (clientCount == 0)
                    {
                        MessageBox.Show("Email no registrado.");
                        return;
                    }

                    // Cambiar password
                    string q2 = "UPDATE cliente SET contraseña=@p WHERE correo=@e";
                    SqlCommand cmd2 = new SqlCommand(q2, c);
                    cmd2.Parameters.AddWithValue("@p", newPass);
                    cmd2.Parameters.AddWithValue("@e", email);
                    int result = cmd2.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // Marcar usado
                        string q3 = "UPDATE password_reset SET used=1 WHERE email=@e AND token=@t";
                        SqlCommand cmd3 = new SqlCommand(q3, c);
                        cmd3.Parameters.AddWithValue("@e", email);
                        cmd3.Parameters.AddWithValue("@t", code);
                        cmd3.ExecuteNonQuery();

                        MessageBox.Show("Contraseña cambiada.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar contraseña.");
                    }
                }
                else
                {
                    MessageBox.Show("Código inválido o expirado.");
                }
            }
        }


        private bool ValidarContraseña(string pass)
        {
            return pass.Length >= 8 && pass.Any(char.IsUpper) && pass.Any(char.IsLower) && pass.Any(char.IsDigit);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNuevaPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtConfirmarPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }






        // fin
    }
}