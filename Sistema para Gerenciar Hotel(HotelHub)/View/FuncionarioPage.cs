using System;
using System.Drawing;
using System.Windows.Forms;
using Hotelhub;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    public partial class FuncionarioPage : Form
    {
        public FuncionarioController funcionarioController;
        private AtualizarFunc table;


        public FuncionarioPage(FuncionarioController funcionarioControl)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            this.funcionarioController = funcionarioControl;

            table = tabela();
        }

        
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            setenablebuttons(false);
            CadastroFuncionario funcCad = new CadastroFuncionario(funcionarioController);
            funcCad.CadastroRealizado += restoreTable;

            panelCliente.Controls.Clear();
            funcCad.Dock = DockStyle.Fill; // Ajusta o conteúdo dentro do contêiner
            panelCliente.Controls.Add(funcCad);
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            int funcAtualizar = table.getFuncionarioId();

            if (funcAtualizar != 0)
            {
                AtualizarFunc_edicao(funcAtualizar);
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado", "Aviso");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int funcDeletar = table.getFuncionarioId();
            if (funcDeletar != 0)
            {
                if (funcionarioController.RemoverFuncionario(funcDeletar))
                {
                    MessageBox.Show("Funcionário excluído com sucesso");
                    table.CarregarDados();

                }
                else
                {
                    MessageBox.Show("Erro ao remover funcionário");
                }
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado", "Aviso");
            }
        }

        private void setenablebuttons(bool enable)
        {
            btAtualizar.Enabled = enable;
            btExcluir.Enabled = enable;
        }

        private AtualizarFunc tabela()
        {
            if (funcionarioController.ListarFuncionarios().Count == 0)
            {
                setenablebuttons(false);
            }
            else
            {
                setenablebuttons(true);
            }
            AtualizarFunc UpFunc = new AtualizarFunc(funcionarioController);

            panelCliente.Controls.Clear();
            UpFunc.Dock = DockStyle.Fill;
            panelCliente.Controls.Add(UpFunc);

            return UpFunc;
        }

        private void AtualizarFunc_edicao(int funcionarioId)
        {
            // Campos a serem resgatados
            int id;
            String nome, sobrenome, cpf, email, estadoCivil;
            DateTime dataNascimento;

            var funcionario = funcionarioController.BuscarFuncionarioPorId(funcionarioId);
            id = funcionario.Id;
            nome = funcionario.Nome;
            sobrenome = funcionario.Sobrenome;
            cpf = funcionario.Cpf;
            email = funcionario.Email;
            dataNascimento = funcionario.DataNascimento;
            estadoCivil = funcionario.EstadoCivil;

            // Cria uma nova instância de cadastroFuncionario
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario(funcionarioController);

            cadastroFuncionario.AtualizarRealizado += restoreTable;

            // Preenche os campos de cadastro com os dados do funcionário selecionado
            cadastroFuncionario.editar(id, nome, sobrenome, cpf, email, dataNascimento, estadoCivil);

            // Limpa o painel e adiciona o controle de cadastro
            panelCliente.Controls.Clear();
            cadastroFuncionario.Dock = DockStyle.Fill;
            panelCliente.Controls.Add(cadastroFuncionario);
        }

        private void restoreTable(object sender, EventArgs e)
        {
            // Retorna ao controle anterior ou à tela principal
            panelCliente.Controls.Clear();
            table = tabela(); // Adiciona a tabela de volta ao painel
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            panelCliente.Controls.Clear();
            table = tabela();
        }
        private void FuncionarioPage_Load_1(object sender, EventArgs e)
        {

        }
    }

}
