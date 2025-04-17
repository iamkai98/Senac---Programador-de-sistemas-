namespace ListaAtividades
{
    partial class ListaDeAtividades
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
            textBoxAtividadeEmAndamento = new TextBox();
            Finalizar = new Button();
            dataGridViewAtividades = new DataGridView();
            buttonAtualizar = new Button();
            buttonCriar = new Button();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).BeginInit();
            SuspendLayout();
            // 
            // textBoxAtividadeEmAndamento
            // 
            textBoxAtividadeEmAndamento.Location = new Point(12, 12);
            textBoxAtividadeEmAndamento.Name = "textBoxAtividadeEmAndamento";
            textBoxAtividadeEmAndamento.ReadOnly = true;
            textBoxAtividadeEmAndamento.Size = new Size(641, 23);
            textBoxAtividadeEmAndamento.TabIndex = 0;
            // 
            // Finalizar
            // 
            Finalizar.Location = new Point(659, 12);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(129, 23);
            Finalizar.TabIndex = 1;
            Finalizar.Text = "Finalizar";
            Finalizar.UseVisualStyleBackColor = true;
            Finalizar.Click += Finalizar_Click;
            // 
            // dataGridViewAtividades
            // 
            dataGridViewAtividades.AllowUserToAddRows = false;
            dataGridViewAtividades.AllowUserToDeleteRows = false;
            dataGridViewAtividades.AllowUserToResizeColumns = false;
            dataGridViewAtividades.AllowUserToResizeRows = false;
            dataGridViewAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtividades.Location = new Point(12, 51);
            dataGridViewAtividades.MultiSelect = false;
            dataGridViewAtividades.Name = "dataGridViewAtividades";
            dataGridViewAtividades.ReadOnly = true;
            dataGridViewAtividades.Size = new Size(641, 331);
            dataGridViewAtividades.TabIndex = 2;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(659, 51);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(129, 23);
            buttonAtualizar.TabIndex = 3;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(659, 359);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(129, 23);
            buttonCriar.TabIndex = 4;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(36, 414);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 5;
            labelErro.Text = "label1";
            // 
            // ListaDeAtividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(buttonCriar);
            Controls.Add(buttonAtualizar);
            Controls.Add(dataGridViewAtividades);
            Controls.Add(Finalizar);
            Controls.Add(textBoxAtividadeEmAndamento);
            Name = "ListaDeAtividades";
            Text = "Form1";
            Load += ListaDeAtividades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAtividadeEmAndamento;
        private Button Finalizar;
        private DataGridView dataGridViewAtividades;
        private Button buttonAtualizar;
        private Button buttonCriar;
        private Label labelErro;
    }
}
