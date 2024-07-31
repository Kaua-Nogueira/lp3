namespace Hotelhub
{
    partial class CadastroFuncControl
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
            tb_sobrenome = new TextBox();
            tb_nome = new TextBox();
            groupBox1 = new GroupBox();
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
            label4 = new Label();
            tb_cpf = new TextBox();
            tb_email = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_sobrenome
            // 
            tb_sobrenome.Location = new Point(96, 70);
            tb_sobrenome.Name = "tb_sobrenome";
            tb_sobrenome.Size = new Size(193, 23);
            tb_sobrenome.TabIndex = 18;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(96, 34);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(193, 23);
            tb_nome.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_viuvo);
            groupBox1.Controls.Add(rb_solteiro);
            groupBox1.Controls.Add(rb_divorciado);
            groupBox1.Controls.Add(rb_casado);
            groupBox1.Location = new Point(324, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 146);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado Civil";
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
            datetp_nasc.Location = new Point(22, 221);
            datetp_nasc.Name = "datetp_nasc";
            datetp_nasc.Size = new Size(249, 23);
            datetp_nasc.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 147);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 14;
            label5.Text = "E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 203);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 13;
            label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 73);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 12;
            label2.Text = "Sobrenome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "Nome";
            // 
            // button1
            // 
            button1.Location = new Point(449, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 10;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 108);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 19;
            label4.Text = "CPF";
            // 
            // tb_cpf
            // 
            tb_cpf.Location = new Point(96, 107);
            tb_cpf.Name = "tb_cpf";
            tb_cpf.Size = new Size(193, 23);
            tb_cpf.TabIndex = 20;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(96, 144);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(193, 23);
            tb_email.TabIndex = 21;
            // 
            // CadastroFuncControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 226, 215);
            Controls.Add(tb_email);
            Controls.Add(tb_cpf);
            Controls.Add(label4);
            Controls.Add(tb_sobrenome);
            Controls.Add(tb_nome);
            Controls.Add(groupBox1);
            Controls.Add(datetp_nasc);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "CadastroFuncControl";
            Size = new Size(560, 360);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_sobrenome;
        private TextBox tb_nome;
        private GroupBox groupBox1;
        private DateTimePicker datetp_nasc;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private RadioButton rb_viuvo;
        private RadioButton rb_solteiro;
        private RadioButton rb_divorciado;
        private RadioButton rb_casado;
        private Label label4;
        private TextBox tb_cpf;
        private TextBox tb_email;
    }
}
