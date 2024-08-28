using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotelhub;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls
{
    public partial class AtualizarFunc : UserControl
    {
        private FuncionarioController funcionarioController;
        public event EventHandler<Funcionario> edicao;
        private int funcionarioId;

        public AtualizarFunc(FuncionarioController controller)
        {
            InitializeComponent();
            funcionarioController = controller;

            // Carrega os dados ao inicializar o controle
            CarregarDados();
        }

        internal void CarregarDados()
        {
            // Define a fonte de dados do DataGridView
            List<Funcionario> source = funcionarioController.ListarFuncionarios();
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)  // Permite a seleção da primeira linha também
            {
               if(e.RowIndex >=0)
                {
                    var selectedRow = dataGridView1.Rows[e.RowIndex];  // Usa o índice da linha clicada
                    var funcionario = (Funcionario)selectedRow.DataBoundItem;
                    this.funcionarioId = funcionario.Id;

                    MessageBox.Show("Nome: " + funcionario.Name, "Você selecionou um funcionário");  // Converte Id para string para exibir no MessageBox
                }
            }
        }

        public int getFuncionarioId()
        {
            return this.funcionarioId;
        }

        private void AtualizarFunc_Load(object sender, EventArgs e)
        {

        }
    }
}
