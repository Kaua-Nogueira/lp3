using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.Classesforview;
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
    public partial class cadastroCliente : UserControl
    {
        private bool isEdit = false;
        ClienteController Clientecontroller = new ClienteController();

        //Armazenando Id para não perder
        int idinstancia = 0;

        //Eventos
        // Define um evento para notificar quando o cadastro for realizado
        public event EventHandler CadastroRealizado;
        public event EventHandler AtualizarRealizado;
        public cadastroCliente(ClienteController controller)
        {
            InitializeComponent();
            Clientecontroller = controller;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            //Verificar se todos os campos estão preenchidos corretamente
            if (string.IsNullOrEmpty(tb_nome.Text) ||
                string.IsNullOrEmpty(tb_sobrenome.Text) ||
                string.IsNullOrEmpty(tb_cpf.Text) ||
                string.IsNullOrEmpty(tb_email.Text) ||
                string.IsNullOrEmpty(tb_telefone.Text) ||
                (!rb_casado.Checked && !rb_divorciado.Checked &&
                !rb_solteiro.Checked && !rb_viuvo.Checked)) {
            
                MessageBox.Show("Todos os campos são Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }
            else
            {
                
                String estado_civil = "";
                if (rb_solteiro.Checked) estado_civil = "Solteiro";
                else if (rb_casado.Checked) estado_civil = "Casado";
                else if (rb_divorciado.Checked) estado_civil = "Divorciado";
                else if (rb_viuvo.Checked) estado_civil = "Viúvo";
               
                try
                {
                    if (isEdit)
                    {

                            if (Clientecontroller.atualizarcliente(idinstancia, tb_nome.Text, tb_sobrenome.Text, tb_cpf.Text, tb_email.Text,
                                                                   tb_telefone.Text, datetp_nasc.Value, estado_civil))
                        {
                            MessageBox.Show("Cliente editado com sucesso");
                            LimparCampos();
                            isEdit = false;

                            AtualizarRealizado?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao editar Cliente");
                        }
                        


                    }
                    else
                    {
                        if (Clientecontroller.adicionarCliente(tb_nome.Text, tb_sobrenome.Text, tb_cpf.Text, tb_email.Text,
                                                               tb_telefone.Text, datetp_nasc.Value, estado_civil))
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso");
                            LimparCampos();
                            CadastroRealizado?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar Cliente");
                        }
                        

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}");
                }

            }


        }
        private void LimparCampos()
        {
            tb_nome.Clear();
            tb_sobrenome.Clear();
            tb_cpf.Clear();
            tb_email.Clear();
            tb_telefone.Clear();
            datetp_nasc.Value = DateTime.Now;
            rb_solteiro.Checked = false;
            rb_casado.Checked = false;
            rb_divorciado.Checked = false;
            rb_viuvo.Checked = false;
        }
        public void editar(int id, string nome, string sobrenome, string cpf, string email, 
                           string telefone, DateTime dataNascimento, string estadoCivil)
        {

            isEdit = true;
            idinstancia = id;

            tb_cpf.Text = cpf;
            tb_email.Text = email;
            tb_nome.Text = nome;
            tb_sobrenome.Text = sobrenome;
            datetp_nasc.Value = dataNascimento;
            tb_telefone.Text = telefone;

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
