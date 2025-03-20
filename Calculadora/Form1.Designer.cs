namespace calculadora
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
            textBoxNumero1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonCalcular = new Button();
            textBoxNumero2 = new TextBox();
            radioButtonSomar = new RadioButton();
            radioButtonSubtrair = new RadioButton();
            radioButtonMultiplicar = new RadioButton();
            radioButtonDividir = new RadioButton();
            textBoxResultado = new TextBox();
            labelResultado = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(12, 44);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(100, 23);
            textBoxNumero1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 1;
            label1.Text = "Insira o primeiro numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 2;
            label2.Text = "Insira o segundo número:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(23, 266);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 3;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(12, 101);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(100, 23);
            textBoxNumero2.TabIndex = 4;
            // 
            // radioButtonSomar
            // 
            radioButtonSomar.AutoSize = true;
            radioButtonSomar.Location = new Point(12, 166);
            radioButtonSomar.Name = "radioButtonSomar";
            radioButtonSomar.Size = new Size(59, 19);
            radioButtonSomar.TabIndex = 5;
            radioButtonSomar.TabStop = true;
            radioButtonSomar.Text = "Somar";
            radioButtonSomar.UseVisualStyleBackColor = true;
            radioButtonSomar.CheckedChanged += radioButtonSomar_CheckedChanged;
            // 
            // radioButtonSubtrair
            // 
            radioButtonSubtrair.AutoSize = true;
            radioButtonSubtrair.Location = new Point(12, 191);
            radioButtonSubtrair.Name = "radioButtonSubtrair";
            radioButtonSubtrair.Size = new Size(66, 19);
            radioButtonSubtrair.TabIndex = 6;
            radioButtonSubtrair.TabStop = true;
            radioButtonSubtrair.Text = "Subtrair";
            radioButtonSubtrair.UseVisualStyleBackColor = true;
            radioButtonSubtrair.CheckedChanged += radioButtonSubtrair_CheckedChanged;
            // 
            // radioButtonMultiplicar
            // 
            radioButtonMultiplicar.AutoSize = true;
            radioButtonMultiplicar.Location = new Point(12, 216);
            radioButtonMultiplicar.Name = "radioButtonMultiplicar";
            radioButtonMultiplicar.Size = new Size(82, 19);
            radioButtonMultiplicar.TabIndex = 7;
            radioButtonMultiplicar.TabStop = true;
            radioButtonMultiplicar.Text = "Multiplicar";
            radioButtonMultiplicar.UseVisualStyleBackColor = true;
            radioButtonMultiplicar.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonDividir
            // 
            radioButtonDividir.AutoSize = true;
            radioButtonDividir.Location = new Point(12, 241);
            radioButtonDividir.Name = "radioButtonDividir";
            radioButtonDividir.Size = new Size(59, 19);
            radioButtonDividir.TabIndex = 8;
            radioButtonDividir.TabStop = true;
            radioButtonDividir.Text = "Dividir";
            radioButtonDividir.UseVisualStyleBackColor = true;
            radioButtonDividir.CheckedChanged += radioButtonDivdir_CheckedChanged;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(23, 356);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 9;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(12, 328);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(444, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "GeoCalc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(444, 355);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Circle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 398);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelResultado);
            Controls.Add(textBoxResultado);
            Controls.Add(radioButtonDividir);
            Controls.Add(radioButtonMultiplicar);
            Controls.Add(radioButtonSubtrair);
            Controls.Add(radioButtonSomar);
            Controls.Add(textBoxNumero2);
            Controls.Add(buttonCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumero1;
        private Label label1;
        private Label label2;
        private Button buttonCalcular;
        private TextBox textBoxNumero2;
        private RadioButton radioButtonSomar;
        private RadioButton radioButtonSubtrair;
        private RadioButton radioButtonMultiplicar;
        private RadioButton radioButtonDividir;
        private TextBox textBoxResultado;
        private Label labelResultado;
        private Button button1;
        private Button button2;
    }
}
