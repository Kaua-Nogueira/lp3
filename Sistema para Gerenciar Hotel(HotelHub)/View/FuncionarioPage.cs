using System;
using System.Drawing;
using System.Windows.Forms;
using Hotelhub;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model;
using Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    public partial class FuncionarioPage : Form
    {
        public FuncionarioController funcionarioController;
        private AtualizarFunc table;

        public FuncionarioPage(FuncionarioController controller)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            funcionarioController = controller;

            table = tabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setEnableButtons(false);
            CadastroFuncControl func = new CadastroFuncControl(funcionarioController);
            func.CadastroRealizado += restoreTable; // Inscreve-se no evento

            panel1.Controls.Clear();
            func.Dock = DockStyle.Fill;
            panel1.Controls.Add(func);
        }

        private void restoreTable(object sender, EventArgs e)
        {
            // Retorna ao controle anterior ou à tela principal
            panel1.Controls.Clear();
            table = tabela(); // Adiciona a tabela de volta ao painel
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int funAtualizar = table.getFuncionarioId();

            if (funAtualizar != 0)
            {
                AtualizarFunc_edicao(funAtualizar);
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado", "warning");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            table = tabela();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private AtualizarFunc tabela()
        {
            if (funcionarioController.ListarFuncionarios().Count == 0)
            {
                setEnableButtons(false);
            }
            else
            {
                setEnableButtons(true);
            }
            AtualizarFunc Upfunc = new AtualizarFunc(funcionarioController);
            // Inscreve-se no evento de edição
            // Upfunc.edicao += AtualizarFunc_edicao;
            panel1.Controls.Clear();
            Upfunc.Dock = DockStyle.Fill;
            panel1.Controls.Add(Upfunc);

            return Upfunc;
        }

        private void FuncionarioPage_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarFunc_edicao(int funcionarioId)
        {
            Funcionario funcionario = funcionarioController.BuscarFuncionarioPorId(funcionarioId);
            // Cria uma nova instância de CadastroFuncControl
            CadastroFuncControl cadastroFuncControl = new CadastroFuncControl(funcionarioController);

            cadastroFuncControl.AtualizarRealizado += restoreTable;

            // Preenche os campos de cadastro com os dados do funcionário selecionado
            cadastroFuncControl.editar(funcionario);

            // Limpa o painel e adiciona o controle de cadastro
            panel1.Controls.Clear();
            cadastroFuncControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(cadastroFuncControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int funAtualizar = table.getFuncionarioId();

            if (funAtualizar != 0)
            {
                DialogResult result = MessageBox.Show("Você deseja excluir o funcionário?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    funcionarioController.RemoverFuncionario(funAtualizar);
                    panel1.Controls.Clear();
                    table = tabela();
                }
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado", "warning");
            }
        }

        private void setEnableButtons(bool enable)
        {
            button2.Enabled = enable;
            button3.Enabled = enable;
        }

        private void FuncionarioPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
