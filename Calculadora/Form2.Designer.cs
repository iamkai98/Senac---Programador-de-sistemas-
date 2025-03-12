namespace Calculadora
{
    partial class NewForm
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
            textBoxCM = new TextBox();
            textBoxKG = new TextBox();
            label2 = new Label();
            label3 = new Label();
            labelResultado = new Label();
            buttonCalcular = new Button();
            label5 = new Label();
            label6 = new Label();
            radioButtonFeminino = new RadioButton();
            radioButtonMasculino = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 62);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 0;
            label1.Text = "Calcular IMC";
            // 
            // textBoxCM
            // 
            textBoxCM.Location = new Point(158, 184);
            textBoxCM.Name = "textBoxCM";
            textBoxCM.Size = new Size(100, 23);
            textBoxCM.TabIndex = 1;
            // 
            // textBoxKG
            // 
            textBoxKG.Location = new Point(158, 237);
            textBoxKG.Name = "textBoxKG";
            textBoxKG.Size = new Size(100, 23);
            textBoxKG.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 187);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Digite sua altura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 240);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Digite seu peso:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(185, 348);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 6;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(172, 294);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 7;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 187);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 8;
            label5.Text = "cm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 240);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 9;
            label6.Text = "kg";
            // 
            // radioButtonFeminino
            // 
            radioButtonFeminino.AutoSize = true;
            radioButtonFeminino.Location = new Point(100, 127);
            radioButtonFeminino.Name = "radioButtonFeminino";
            radioButtonFeminino.Size = new Size(75, 19);
            radioButtonFeminino.TabIndex = 10;
            radioButtonFeminino.TabStop = true;
            radioButtonFeminino.Text = "Feminino";
            radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            radioButtonMasculino.AutoSize = true;
            radioButtonMasculino.Location = new Point(185, 127);
            radioButtonMasculino.Name = "radioButtonMasculino";
            radioButtonMasculino.Size = new Size(80, 19);
            radioButtonMasculino.TabIndex = 11;
            radioButtonMasculino.TabStop = true;
            radioButtonMasculino.Text = "Masculino";
            radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // NewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonMasculino);
            Controls.Add(radioButtonFeminino);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonCalcular);
            Controls.Add(labelResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxKG);
            Controls.Add(textBoxCM);
            Controls.Add(label1);
            Name = "NewForm";
            Text = "NewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCM;
        private TextBox textBoxKG;
        private Label label2;
        private Label label3;
        private Label labelResultado;
        private Button buttonCalcular;
        private Label label5;
        private Label label6;
        private RadioButton radioButtonFeminino;
        private RadioButton radioButtonMasculino;
    }
}