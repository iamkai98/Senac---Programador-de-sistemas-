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
            maskedTextBoxCEP = new MaskedTextBox();
            button1 = new Button();
            labelAviso = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            comboBoxEstado = new ComboBox();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(198, 36);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(445, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(452, 143);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(183, 23);
            textBoxNomeSocial.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(452, 90);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(183, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 72);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 4;
            label2.Text = "Data de nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 72);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 72);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 125);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 7;
            label5.Text = "Gênero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 125);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 8;
            label6.Text = "Nome social:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(325, 125);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 9;
            label7.Text = "Etnia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 178);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 10;
            label8.Text = "Estrangeiro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(198, 178);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 11;
            label9.Text = "Tipo:";
            // 
            // maskedTextBoxDataNascimento
            // 
            maskedTextBoxDataNascimento.Location = new Point(198, 90);
            maskedTextBoxDataNascimento.Mask = "00/00/0000";
            maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            maskedTextBoxDataNascimento.Size = new Size(115, 23);
            maskedTextBoxDataNascimento.TabIndex = 12;
            maskedTextBoxDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(325, 90);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(121, 23);
            maskedTextBoxTelefone.TabIndex = 13;
            maskedTextBoxTelefone.MaskInputRejected += maskedTextBoxTelefone_MaskInputRejected;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Feminino ", "Não Binário", "Outro " });
            comboBoxGenero.Location = new Point(198, 143);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(115, 23);
            comboBoxGenero.TabIndex = 14;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branca", "Negra", "Parda", "Amarela", "Indigena", "Outra" });
            comboBoxEtnia.Location = new Point(325, 143);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(121, 23);
            comboBoxEtnia.TabIndex = 15;
            // 
            // checkBoxEstrangeiro
            // 
            checkBoxEstrangeiro.AutoSize = true;
            checkBoxEstrangeiro.Location = new Point(325, 198);
            checkBoxEstrangeiro.Name = "checkBoxEstrangeiro";
            checkBoxEstrangeiro.Size = new Size(46, 19);
            checkBoxEstrangeiro.TabIndex = 16;
            checkBoxEstrangeiro.Text = "Sim";
            checkBoxEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipoPF
            // 
            radioButtonTipoPF.AutoSize = true;
            radioButtonTipoPF.Location = new Point(198, 196);
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
            radioButtonTipoPJ.Location = new Point(262, 196);
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
            label10.Location = new Point(198, 422);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 19;
            label10.Text = "Logradouro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(197, 473);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 20;
            label11.Text = "Numero:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(313, 473);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 21;
            label12.Text = "Complemento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(197, 368);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 22;
            label13.Text = "Bairro:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(198, 315);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 23;
            label14.Text = "Município:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(382, 315);
            label15.Name = "label15";
            label15.Size = new Size(48, 15);
            label15.TabIndex = 24;
            label15.Text = "Estado: ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(197, 262);
            label16.Name = "label16";
            label16.Size = new Size(31, 15);
            label16.TabIndex = 25;
            label16.Text = "CEP:";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(199, 440);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(254, 23);
            textBoxLogradouro.TabIndex = 26;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(198, 491);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(92, 23);
            textBoxNumero.TabIndex = 27;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(313, 491);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(223, 23);
            textBoxComplemento.TabIndex = 28;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(198, 386);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(155, 23);
            textBoxBairro.TabIndex = 29;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(199, 333);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(155, 23);
            textBoxMunicipio.TabIndex = 30;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(198, 280);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(72, 23);
            maskedTextBoxCEP.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new Point(382, 541);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Location = new Point(292, 566);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(0, 15);
            labelAviso.TabIndex = 34;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(292, 19);
            label17.Name = "label17";
            label17.Size = new Size(12, 15);
            label17.TabIndex = 35;
            label17.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Red;
            label18.Location = new Point(308, 73);
            label18.Name = "label18";
            label18.Size = new Size(12, 15);
            label18.TabIndex = 36;
            label18.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(376, 73);
            label19.Name = "label19";
            label19.Size = new Size(12, 15);
            label19.TabIndex = 37;
            label19.Text = "*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Red;
            label20.Location = new Point(488, 73);
            label20.Name = "label20";
            label20.Size = new Size(12, 15);
            label20.TabIndex = 38;
            label20.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Red;
            label22.Location = new Point(243, 125);
            label22.Name = "label22";
            label22.Size = new Size(12, 15);
            label22.TabIndex = 40;
            label22.Text = "*";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Red;
            label23.Location = new Point(356, 125);
            label23.Name = "label23";
            label23.Size = new Size(12, 15);
            label23.TabIndex = 41;
            label23.Text = "*";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.Red;
            label24.Location = new Point(224, 263);
            label24.Name = "label24";
            label24.Size = new Size(12, 15);
            label24.TabIndex = 42;
            label24.Text = "*";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Red;
            label25.Location = new Point(257, 316);
            label25.Name = "label25";
            label25.Size = new Size(12, 15);
            label25.TabIndex = 43;
            label25.Text = "*";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.Red;
            label26.Location = new Point(422, 315);
            label26.Name = "label26";
            label26.Size = new Size(12, 15);
            label26.TabIndex = 44;
            label26.Text = "*";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.Red;
            label27.Location = new Point(234, 368);
            label27.Name = "label27";
            label27.Size = new Size(12, 15);
            label27.TabIndex = 45;
            label27.Text = "*";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.Red;
            label28.Location = new Point(266, 422);
            label28.Name = "label28";
            label28.Size = new Size(12, 15);
            label28.TabIndex = 46;
            label28.Text = "*";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.Red;
            label29.Location = new Point(227, 178);
            label29.Name = "label29";
            label29.Size = new Size(12, 15);
            label29.TabIndex = 47;
            label29.Text = "*";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.ForeColor = Color.Red;
            label30.Location = new Point(246, 473);
            label30.Name = "label30";
            label30.Size = new Size(12, 15);
            label30.TabIndex = 48;
            label30.Text = "*";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Acre  ", "Alagoas  ", "Amapá  ", "Amazonas  ", "Bahia  ", "Ceará  ", "Distrito Federal  ", "Espírito Santo  ", "Goiás  ", "Maranhão  ", "Mato Grosso  ", "Mato Grosso do Sul  ", "Minas Gerais  ", "Pará  ", "Paraíba  ", "Paraná  ", "Pernambuco  ", "Piauí  ", "Rio de Janeiro  ", "Rio Grande do Norte  ", "Rio Grande do Sul  ", "Rondônia  ", "Roraima  ", "Santa Catarina  ", "São Paulo  ", "Sergipe  ", "Tocantins" });
            comboBoxEstado.Location = new Point(382, 333);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(207, 23);
            comboBoxEstado.TabIndex = 49;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 600);
            Controls.Add(comboBoxEstado);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(labelAviso);
            Controls.Add(button1);
            Controls.Add(maskedTextBoxCEP);
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
        private Label labelAviso;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private ComboBox comboBox1;
        private ComboBox comboBoxEstado;
    }
}
