using System;
using System.Windows.Forms;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;

namespace Hotelhub
{
    public partial class CadastroFuncionario : UserControl
    {
        private bool isEdit = false;
        FuncionarioController funcionarioController = new FuncionarioController();

        //Armazenando Id para não perder
        int idinstancia = 0;

        //Eventos
        // Define um evento para notificar quando o cadastro for realizado
        public event EventHandler CadastroRealizado;
        public event EventHandler AtualizarRealizado;


        public CadastroFuncionario(FuncionarioController controller)
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

            String estado_civil = "";
            if (rb_solteiro.Checked) estado_civil = "Solteiro";
            else if (rb_casado.Checked) estado_civil = "Casado";
            else if (rb_divorciado.Checked) estado_civil = "Divorciado";
            else if (rb_viuvo.Checked) estado_civil = "Viúvo";

            try
            {
                // Adiciona o funcionário
                if (isEdit)
                {
                    if (funcionarioController.AtualizarFuncionario(idinstancia, tb_nome.Text, tb_sobrenome.Text, tb_cpf.Text, tb_email.Text,
                                                                  datetp_nasc.Value, estado_civil))
                    {
                        MessageBox.Show("Funcionario editado com sucesso");
                        LimparCampos();
                        isEdit = false;

                        AtualizarRealizado?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao editar Funcionario");

                    }
                    

                    
                }
                else
                {
                    if (funcionarioController.AdicionarFuncionario(tb_nome.Text, tb_sobrenome.Text, tb_cpf.Text, tb_email.Text,
                                                                  datetp_nasc.Value, estado_civil))
                    {
                        MessageBox.Show("Funcionario cadastrado com sucesso");
                        LimparCampos();
                        isEdit = false;

                        CadastroRealizado?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Funcionario");

                    }
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

        public void editar(int id, string nome, string sobrenome, string cpf, string email,
                           DateTime dataNascimento, string estadoCivil)
        {
            isEdit = true;
            idinstancia = id;

            tb_cpf.Text = cpf;
            tb_email.Text = email;
            tb_nome.Text = nome;
            tb_sobrenome.Text = sobrenome;
            datetp_nasc.Value = dataNascimento;

            switch (estadoCivil)
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