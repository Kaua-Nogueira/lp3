using System;
using System.Windows.Forms;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    public partial class CadastrarReservasControl : UserControl
    {
        private ReservaController reservaController;
        private Reserva reserva;
        private bool isEdit = false;

        // Define um evento para notificar quando o cadastro for realizado
        public event EventHandler CadastroRealizado;
        public event EventHandler AtualizarRealizado;
        Cliente cliente;

        public CadastrarReservasControl(ReservaController controller)
        {
            InitializeComponent();
            reservaController = controller;

            cliente = new Cliente
            {
                Id = 1,
                Nome = "João Silva",
                Cpf = "123.456.789-00",
                Email = "joao.silva@example.com",
                DataNascimento = new DateTime(1990, 1, 1)
            };
        }

        private void CadastrarReservasControl_Load(object sender, EventArgs e)
        {
            // Definir DisplayMember para exibir o nome do cliente
            comboBox1.DisplayMember = "Nome";
            // Adicionar cliente ao ComboBox
            comboBox1.Items.Add(cliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos estão preenchidos
            if (comboBox1.SelectedItem == null ||
                numericUpDown1.Value <= 0 ||
                numericUpDown2.Value <= 0 ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Coleta os dados dos campos
            Reserva reserva = new Reserva
            {
                cliente = (Cliente)comboBox1.SelectedItem,
                dataInicio = dateTimePicker1.Value,
                dataFim = dateTimePicker2.Value,
                valorReserva = double.Parse(textBox1.Text),
                numHospedes = (int)numericUpDown1.Value,
                numQuartos = (int)numericUpDown2.Value
            };

            try
            {
                // Adiciona a reserva
                if (isEdit)
                {
                    reserva.Id = this.reserva.Id;
                    reservaController.AtualizarReserva(reserva);
                    MessageBox.Show("Reserva atualizada com sucesso!");
                    // Limpa os campos após o cadastro
                    LimparCampos();

                    // Dispara o evento de atualização realizado
                    AtualizarRealizado?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    reservaController.AdicionarReserva(reserva);
                    MessageBox.Show("Reserva cadastrada com sucesso!");
                    // Limpa os campos após o cadastro
                    LimparCampos();

                    // Dispara o evento de cadastro realizado
                    CadastroRealizado?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar reserva: {ex.Message}");
            }
        }

        private void LimparCampos()
        {
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        public void editar(Reserva reserva)
        {
            this.reserva = reserva;
            isEdit = true;
            comboBox1.SelectedItem = reserva.cliente;
            dateTimePicker1.Value = reserva.dataInicio;
            dateTimePicker2.Value = reserva.dataFim;
            numericUpDown1.Value = reserva.numHospedes;
            numericUpDown2.Value = reserva.numQuartos;
            textBox1.Text = reserva.valorReserva.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pode ser usado para outro botão, se necessário
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Pode ser usado para manipular cliques no label, se necessário
        }
    }
}
