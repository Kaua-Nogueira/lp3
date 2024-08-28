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
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.Classesforview;
using Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    public partial class ReservaPage : Form
    {
        ReservaController reservaController;
        AtualizarReserva table;

        public ReservaPage(ReservaController controller)
        {
            InitializeComponent();
            reservaController = controller;


            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            

            table = tabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            setEnableButtons(false);
            CadastrarReservasControl cadRes = new CadastrarReservasControl(reservaController);
            cadRes.Show();

            cadRes.CadastroRealizado += restoreTable; // Inscreve-se no evento

            panel1.Controls.Clear();
            cadRes.Dock = DockStyle.Fill;
            panel1.Controls.Add(cadRes);

        }

        private void restoreTable(object sender, EventArgs e)
        {
            // Retorna ao controle anterior ou à tela principal
            panel1.Controls.Clear();
            table = tabela(); // Adiciona a tabela de volta ao painel
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int resAtualizar = table.getReservaId();

            if (resAtualizar != 0)
            {
                DialogResult result = MessageBox.Show("Você deseja excluir a reserva?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    reservaController.RemoverReserva(resAtualizar);
                    panel1.Controls.Clear();
                    table = tabela();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma reserva selecionada", "warning");
            }
        }

        private void setEnableButtons(bool enable)
        {
            btAtualizar.Enabled = enable;
            btExcluir.Enabled = enable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ResAtualizar = table.getReservaId();

            if (ResAtualizar != 0)
            {
                AtualizarRes_edicao(ResAtualizar);
            }
            else
            {
                MessageBox.Show("Nenhuma reserva selecionada", "warning");
            }
        }

        private void AtualizarRes_edicao(int reservaId)
        {
            Reserva reserva = reservaController.BuscarReservaPorId(reservaId);
            // Cria uma nova instância de CadastroFuncControl
            CadastrarReservasControl cadastroResControl = new CadastrarReservasControl(reservaController);

            cadastroResControl.AtualizarRealizado += restoreTable;

            // Preenche os campos de cadastro com os dados do funcionário selecionado
            cadastroResControl.editar(reserva);

            // Limpa o painel e adiciona o controle de cadastro
            panel1.Controls.Clear();
            cadastroResControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(cadastroResControl);
        }

        private AtualizarReserva tabela()
        {
            if (reservaController.ListarReservas().Count == 0)
            {
                setEnableButtons(false);
            }
            else
            {
                setEnableButtons(true);
            }
            AtualizarReserva Upfunc = new AtualizarReserva(reservaController);
            // Inscreve-se no evento de edição
            // Upfunc.edicao += AtualizarFunc_edicao;
            panel1.Controls.Clear();
            Upfunc.Dock = DockStyle.Fill;
            panel1.Controls.Add(Upfunc);

            return Upfunc;
        }

        private void ReservaPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
