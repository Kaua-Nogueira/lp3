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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
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
            // button1
            // 
            button1.Location = new Point(33, 159);
            button1.Name = "button1";
            button1.Size = new Size(112, 40);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 205);
            button2.Name = "button2";
            button2.Size = new Size(112, 40);
            button2.TabIndex = 2;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 251);
            button3.Name = "button3";
            button3.Size = new Size(112, 40);
            button3.TabIndex = 3;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(175, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 377);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.Location = new Point(33, 370);
            button4.Name = "button4";
            button4.Size = new Size(112, 40);
            button4.TabIndex = 5;
            button4.Text = "Voltar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FuncionarioPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 226, 215);
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "FuncionarioPage";
            Text = "FuncionarioPage";
            Load += FuncionarioPage_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button button4;
    }
}