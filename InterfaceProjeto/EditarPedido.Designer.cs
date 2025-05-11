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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPedido));
            textBoxBuscarPedido = new TextBox();
            dataGridView1 = new DataGridView();
            buttonBuscarPedido = new Button();
            buttonDetalhes = new Button();
            buttonFinalizar = new Button();
            buttonExtender = new Button();
            buttonVoltarMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscarPedido
            // 
            textBoxBuscarPedido.Anchor = AnchorStyles.Top;
            textBoxBuscarPedido.BackColor = Color.White;
            textBoxBuscarPedido.Location = new Point(634, 343);
            textBoxBuscarPedido.Name = "textBoxBuscarPedido";
            textBoxBuscarPedido.Size = new Size(443, 25);
            textBoxBuscarPedido.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 414);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1251, 573);
            dataGridView1.TabIndex = 9;
            // 
            // buttonBuscarPedido
            // 
            buttonBuscarPedido.Anchor = AnchorStyles.Top;
            buttonBuscarPedido.BackColor = Color.Transparent;
            buttonBuscarPedido.Cursor = Cursors.Hand;
            buttonBuscarPedido.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonBuscarPedido.FlatStyle = FlatStyle.Flat;
            buttonBuscarPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarPedido.ForeColor = Color.White;
            buttonBuscarPedido.Location = new Point(1083, 339);
            buttonBuscarPedido.Name = "buttonBuscarPedido";
            buttonBuscarPedido.Size = new Size(75, 30);
            buttonBuscarPedido.TabIndex = 10;
            buttonBuscarPedido.Text = "Buscar";
            buttonBuscarPedido.UseVisualStyleBackColor = false;
            // 
            // buttonDetalhes
            // 
            buttonDetalhes.Anchor = AnchorStyles.None;
            buttonDetalhes.BackColor = Color.Transparent;
            buttonDetalhes.Cursor = Cursors.Hand;
            buttonDetalhes.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonDetalhes.FlatStyle = FlatStyle.Flat;
            buttonDetalhes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonDetalhes.ForeColor = Color.White;
            buttonDetalhes.Location = new Point(1531, 414);
            buttonDetalhes.Name = "buttonDetalhes";
            buttonDetalhes.Size = new Size(75, 30);
            buttonDetalhes.TabIndex = 11;
            buttonDetalhes.Text = "Detalhes";
            buttonDetalhes.UseVisualStyleBackColor = false;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Anchor = AnchorStyles.None;
            buttonFinalizar.BackColor = Color.Transparent;
            buttonFinalizar.Cursor = Cursors.Hand;
            buttonFinalizar.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonFinalizar.FlatStyle = FlatStyle.Flat;
            buttonFinalizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonFinalizar.ForeColor = Color.White;
            buttonFinalizar.Location = new Point(1623, 953);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(75, 30);
            buttonFinalizar.TabIndex = 12;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            // 
            // buttonExtender
            // 
            buttonExtender.Anchor = AnchorStyles.None;
            buttonExtender.BackColor = Color.Transparent;
            buttonExtender.Cursor = Cursors.Hand;
            buttonExtender.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonExtender.FlatStyle = FlatStyle.Flat;
            buttonExtender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonExtender.ForeColor = Color.White;
            buttonExtender.Location = new Point(1531, 953);
            buttonExtender.Name = "buttonExtender";
            buttonExtender.Size = new Size(75, 30);
            buttonExtender.TabIndex = 13;
            buttonExtender.Text = "Extender";
            buttonExtender.UseVisualStyleBackColor = false;
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.Anchor = AnchorStyles.None;
            buttonVoltarMenu.BackColor = Color.Transparent;
            buttonVoltarMenu.Cursor = Cursors.Hand;
            buttonVoltarMenu.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonVoltarMenu.FlatStyle = FlatStyle.Flat;
            buttonVoltarMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonVoltarMenu.ForeColor = Color.White;
            buttonVoltarMenu.Location = new Point(1817, 989);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 30);
            buttonVoltarMenu.TabIndex = 14;
            buttonVoltarMenu.Text = "Voltar";
            buttonVoltarMenu.UseVisualStyleBackColor = false;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click_1;
            // 
            // EditarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(buttonVoltarMenu);
            Controls.Add(buttonExtender);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonDetalhes);
            Controls.Add(buttonBuscarPedido);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxBuscarPedido);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "EditarPedido";
            Text = "EditarPedido";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxBuscarPedido;
        private DataGridView dataGridView1;
        private Button buttonBuscarPedido;
        private Button buttonDetalhes;
        private Button buttonFinalizar;
        private Button buttonExtender;
        private Button buttonVoltarMenu;
    }
}