using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebadiseño
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/fhilpe/Project-restaurante.git";

            try
            {
                // Abre la URL con el navegador predeterminado
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la página: " + ex.Message);
            }
        }
    }
}
