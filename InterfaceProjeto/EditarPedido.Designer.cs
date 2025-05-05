namespace InterfaceProjeto
{
    partial class EditarPedido
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
            buttonVoltarMenu = new Button();
            textBoxBuscarPedido = new TextBox();
            dataGridView1 = new DataGridView();
            buttonBuscarPedido = new Button();
            buttonDetalhes = new Button();
            buttonFinalizar = new Button();
            buttonExtender = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonVoltarMenu.Cursor = Cursors.Hand;
            buttonVoltarMenu.FlatStyle = FlatStyle.Flat;
            buttonVoltarMenu.Location = new Point(879, 547);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 23);
            buttonVoltarMenu.TabIndex = 7;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = true;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // textBoxBuscarPedido
            // 
            textBoxBuscarPedido.Anchor = AnchorStyles.Top;
            textBoxBuscarPedido.BackColor = Color.White;
            textBoxBuscarPedido.Location = new Point(163, 42);
            textBoxBuscarPedido.Name = "textBoxBuscarPedido";
            textBoxBuscarPedido.Size = new Size(388, 23);
            textBoxBuscarPedido.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(578, 400);
            dataGridView1.TabIndex = 9;
            // 
            // buttonBuscarPedido
            // 
            buttonBuscarPedido.Anchor = AnchorStyles.Top;
            buttonBuscarPedido.Cursor = Cursors.Hand;
            buttonBuscarPedido.Location = new Point(557, 42);
            buttonBuscarPedido.Name = "buttonBuscarPedido";
            buttonBuscarPedido.Size = new Size(75, 23);
            buttonBuscarPedido.TabIndex = 10;
            buttonBuscarPedido.Text = "Buscar";
            buttonBuscarPedido.UseVisualStyleBackColor = true;
            // 
            // buttonDetalhes
            // 
            buttonDetalhes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDetalhes.Cursor = Cursors.Hand;
            buttonDetalhes.Location = new Point(723, 92);
            buttonDetalhes.Name = "buttonDetalhes";
            buttonDetalhes.Size = new Size(75, 23);
            buttonDetalhes.TabIndex = 11;
            buttonDetalhes.Text = "Detalhes";
            buttonDetalhes.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFinalizar.Cursor = Cursors.Hand;
            buttonFinalizar.Location = new Point(804, 469);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(75, 23);
            buttonFinalizar.TabIndex = 12;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // buttonExtender
            // 
            buttonExtender.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExtender.Cursor = Cursors.Hand;
            buttonExtender.Location = new Point(723, 469);
            buttonExtender.Name = "buttonExtender";
            buttonExtender.Size = new Size(75, 23);
            buttonExtender.TabIndex = 13;
            buttonExtender.Text = "Extender";
            buttonExtender.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.dd2oj85_b5bab19d_e110_4f51_ae2b_ca39dd6d8d74;
            pictureBox2.Location = new Point(899, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // EditarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 582);
            Controls.Add(pictureBox2);
            Controls.Add(buttonExtender);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonDetalhes);
            Controls.Add(buttonBuscarPedido);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxBuscarPedido);
            Controls.Add(buttonVoltarMenu);
            Name = "EditarPedido";
            Text = "EditarPedido";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonVoltarMenu;
        private TextBox textBoxBuscarPedido;
        private DataGridView dataGridView1;
        private Button buttonBuscarPedido;
        private Button buttonDetalhes;
        private Button buttonFinalizar;
        private Button buttonExtender;
        private PictureBox pictureBox2;
    }
}