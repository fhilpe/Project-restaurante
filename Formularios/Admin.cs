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
    public partial class Admin : Form
    {
        private Form currentChildForm;

        public Admin()
        {
            InitializeComponent();
        }

        public void OpenChildFromAdmin(Form ChildFrom)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildFrom;
            ChildFrom.TopLevel = false;
            ChildFrom.FormBorderStyle = FormBorderStyle.None;
            ChildFrom.Dock = DockStyle.Fill;
            panelPadreAdmin.Controls.Add(ChildFrom);
            panelPadreAdmin.Tag = ChildFrom;
            ChildFrom.BringToFront();
            ChildFrom.Show();
        }



        private void btnOpenBooking_Click(object sender, EventArgs e)
        {
            OpenChildFromAdmin(new AdminReservas());
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            OpenChildFromAdmin(new AdminReservas());
        }

        private void btnOpenUsers_Click(object sender, EventArgs e)
        {
            OpenChildFromAdmin(new AdminUsuarios());

        }

        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            OpenChildFromAdmin(new MenuAdmin());
        }

        private void btnOpenPedidos_Click(object sender, EventArgs e)
        {
            OpenChildFromAdmin(new AdminPedidos());
        }
    }
}
