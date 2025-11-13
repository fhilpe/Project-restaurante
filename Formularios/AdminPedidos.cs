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
    public partial class AdminPedidos : Form
    {
        public AdminPedidos()
        {
            InitializeComponent();
        }

        private void AdminPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = PedidoDAL.MostrarTodosPedidos();
            cbEstado.Items.Add("Pendiente");
            cbEstado.Items.Add("Preparando");
            cbEstado.Items.Add("Listo");
            cbEstado.Items.Add("Entregado");
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null || cbEstado.SelectedItem == null) return;
            int idPedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells[0].Value);
            string estado = cbEstado.SelectedItem.ToString();
            PedidoDAL.ActualizarEstadoPedido(idPedido, estado);
            MessageBox.Show("Estado actualizado");
            dgvPedidos.DataSource = PedidoDAL.MostrarTodosPedidos();
        }



        // fin
    }
}

