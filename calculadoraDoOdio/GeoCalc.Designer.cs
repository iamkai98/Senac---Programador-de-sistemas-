namespace calculadoraDoOdio
{
    partial class GeoCalc
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBoxLadoQuadrado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxLadoRetangulo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxLarguraRetangulo = new TextBox();
            label6 = new Label();
            textBoxAlturaRetangulo = new TextBox();
            buttonCalcular = new Button();
            textBoxPeriQuad = new TextBox();
            textBoxAreaQuad = new TextBox();
            textBoxVolQuad = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Quadrado ", "Retangulo" });
            comboBox1.Location = new Point(312, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 92);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Escolha uma forma: ";
            // 
            // textBoxLadoQuadrado
            // 
            textBoxLadoQuadrado.Location = new Point(188, 146);
            textBoxLadoQuadrado.Name = "textBoxLadoQuadrado";
            textBoxLadoQuadrado.Size = new Size(100, 23);
            textBoxLadoQuadrado.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 149);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Lado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 40);
            label3.Name = "label3";
            label3.Size = new Size(295, 25);
            label3.TabIndex = 4;
            label3.Text = "Calcule - Quadrado e Retângulo";
            // 
            // textBoxLadoRetangulo
            // 
            textBoxLadoRetangulo.Location = new Point(487, 141);
            textBoxLadoRetangulo.Name = "textBoxLadoRetangulo";
            textBoxLadoRetangulo.Size = new Size(100, 23);
            textBoxLadoRetangulo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 146);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Lado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 173);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 8;
            label5.Text = "Largura:";
            // 
            // textBoxLarguraRetangulo
            // 
            textBoxLarguraRetangulo.Location = new Point(487, 170);
            textBoxLarguraRetangulo.Name = "textBoxLarguraRetangulo";
            textBoxLarguraRetangulo.Size = new Size(100, 23);
            textBoxLarguraRetangulo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 202);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Altura:";
            // 
            // textBoxAlturaRetangulo
            // 
            textBoxAlturaRetangulo.Location = new Point(487, 199);
            textBoxAlturaRetangulo.Name = "textBoxAlturaRetangulo";
            textBoxAlturaRetangulo.Size = new Size(100, 23);
            textBoxAlturaRetangulo.TabIndex = 9;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(204, 254);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 11;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            // 
            // textBoxPeriQuad
            // 
            textBoxPeriQuad.Location = new Point(188, 304);
            textBoxPeriQuad.Name = "textBoxPeriQuad";
            textBoxPeriQuad.ReadOnly = true;
            textBoxPeriQuad.Size = new Size(100, 23);
            textBoxPeriQuad.TabIndex = 12;
            // 
            // textBoxAreaQuad
            // 
            textBoxAreaQuad.Location = new Point(188, 333);
            textBoxAreaQuad.Name = "textBoxAreaQuad";
            textBoxAreaQuad.ReadOnly = true;
            textBoxAreaQuad.Size = new Size(100, 23);
            textBoxAreaQuad.TabIndex = 13;
            // 
            // textBoxVolQuad
            // 
            textBoxVolQuad.Location = new Point(188, 362);
            textBoxVolQuad.Name = "textBoxVolQuad";
            textBoxVolQuad.ReadOnly = true;
            textBoxVolQuad.Size = new Size(100, 23);
            textBoxVolQuad.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 307);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 15;
            label7.Text = "Perímetro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(120, 336);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 16;
            label8.Text = "Área:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 365);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 17;
            label9.Text = "Volume:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(419, 365);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 23;
            label10.Text = "Volume:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(419, 336);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 22;
            label11.Text = "Área:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(419, 307);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 21;
            label12.Text = "Perímetro:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(487, 362);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 20;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(487, 333);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 19;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(487, 304);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(502, 254);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // GeoCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxVolQuad);
            Controls.Add(textBoxAreaQuad);
            Controls.Add(textBoxPeriQuad);
            Controls.Add(buttonCalcular);
            Controls.Add(label6);
            Controls.Add(textBoxAlturaRetangulo);
            Controls.Add(label5);
            Controls.Add(textBoxLarguraRetangulo);
            Controls.Add(label4);
            Controls.Add(textBoxLadoRetangulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxLadoQuadrado);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "GeoCalc";
            Text = "GeoCalc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBoxLadoQuadrado;
        private Label label2;
        private Label label3;
        private TextBox textBoxLadoRetangulo;
        private Label label4;
        private Label label5;
        private TextBox textBoxLarguraRetangulo;
        private Label label6;
        private TextBox textBoxAlturaRetangulo;
        private Button buttonCalcular;
        private TextBox textBoxPeriQuad;
        private TextBox textBoxAreaQuad;
        private TextBox textBoxVolQuad;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button1;
    }
}