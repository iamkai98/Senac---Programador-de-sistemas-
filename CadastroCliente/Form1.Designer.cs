namespace CadastroCliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNome = new TextBox();
            textBoxNomeSocial = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            maskedTextBoxDataNascimento = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            comboBoxGenero = new ComboBox();
            comboBoxEtnia = new ComboBox();
            checkBoxEstrangeiro = new CheckBox();
            radioButtonTipoPF = new RadioButton();
            radioButtonTipoPJ = new RadioButton();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            textBoxLogradouro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            textBoxMunicipio = new TextBox();
            textBoxEstado = new TextBox();
            maskedTextBoxCEP = new MaskedTextBox();
            button1 = new Button();
            label17 = new Label();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(27, 41);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(445, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(154, 135);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(183, 23);
            textBoxNomeSocial.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(281, 85);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(183, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 67);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 4;
            label2.Text = "Data de nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 67);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 67);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 117);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 7;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 117);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 8;
            label6.Text = "Nome social:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 167);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 9;
            label7.Text = "Etnia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(153, 167);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 10;
            label8.Text = "Estrangeiro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(253, 167);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 11;
            label9.Text = "Tipo:";
            // 
            // maskedTextBoxDataNascimento
            // 
            maskedTextBoxDataNascimento.Location = new Point(27, 85);
            maskedTextBoxDataNascimento.Mask = "00/00/0000";
            maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            maskedTextBoxDataNascimento.Size = new Size(115, 23);
            maskedTextBoxDataNascimento.TabIndex = 12;
            maskedTextBoxDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(154, 85);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(121, 23);
            maskedTextBoxTelefone.TabIndex = 13;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(27, 135);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 14;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Location = new Point(26, 185);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(100, 23);
            comboBoxEtnia.TabIndex = 15;
            // 
            // checkBoxEstrangeiro
            // 
            checkBoxEstrangeiro.AutoSize = true;
            checkBoxEstrangeiro.Location = new Point(153, 187);
            checkBoxEstrangeiro.Name = "checkBoxEstrangeiro";
            checkBoxEstrangeiro.Size = new Size(46, 19);
            checkBoxEstrangeiro.TabIndex = 16;
            checkBoxEstrangeiro.Text = "Sim";
            checkBoxEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipoPF
            // 
            radioButtonTipoPF.AutoSize = true;
            radioButtonTipoPF.Location = new Point(253, 185);
            radioButtonTipoPF.Name = "radioButtonTipoPF";
            radioButtonTipoPF.Size = new Size(38, 19);
            radioButtonTipoPF.TabIndex = 17;
            radioButtonTipoPF.TabStop = true;
            radioButtonTipoPF.Text = "PF";
            radioButtonTipoPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipoPJ
            // 
            radioButtonTipoPJ.AutoSize = true;
            radioButtonTipoPJ.Location = new Point(317, 185);
            radioButtonTipoPJ.Name = "radioButtonTipoPJ";
            radioButtonTipoPJ.Size = new Size(35, 19);
            radioButtonTipoPJ.TabIndex = 18;
            radioButtonTipoPJ.TabStop = true;
            radioButtonTipoPJ.Text = "PJ";
            radioButtonTipoPJ.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 414);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 19;
            label10.Text = "Logradouro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 461);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 20;
            label11.Text = "Numero:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(142, 461);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 21;
            label12.Text = "Complemento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 362);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 22;
            label13.Text = "Bairro:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(26, 316);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 23;
            label14.Text = "Munícipio:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(210, 316);
            label15.Name = "label15";
            label15.Size = new Size(48, 15);
            label15.TabIndex = 24;
            label15.Text = "Estado: ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(26, 267);
            label16.Name = "label16";
            label16.Size = new Size(31, 15);
            label16.TabIndex = 25;
            label16.Text = "CEP:";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(27, 432);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(254, 23);
            textBoxLogradouro.TabIndex = 26;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(27, 479);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(92, 23);
            textBoxNumero.TabIndex = 27;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(142, 479);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(223, 23);
            textBoxComplemento.TabIndex = 28;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(27, 380);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(155, 23);
            textBoxBairro.TabIndex = 29;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(27, 334);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(155, 23);
            textBoxMunicipio.TabIndex = 30;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(210, 334);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(155, 23);
            textBoxEstado.TabIndex = 31;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(27, 285);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(57, 23);
            maskedTextBoxCEP.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new Point(211, 531);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(231, 567);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 34;
            label17.Text = "label17";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 600);
            Controls.Add(label17);
            Controls.Add(button1);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxMunicipio);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(radioButtonTipoPJ);
            Controls.Add(radioButtonTipoPF);
            Controls.Add(checkBoxEstrangeiro);
            Controls.Add(comboBoxEtnia);
            Controls.Add(comboBoxGenero);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxDataNascimento);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(textBoxNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxNomeSocial;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private MaskedTextBox maskedTextBoxDataNascimento;
        private MaskedTextBox maskedTextBoxTelefone;
        private ComboBox comboBoxGenero;
        private ComboBox comboBoxEtnia;
        private CheckBox checkBoxEstrangeiro;
        private RadioButton radioButtonTipoPF;
        private RadioButton radioButtonTipoPJ;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private TextBox textBoxBairro;
        private TextBox textBoxMunicipio;
        private TextBox textBoxEstado;
        private MaskedTextBox maskedTextBoxCEP;
        private Button button1;
        private Label label17;
    }
}
