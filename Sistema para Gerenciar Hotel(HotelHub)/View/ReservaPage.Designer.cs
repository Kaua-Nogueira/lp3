namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    partial class ReservaPage
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
            btVoltar = new Button();
            panel1 = new Panel();
            btExcluir = new Button();
            btAtualizar = new Button();
            btCadastrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(30, 368);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(112, 40);
            btVoltar.TabIndex = 11;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(172, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 377);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(30, 249);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(112, 40);
            btExcluir.TabIndex = 9;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += button3_Click;
            // 
            // btAtualizar
            // 
            btAtualizar.Location = new Point(30, 203);
            btAtualizar.Name = "btAtualizar";
            btAtualizar.Size = new Size(112, 40);
            btAtualizar.TabIndex = 8;
            btAtualizar.Text = "Atualizar";
            btAtualizar.UseVisualStyleBackColor = true;
            btAtualizar.Click += button2_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(30, 157);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(112, 40);
            btCadastrar.TabIndex = 7;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(30, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ReservaPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 226, 215);
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltar);
            Controls.Add(panel1);
            Controls.Add(btExcluir);
            Controls.Add(btAtualizar);
            Controls.Add(btCadastrar);
            Controls.Add(pictureBox1);
            Name = "ReservaPage";
            Text = "ReservaPage";
            Load += ReservaPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btVoltar;
        private Panel panel1;
        private Button btExcluir;
        private Button btAtualizar;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btCadastrar;
    }
}