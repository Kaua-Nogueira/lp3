namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    partial class FuncionarioPage
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
            panelCliente = new Panel();
            btVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(33, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(33, 159);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(112, 40);
            btCadastrar.TabIndex = 1;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(33, 205);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Size = new Size(112, 40);
            btAtualizar.TabIndex = 2;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += btAtualizar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(33, 251);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(112, 40);
            btExcluir.TabIndex = 3;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // panelCliente
            // 
            panelCliente.Location = new Point(175, 33);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(543, 377);
            panelCliente.TabIndex = 4;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(33, 370);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(112, 40);
            btVoltar.TabIndex = 5;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // FuncionarioPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 226, 215);
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltar);
            Controls.Add(panelCliente);
            Controls.Add(btExcluir);
            Controls.Add(btAtualizar);
            Controls.Add(btCadastrar);
            Controls.Add(pictureBox1);
            Name = "FuncionarioPage";
            Load += FuncionarioPage_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btCadastrar;
        private Button btAtualizar;
        private Button btExcluir;
        private Panel panelCliente;
        private Button btVoltar;
    }
}