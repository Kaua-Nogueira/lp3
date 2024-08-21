using System;
using System.Windows.Forms;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model;

namespace Hotelhub
{
    public partial class CadastroFuncControl : UserControl
    {
        private FuncionarioController funcionarioController;
        private Funcionario funcionario;
        private bool isEdit = false;

        // Define um evento para notificar quando o cadastro for realizado
        public event EventHandler CadastroRealizado;
        public event EventHandler AtualizarRealizado;

        public CadastroFuncControl(FuncionarioController controller)
        {
            InitializeComponent();
            funcionarioController = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(tb_nome.Text) ||
                string.IsNullOrWhiteSpace(tb_sobrenome.Text) ||
                string.IsNullOrWhiteSpace(tb_cpf.Text) ||
                string.IsNullOrWhiteSpace(tb_email.Text) ||
                (!rb_solteiro.Checked && !rb_casado.Checked && !rb_divorciado.Checked && !rb_viuvo.Checked))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Coleta os dados dos campos
            var funcionario = new Funcionario
            {
                Name = tb_nome.Text,
                Sobrenome = tb_sobrenome.Text,
                CPF = tb_cpf.Text,
                email = tb_email.Text,
                dataNasc = datetp_nasc.Value
            };

            // Determina o estado civil
            if (rb_solteiro.Checked) funcionario.estadoCivil = "Solteiro";
            else if (rb_casado.Checked) funcionario.estadoCivil = "Casado";
            else if (rb_divorciado.Checked) funcionario.estadoCivil = "Divorciado";
            else if (rb_viuvo.Checked) funcionario.estadoCivil = "Viúvo";

            try
            {
                // Adiciona o funcionário
                if (isEdit)
                {
                    funcionario.Id = this.funcionario.Id;
                    funcionarioController.AtualizarFuncionario(funcionario);
                    MessageBox.Show("Funcionário atualizado com sucesso!");
                    // Limpa os campos após o cadastro
                    LimparCampos();

                    // Dispara o evento de atualização realizado
                    AtualizarRealizado?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    funcionarioController.AdicionarFuncionario(funcionario);
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                    // Limpa os campos após o cadastro
                    LimparCampos();

                    // Dispara o evento de cadastro realizado
                    CadastroRealizado?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar funcionário: {ex.Message}");
            }
        }

        private void LimparCampos()
        {
            tb_nome.Clear();
            tb_sobrenome.Clear();
            tb_cpf.Clear();
            tb_email.Clear();
            datetp_nasc.Value = DateTime.Now;
            rb_solteiro.Checked = false;
            rb_casado.Checked = false;
            rb_divorciado.Checked = false;
            rb_viuvo.Checked = false;
        }

        public void editar(Funcionario funcionario)
        {
            this.funcionario = funcionario;
            isEdit = true;
            tb_cpf.Text = funcionario.CPF;
            tb_email.Text = funcionario.email;
            tb_nome.Text = funcionario.Name;
            tb_sobrenome.Text = funcionario.Sobrenome;
            datetp_nasc.Value = funcionario.dataNasc;

            switch (funcionario.estadoCivil)
            {
                case "Solteiro":
                    rb_solteiro.Checked = true;
                    break;
                case "Casado":
                    rb_casado.Checked = true;
                    break;
                case "Divorciado":
                    rb_divorciado.Checked = true;
                    break;
                case "Viúvo":
                    rb_viuvo.Checked = true;
                    break;
                default:
                    rb_solteiro.Checked = false;
                    rb_casado.Checked = false;
                    rb_divorciado.Checked = false;
                    rb_viuvo.Checked = false;
                    break;
            }
        }
    }
}