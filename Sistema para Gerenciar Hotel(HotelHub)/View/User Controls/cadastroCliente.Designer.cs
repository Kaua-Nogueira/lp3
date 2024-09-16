
namespace Sistema_para_Gerenciar_Hotel_HotelHub_.View.User_Controls
{
    partial class cadastroCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_email = new TextBox();
            tb_cpf = new TextBox();
            label4 = new Label();
            tb_sobrenome = new TextBox();
            tb_nome = new TextBox();
            gb_estadocivil = new GroupBox();
            rb_viuvo = new RadioButton();
            rb_solteiro = new RadioButton();
            rb_divorciado = new RadioButton();
            rb_casado = new RadioButton();
            datetp_nasc = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            tb_telefone = new TextBox();
            gb_estadocivil.SuspendLayout();
            SuspendLayout();
            // 
            // tb_email
            // 
            tb_email.Location = new Point(104, 139);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(193, 23);
            tb_email.TabIndex = 33;
            // 
            // tb_cpf
            // 
            tb_cpf.Location = new Point(104, 102);
            tb_cpf.Name = "tb_cpf";
            tb_cpf.Size = new Size(193, 23);
            tb_cpf.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 103);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 31;
            label4.Text = "CPF";
            // 
            // tb_sobrenome
            // 
            tb_sobrenome.Location = new Point(104, 65);
            tb_sobrenome.Name = "tb_sobrenome";
            tb_sobrenome.Size = new Size(193, 23);
            tb_sobrenome.TabIndex = 30;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(104, 29);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(193, 23);
            tb_nome.TabIndex = 29;
            // 
            // gb_estadocivil
            // 
            gb_estadocivil.Controls.Add(rb_viuvo);
            gb_estadocivil.Controls.Add(rb_solteiro);
            gb_estadocivil.Controls.Add(rb_divorciado);
            gb_estadocivil.Controls.Add(rb_casado);
            gb_estadocivil.Location = new Point(332, 21);
            gb_estadocivil.Name = "gb_estadocivil";
            gb_estadocivil.Size = new Size(200, 146);
            gb_estadocivil.TabIndex = 28;
            gb_estadocivil.TabStop = false;
            gb_estadocivil.Text = "Estado Civil";
            // 
            // rb_viuvo
            // 
            rb_viuvo.AutoSize = true;
            rb_viuvo.Location = new Point(6, 107);
            rb_viuvo.Name = "rb_viuvo";
            rb_viuvo.Size = new Size(55, 19);
            rb_viuvo.TabIndex = 3;
            rb_viuvo.TabStop = true;
            rb_viuvo.Text = "Viúvo";
            rb_viuvo.UseVisualStyleBackColor = true;
            // 
            // rb_solteiro
            // 
            rb_solteiro.AutoSize = true;
            rb_solteiro.Location = new Point(6, 82);
            rb_solteiro.Name = "rb_solteiro";
            rb_solteiro.Size = new Size(65, 19);
            rb_solteiro.TabIndex = 2;
            rb_solteiro.TabStop = true;
            rb_solteiro.Text = "Solteiro";
            rb_solteiro.UseVisualStyleBackColor = true;
            // 
            // rb_divorciado
            // 
            rb_divorciado.AutoSize = true;
            rb_divorciado.Location = new Point(6, 57);
            rb_divorciado.Name = "rb_divorciado";
            rb_divorciado.Size = new Size(82, 19);
            rb_divorciado.TabIndex = 1;
            rb_divorciado.TabStop = true;
            rb_divorciado.Text = "Divorciado";
            rb_divorciado.UseVisualStyleBackColor = true;
            // 
            // rb_casado
            // 
            rb_casado.AutoSize = true;
            rb_casado.Location = new Point(6, 32);
            rb_casado.Name = "rb_casado";
            rb_casado.Size = new Size(64, 19);
            rb_casado.TabIndex = 0;
            rb_casado.TabStop = true;
            rb_casado.Text = "Casado";
            rb_casado.UseVisualStyleBackColor = true;
            // 
            // datetp_nasc
            // 
            datetp_nasc.Location = new Point(30, 266);
            datetp_nasc.Name = "datetp_nasc";
            datetp_nasc.Size = new Size(249, 23);
            datetp_nasc.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 142);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 26;
            label5.Text = "E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 239);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 25;
            label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 68);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 24;
            label2.Text = "Sobrenome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 23;
            label1.Text = "Nome";
            // 
            // button1
            // 
            button1.Location = new Point(457, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 22;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 182);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 34;
            label6.Text = "Telefone";
            // 
            // tb_telefone
            // 
            tb_telefone.Location = new Point(104, 179);
            tb_telefone.Name = "tb_telefone";
            tb_telefone.Size = new Size(193, 23);
            tb_telefone.TabIndex = 35;
            // 
            // cadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 226, 215);
            Controls.Add(tb_telefone);
            Controls.Add(label6);
            Controls.Add(tb_email);
            Controls.Add(tb_cpf);
            Controls.Add(label4);
            Controls.Add(tb_sobrenome);
            Controls.Add(tb_nome);
            Controls.Add(gb_estadocivil);
            Controls.Add(datetp_nasc);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "cadastroCliente";
            Size = new Size(560, 360);
            gb_estadocivil.ResumeLayout(false);
            gb_estadocivil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox tb_email;
        private TextBox tb_cpf;
        private Label label4;
        private TextBox tb_sobrenome;
        private TextBox tb_nome;
        private GroupBox groupBox1;
        private RadioButton rb_viuvo;
        private RadioButton rb_solteiro;
        private RadioButton rb_divorciado;
        private RadioButton rb_casado;
        private DateTimePicker datetp_nasc;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label6;
        private TextBox textBox1;
        private TextBox tb_telefone;
        private GroupBox gb_estadocivil;
    }
}
