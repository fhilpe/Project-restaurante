using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebadiseño;
using pruebadiseño.Formularios;

namespace pruebadiseño.Formularios
{
    public partial class OlvidarPassword : Form
    {
        public OlvidarPassword()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string email = txtCorreo.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Ingrese su correo.");
                return;
            }

            // Generar código
            Random rnd = new Random();
            string code = rnd.Next(100000, 999999).ToString();

            // Guardar en DB
            using (SqlConnection c = General.obtenerConexion())
            {
                string q = "INSERT INTO password_reset (email, token, expires) VALUES (@e, @t, @ex)";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@t", code);
                cmd.Parameters.AddWithValue("@ex", DateTime.Now.AddMinutes(10));
                cmd.ExecuteNonQuery();
            }

            // Enviar email
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("test.notifications29@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Código de Restablecimiento";
                mail.Body = $"Tu código es: {code}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("test.notifications29@gmail.com", "ouwj ipnx hpqa wwan");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Código enviado.");
                new ResetPassword(email).Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // fin
    }
}
