using Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls;
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
    public partial class TelaDeReservas : Form
    {
        public TelaDeReservas()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarReservasControl Control = new CadastrarReservasControl();

            panel1.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panel1.Controls.Add(Control);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoverReservasControl Control = new RemoverReservasControl();

            panel1.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panel1.Controls.Add(Control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarReservas Control = new AtualizarReservas();
            Control.VoltarParaTelaDeReservas += Control_VoltarParaTelaDeReservas;

            panel1.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panel1.Controls.Add(Control);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarReservasControl Control = new ConsultarReservasControl();

            panel1.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panel1.Controls.Add(Control);
        }

        private void Control_VoltarParaTelaDeReservas(object sender, EventArgs e)
        {
            // Remova o controle atual e volte para a tela de reservas
            panel1.Controls.Clear();
            this.Show();
        }
    }
}
