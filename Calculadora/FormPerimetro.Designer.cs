namespace Calculadora
{
    partial class FormPerimetro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxPerimetro = new TextBox();
            textBoxArea = new TextBox();
            textBoxVolume = new TextBox();
            textBoxQuadrado = new TextBox();
            button1 = new Button();
            button2Voltar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxLado1Rtagl = new TextBox();
            textBoxLado2Rtagl = new TextBox();
            textBoxAltura = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 34);
            label1.Name = "label1";
            label1.Size = new Size(272, 21);
            label1.TabIndex = 0;
            label1.Text = "Calcular Perímetro, área e volume ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 268);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Perímetro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 312);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Área:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 362);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Volume:";
            // 
            // textBoxPerimetro
            // 
            textBoxPerimetro.Location = new Point(250, 265);
            textBoxPerimetro.Name = "textBoxPerimetro";
            textBoxPerimetro.ReadOnly = true;
            textBoxPerimetro.Size = new Size(100, 23);
            textBoxPerimetro.TabIndex = 4;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(250, 312);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.ReadOnly = true;
            textBoxArea.Size = new Size(100, 23);
            textBoxArea.TabIndex = 5;
            // 
            // textBoxVolume
            // 
            textBoxVolume.Location = new Point(250, 359);
            textBoxVolume.Name = "textBoxVolume";
            textBoxVolume.ReadOnly = true;
            textBoxVolume.Size = new Size(100, 23);
            textBoxVolume.TabIndex = 6;
            // 
            // textBoxQuadrado
            // 
            textBoxQuadrado.Location = new Point(250, 156);
            textBoxQuadrado.Name = "textBoxQuadrado";
            textBoxQuadrado.Size = new Size(100, 23);
            textBoxQuadrado.TabIndex = 8;
            textBoxQuadrado.TextChanged += textBoxMedidaUsuario_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(400, 233);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2Voltar
            // 
            button2Voltar.Location = new Point(691, 402);
            button2Voltar.Name = "button2Voltar";
            button2Voltar.Size = new Size(75, 23);
            button2Voltar.TabIndex = 10;
            button2Voltar.Text = "Voltar";
            button2Voltar.UseVisualStyleBackColor = true;
            button2Voltar.Click += button2Voltar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(579, 356);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(579, 309);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(579, 262);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 359);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 15;
            label5.Text = "Volume:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(504, 309);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 14;
            label6.Text = "Área:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(504, 265);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 13;
            label7.Text = "Perímetro:";
            // 
            // textBoxLado1Rtagl
            // 
            textBoxLado1Rtagl.Location = new Point(533, 127);
            textBoxLado1Rtagl.Name = "textBoxLado1Rtagl";
            textBoxLado1Rtagl.Size = new Size(100, 23);
            textBoxLado1Rtagl.TabIndex = 19;
            // 
            // textBoxLado2Rtagl
            // 
            textBoxLado2Rtagl.Location = new Point(533, 156);
            textBoxLado2Rtagl.Name = "textBoxLado2Rtagl";
            textBoxLado2Rtagl.Size = new Size(100, 23);
            textBoxLado2Rtagl.TabIndex = 20;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(533, 185);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(100, 23);
            textBoxAltura.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 159);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 22;
            label8.Text = "Lado:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Quadrado", "Retangulo" });
            comboBox1.Location = new Point(381, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(263, 90);
            label9.Name = "label9";
            label9.Size = new Size(109, 15);
            label9.TabIndex = 24;
            label9.Text = "Escolha uma forma";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(491, 130);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 25;
            label10.Text = "Lado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(477, 159);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 26;
            label11.Text = "Largura:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(485, 188);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 27;
            label12.Text = "Altura:";
            // 
            // FormPerimetro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(textBoxAltura);
            Controls.Add(textBoxLado2Rtagl);
            Controls.Add(textBoxLado1Rtagl);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(button2Voltar);
            Controls.Add(button1);
            Controls.Add(textBoxQuadrado);
            Controls.Add(textBoxVolume);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxPerimetro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPerimetro";
            Text = "FormPerimetro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxPerimetro;
        private TextBox textBoxArea;
        private TextBox textBoxVolume;
        private TextBox textBoxQuadrado;
        private Button button1;
        private Button button2Voltar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxLado1Rtagl;
        private TextBox textBoxLado2Rtagl;
        private TextBox textBoxAltura;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}