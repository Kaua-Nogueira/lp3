using Hotelhub;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model;
using Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls;
using Sistema_para_Gerenciar_Hotel_HotelHub_.View.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    public partial class ClientePage : Form
    {
        public ClienteController clientecontroller;
        private AtualizarCliente table;

        public ClientePage(ClienteController clientecontrol)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            this.clientecontroller = clientecontrol;

            table = tabela();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            setenablebuttons(false);
            cadastroCliente clientcad = new cadastroCliente(clientecontroller);
            clientcad.CadastroRealizado += restoreTable;

            panelCliente.Controls.Clear();
            clientcad.Dock = DockStyle.Fill;//Ajusta o conteúdo dentro do contêiner
            panelCliente.Controls.Add(clientcad);
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            int CliAtualizar = table.getClienteId();

            if (CliAtualizar != 0)
            {
                AtualizarFunc_edicao(CliAtualizar);
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado", "warning");
            }

        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            int CliDeletar = table.getClienteId();
            if (CliDeletar != 0)
            {
                if (clientecontroller.RemoverCliente(CliDeletar))
                {
                    MessageBox.Show("Cliente excluído com sucesso!");
                    table.CarregarDados();

                }
                else
                {
                    MessageBox.Show("Erro ao remover cliente");
                }

            }
            else
            {
                MessageBox.Show("Nenhum Cliente selecionado", "warning");
            }
        }


        private void setenablebuttons(bool enable)
        {
            btAtualizar.Enabled = enable;
            btExcluir.Enabled = enable;
        }
        private AtualizarCliente tabela()
        {
            if (clientecontroller.Listarclientes().Count == 0)
            {
                setenablebuttons(false);
            }
            else
            {
                setenablebuttons(true);
            }
            AtualizarCliente UpCli = new AtualizarCliente(clientecontroller);
            // Inscreve-se no evento de edição
            // UpCli.edicao += AtualizarFunc_edicao;
            panelCliente.Controls.Clear();
            UpCli.Dock = DockStyle.Fill;
            panelCliente.Controls.Add(UpCli);

            return UpCli;
        }
        private void AtualizarFunc_edicao(int clienteId)
        {
            //Campos a serem resgatados
            int id;
            String nome, sobrenome, cpf, email, telefone, estadoCivil;
            DateTime dataNascimento;

            id = clientecontroller.BuscarClientePorId(clienteId).Id;
            nome = clientecontroller.BuscarClientePorId(clienteId).Nome;
            sobrenome = clientecontroller.BuscarClientePorId(clienteId).Sobrenome;
            cpf = clientecontroller.BuscarClientePorId(clienteId).Cpf;
            email = clientecontroller.BuscarClientePorId(clienteId).Email;
            telefone = clientecontroller.BuscarClientePorId(clienteId).Telefone;
            dataNascimento = clientecontroller.BuscarClientePorId(clienteId).DataNascimento;
            estadoCivil = clientecontroller.BuscarClientePorId(clienteId).EstadoCivil;

            // Cria uma nova instância de CadastroFuncControl
            cadastroCliente cadastrocliente = new cadastroCliente(clientecontroller);

            cadastrocliente.AtualizarRealizado += restoreTable;

            // Preenche os campos de cadastro com os dados do cliente selecionado
            cadastrocliente.editar(id, nome, sobrenome, cpf, email, telefone, dataNascimento, estadoCivil);

            // Limpa o painel e adiciona o controle de cadastro
            panelCliente.Controls.Clear();
            cadastrocliente.Dock = DockStyle.Fill;
            panelCliente.Controls.Add(cadastrocliente);
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
    }
}
