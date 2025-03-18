namespace calculadoraDoOdio
{
    partial class Circle
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
            buttonCalcular = new Button();
            radioButtonDiametro = new RadioButton();
            radioButtonPerimetro = new RadioButton();
            radioButtonArea = new RadioButton();
            radioButtonVolume = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            textBoxRaio = new TextBox();
            textBoxResultado = new TextBox();
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(91, 159);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 0;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += button1_Click;
            // 
            // radioButtonDiametro
            // 
            radioButtonDiametro.AutoSize = true;
            radioButtonDiametro.Location = new Point(220, 84);
            radioButtonDiametro.Name = "radioButtonDiametro";
            radioButtonDiametro.Size = new Size(74, 19);
            radioButtonDiametro.TabIndex = 1;
            radioButtonDiametro.TabStop = true;
            radioButtonDiametro.Text = "Diametro";
            radioButtonDiametro.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Location = new Point(220, 109);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 2;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perimetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(220, 134);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 3;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Area";
            radioButtonArea.UseVisualStyleBackColor = true;
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(220, 159);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 4;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 88);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Raio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 119);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "Resultado:";
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(81, 87);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(100, 23);
            textBoxRaio.TabIndex = 7;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(81, 116);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 8;
            // 
            // Circle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxRaio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButtonVolume);
            Controls.Add(radioButtonArea);
            Controls.Add(radioButtonPerimetro);
            Controls.Add(radioButtonDiametro);
            Controls.Add(buttonCalcular);
            Name = "Circle";
            Text = "Circle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalcular;
        private RadioButton radioButtonDiametro;
        private RadioButton radioButtonPerimetro;
        private RadioButton radioButtonArea;
        private RadioButton radioButtonVolume;
        private Label label1;
        private Label label2;
        private TextBox textBoxRaio;
        private TextBox textBoxResultado;
    }
}