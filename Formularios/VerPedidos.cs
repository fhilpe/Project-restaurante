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
    public partial class VerPedidos : Form
    {
        public VerPedidos()
        {
            InitializeComponent();
        }

        private void VerPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = PedidoDAL.MostrarPedidosPorCliente(Sesion.IdCliente);
            if (dgvPedidos.Columns.Count > 0)
            {
                dgvPedidos.Columns["IdPedido"].Visible = false;
                dgvPedidos.Columns["IdCliente"].Visible = false;
            }
        }      

    }
}
