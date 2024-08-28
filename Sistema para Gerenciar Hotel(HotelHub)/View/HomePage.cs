using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Controller;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    public partial class HomePage : Form
    {
        FuncionarioController funcionarioController;
        ReservaController reservaController;
        ClienteController clienteController;
        public HomePage()
        {
            InitializeComponent();
            funcionarioController = new FuncionarioController();
            reservaController = new ReservaController();
            clienteController = new ClienteController();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {

        }
        private void CloseAllMdiChildren()
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que você deseja sair?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMdiChildren();
            ReservaPage tela = new ReservaPage(reservaController);
            tela.MdiParent = this;
            tela.Show();
            pictureBox1.Hide();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMdiChildren();
            FuncionarioPage telafunc = new FuncionarioPage(funcionarioController);
            telafunc.MdiParent = this;
            telafunc.Show();
            pictureBox1.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMdiChildren();
            ClientePage telaclient = new ClientePage(clienteController);
            telaclient.MdiParent = this;
            telaclient.Show();
            pictureBox1.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/victorjqm543?igsh=MXVoanBqejQ3MDVxbg==",
                UseShellExecute = true
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/eureinaldodias?igsh=dGxmbmtkNDBlcG9o&utm_source=qr",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/kaua_nogs",
                UseShellExecute = true
            });
        }
    }
}
