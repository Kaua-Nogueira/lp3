using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls
{
    public partial class AtualizarReserva : UserControl
    {
        private ReservaController reservaController;
        public event EventHandler<Reserva> edicao;
        private int reservaId;
        public AtualizarReserva(ReservaController controller)
        {
            InitializeComponent();
            reservaController = controller;

            CarregarDados();
        }
        private void CarregarDados()
        {
            // Define a fonte de dados do DataGridView
            dataGridView1.DataSource = reservaController.ListarReservas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)  // Permite a seleção da primeira linha também
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];  // Usa o índice da linha clicada
                var reserva = (Reserva)selectedRow.DataBoundItem;
                this.reservaId = reserva.Id;

                MessageBox.Show("Identificador: " + reserva.Id, "Você selecionou uma reserva");  // Converte Id para string para exibir no MessageBox
            }
        }

        public int getReservaId()
        {
            return this.reservaId;
        }
    }
}
