using Sistema_para_Gerenciar_Hotel_HotelHub_.Model;
using Sistema_para_Gerenciar_Hotel_HotelHub_.View;
using System;
using System.Windows.Forms;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_
{
    public partial class TelaLogin : Form
    {
        private Usuario funcionario;

        public TelaLogin()
        {
            InitializeComponent();
            funcionario = new Usuario("kaua", "123", "funcion�rio");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string senha = textBox2.Text;

            if (funcionario.getNome().Equals(nome) && funcionario.getSenha().Equals(senha))
            {
                DialogResult result = MessageBox.Show("Usu�rio logado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Verifica se o bot�o OK foi clicado
                if (result == DialogResult.OK)
                {
                    // Cria uma nova inst�ncia do pr�ximo formul�rio e o exibe
                    HomePage home = new HomePage();
                    home.Show();

                    // Esconde o formul�rio de login (ou use Close() para fechar)
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Nome ou senha incorretos.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
