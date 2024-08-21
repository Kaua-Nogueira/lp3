namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View
{
    partial class CadastrarReservasControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(34, 35);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Selecionar cliente :";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(191, 27);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 23);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(34, 70);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 4;
            label3.Text = "Data de entrada :";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 64);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(34, 107);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 6;
            label4.Text = "Data de saida :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(191, 99);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(260, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(34, 137);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 8;
            label5.Text = "Número de Hóspedes : ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(192, 135);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(34, 172);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 10;
            label6.Text = "Número de Quartos :";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(192, 170);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(131, 23);
            numericUpDown2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(34, 208);
            label7.Name = "label7";
            label7.Size = new Size(129, 15);
            label7.TabIndex = 12;
            label7.Text = " Valor Total da Reserva :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 205);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(427, 249);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 16;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastrarReservasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 226, 215);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(numericUpDown2);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastrarReservasControl";
            Size = new Size(700, 311);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            Load += CadastrarReservasControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private TextBox textBox1;
        private Button button1;
    }
}
