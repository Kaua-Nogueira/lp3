using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View.User_Controls
{
    public partial class AtualizarCliente : UserControl
    {
        private ClienteController Clientecontroller;
        public event EventHandler<Cliente> edicao;
        private int clienteId;

        public AtualizarCliente(ClienteController controller)
        {
            InitializeComponent();
            this.Clientecontroller = controller;

            CarregarDados();

        }
        internal void CarregarDados()
        {
            // Define a fonte de dados do DataGridView
            List<Cliente> source = Clientecontroller.Listarclientes();
            dataGridView2.DataSource = source;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count >= 0)  // Permite a seleção da primeira linha também
            {
                if(e.RowIndex >=0)
                {
                    var selectedRow = dataGridView2.Rows[e.RowIndex];  // Usa o índice da linha clicada
                    var cliente = (Cliente)selectedRow.DataBoundItem;
                    this.clienteId = cliente.Id;

                    MessageBox.Show("Nome: " + cliente.Nome, "Você selecionou um Cliente");  // Converte Id para string para exibir no MessageBox
                }
            }
            else
            {
                MessageBox.Show("numero de cliente cadastrado é 0");
            }
        }
        public int getClienteId()
        {
            return this.clienteId;
        }
        

    }
}
