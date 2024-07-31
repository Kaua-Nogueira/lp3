using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View.Controls
{
    public partial class AtualizarReservas : UserControl
    {
        public event EventHandler VoltarParaTelaDeReservas;
        public AtualizarReservas()
        {
            InitializeComponent();
        }

        private void AtualizarReservas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VoltarParaTelaDeReservas?.Invoke(this, EventArgs.Empty);
        }
    }
}
