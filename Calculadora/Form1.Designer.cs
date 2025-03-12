namespace Calculadora
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
            buttonResultado = new Button();
            textBoxNumero1 = new TextBox();
            textBoxNumero2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonSoma = new Button();
            buttonSubtracao = new Button();
            buttonMultiplicar = new Button();
            buttonDivisao = new Button();
            labelResultado = new Label();
            radioButtonSomar = new RadioButton();
            radioButtonSubtrair = new RadioButton();
            radioButtonMultiplicar = new RadioButton();
            radioButtonDividir = new RadioButton();
            textBoxResultado = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonResultado
            // 
            buttonResultado.Location = new Point(369, 269);
            buttonResultado.Name = "buttonResultado";
            buttonResultado.Size = new Size(75, 23);
            buttonResultado.TabIndex = 0;
            buttonResultado.Text = "Calcular";
            buttonResultado.UseVisualStyleBackColor = true;
            buttonResultado.Click += buttonResultado_Click;
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(279, 112);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(100, 23);
            textBoxNumero1.TabIndex = 1;
            textBoxNumero1.TextChanged += textBoxNumero1_TextChanged;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(557, 112);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(100, 23);
            textBoxNumero2.TabIndex = 2;
            textBoxNumero2.TextChanged += textBoxNumero2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 115);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 3;
            label1.Text = "Insira o primeiro número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 115);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 4;
            label2.Text = "Insira o segundo número";
            // 
            // buttonSoma
            // 
            buttonSoma.Enabled = false;
            buttonSoma.Location = new Point(224, 180);
            buttonSoma.Name = "buttonSoma";
            buttonSoma.Size = new Size(75, 23);
            buttonSoma.TabIndex = 9;
            buttonSoma.Text = "+";
            buttonSoma.UseVisualStyleBackColor = true;
            buttonSoma.UseWaitCursor = true;
            buttonSoma.Click += button1_Click;
            // 
            // buttonSubtracao
            // 
            buttonSubtracao.Enabled = false;
            buttonSubtracao.Location = new Point(328, 180);
            buttonSubtracao.Name = "buttonSubtracao";
            buttonSubtracao.Size = new Size(75, 23);
            buttonSubtracao.TabIndex = 10;
            buttonSubtracao.Text = "-";
            buttonSubtracao.UseVisualStyleBackColor = true;
            buttonSubtracao.UseWaitCursor = true;
            buttonSubtracao.Click += buttonSubtracao_Click;
            // 
            // buttonMultiplicar
            // 
            buttonMultiplicar.Enabled = false;
            buttonMultiplicar.Location = new Point(425, 180);
            buttonMultiplicar.Name = "buttonMultiplicar";
            buttonMultiplicar.Size = new Size(75, 23);
            buttonMultiplicar.TabIndex = 11;
            buttonMultiplicar.Text = "*";
            buttonMultiplicar.UseVisualStyleBackColor = true;
            buttonMultiplicar.UseWaitCursor = true;
            buttonMultiplicar.Click += buttonMultiplicar_Click;
            // 
            // buttonDivisao
            // 
            buttonDivisao.Enabled = false;
            buttonDivisao.Location = new Point(525, 180);
            buttonDivisao.Name = "buttonDivisao";
            buttonDivisao.Size = new Size(75, 23);
            buttonDivisao.TabIndex = 12;
            buttonDivisao.Text = "/";
            buttonDivisao.UseVisualStyleBackColor = true;
            buttonDivisao.Click += buttonDivisao_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(409, 321);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 13);
            labelResultado.TabIndex = 5;
            // 
            // radioButtonSomar
            // 
            radioButtonSomar.AutoSize = true;
            radioButtonSomar.Location = new Point(223, 225);
            radioButtonSomar.Name = "radioButtonSomar";
            radioButtonSomar.Size = new Size(59, 19);
            radioButtonSomar.TabIndex = 13;
            radioButtonSomar.TabStop = true;
            radioButtonSomar.Text = "Somar";
            radioButtonSomar.UseVisualStyleBackColor = true;
            radioButtonSomar.CheckedChanged += radioButtonSomar_CheckedChanged;
            // 
            // radioButtonSubtrair
            // 
            radioButtonSubtrair.AutoSize = true;
            radioButtonSubtrair.Location = new Point(328, 225);
            radioButtonSubtrair.Name = "radioButtonSubtrair";
            radioButtonSubtrair.Size = new Size(66, 19);
            radioButtonSubtrair.TabIndex = 14;
            radioButtonSubtrair.TabStop = true;
            radioButtonSubtrair.Text = "Subtrair";
            radioButtonSubtrair.UseVisualStyleBackColor = true;
            radioButtonSubtrair.CheckedChanged += radioButtonSubtrair_CheckedChanged;
            // 
            // radioButtonMultiplicar
            // 
            radioButtonMultiplicar.AutoSize = true;
            radioButtonMultiplicar.Location = new Point(418, 225);
            radioButtonMultiplicar.Name = "radioButtonMultiplicar";
            radioButtonMultiplicar.Size = new Size(82, 19);
            radioButtonMultiplicar.TabIndex = 15;
            radioButtonMultiplicar.TabStop = true;
            radioButtonMultiplicar.Text = "Multiplicar";
            radioButtonMultiplicar.UseVisualStyleBackColor = true;
            radioButtonMultiplicar.CheckedChanged += radioButtonMultiplicar_CheckedChanged;
            // 
            // radioButtonDividir
            // 
            radioButtonDividir.AutoSize = true;
            radioButtonDividir.Location = new Point(525, 225);
            radioButtonDividir.Name = "radioButtonDividir";
            radioButtonDividir.Size = new Size(59, 19);
            radioButtonDividir.TabIndex = 16;
            radioButtonDividir.TabStop = true;
            radioButtonDividir.Text = "Dividir";
            radioButtonDividir.UseVisualStyleBackColor = true;
            radioButtonDividir.CheckedChanged += radioButtonDividir_CheckedChanged;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(357, 321);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(660, 405);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 18;
            button1.Text = "Mais Opções >>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxResultado);
            Controls.Add(radioButtonDividir);
            Controls.Add(radioButtonMultiplicar);
            Controls.Add(radioButtonSubtrair);
            Controls.Add(radioButtonSomar);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonMultiplicar);
            Controls.Add(buttonSubtracao);
            Controls.Add(buttonSoma);
            Controls.Add(labelResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNumero2);
            Controls.Add(textBoxNumero1);
            Controls.Add(buttonResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonResultado;
        private TextBox textBoxNumero1;
        private TextBox textBoxNumero2;
        private Label label1;
        private Label label2;
        private Button buttonSoma;
        private Button buttonSubtracao;
        private Button buttonMultiplicar;
        private Button buttonDivisao;
        private Label labelResultado;
        private RadioButton radioButtonSomar;
        private RadioButton radioButtonSubtrair;
        private RadioButton radioButtonMultiplicar;
        private RadioButton radioButtonDividir;
        private TextBox textBoxResultado;
        private Button button1;
    }
}
