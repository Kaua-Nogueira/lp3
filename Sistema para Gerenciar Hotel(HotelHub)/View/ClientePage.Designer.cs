namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    partial class ClientePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btCadastrar = new Button();
            btAtualizar = new Button();
            btExcluir = new Button();
            btVoltar = new Button();
            panelCliente = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(28, 153);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(112, 40);
            btCadastrar.TabIndex = 2;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(28, 199);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Size = new Size(112, 40);
            btAtualizar.TabIndex = 3;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += btAtualizar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(28, 245);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(112, 40);
            btExcluir.TabIndex = 4;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(28, 372);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(112, 40);
            btVoltar.TabIndex = 6;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // panelCliente
            // 
            panelCliente.Location = new Point(172, 35);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(543, 377);
            panelCliente.TabIndex = 7;
            panelCliente.Paint += panel1_Paint;
            // 
            // ClientePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 226, 215);
            ClientSize = new Size(800, 450);
            Controls.Add(panelCliente);
            Controls.Add(btVoltar);
            Controls.Add(btExcluir);
            Controls.Add(btAtualizar);
            Controls.Add(btCadastrar);
            Controls.Add(pictureBox1);
            Name = "ClientePage";
            Text = "ClientePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btCadastrar;
        private Button btAtualizar;
        private Button btExcluir;
        private Button btVoltar;
        private Panel panelCliente;
    }
}