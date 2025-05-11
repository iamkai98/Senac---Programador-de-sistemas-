namespace InterfaceProjeto
{
    partial class Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historico));
            buttonVoltarMenu = new Button();
            dataGridViewHistorico = new DataGridView();
            textBoxBuscarNomeCliente = new TextBox();
            buttonBuscarNomeCliente = new Button();
            buttonGerarRelatorio = new Button();
            comboBoxGerarRelatorio = new ComboBox();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorico).BeginInit();
            SuspendLayout();
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonVoltarMenu.BackColor = Color.Transparent;
            buttonVoltarMenu.Cursor = Cursors.Hand;
            buttonVoltarMenu.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonVoltarMenu.FlatStyle = FlatStyle.Flat;
            buttonVoltarMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltarMenu.ForeColor = Color.White;
            buttonVoltarMenu.Location = new Point(1817, 999);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(75, 30);
            buttonVoltarMenu.TabIndex = 7;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = false;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // dataGridViewHistorico
            // 
            dataGridViewHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorico.Location = new Point(591, 349);
            dataGridViewHistorico.Name = "dataGridViewHistorico";
            dataGridViewHistorico.Size = new Size(837, 512);
            dataGridViewHistorico.TabIndex = 8;
            // 
            // textBoxBuscarNomeCliente
            // 
            textBoxBuscarNomeCliente.Anchor = AnchorStyles.Top;
            textBoxBuscarNomeCliente.BackColor = Color.White;
            textBoxBuscarNomeCliente.Location = new Point(806, 300);
            textBoxBuscarNomeCliente.Name = "textBoxBuscarNomeCliente";
            textBoxBuscarNomeCliente.Size = new Size(388, 23);
            textBoxBuscarNomeCliente.TabIndex = 9;
            // 
            // buttonBuscarNomeCliente
            // 
            buttonBuscarNomeCliente.Anchor = AnchorStyles.Top;
            buttonBuscarNomeCliente.BackColor = Color.Transparent;
            buttonBuscarNomeCliente.Cursor = Cursors.Hand;
            buttonBuscarNomeCliente.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonBuscarNomeCliente.FlatStyle = FlatStyle.Flat;
            buttonBuscarNomeCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonBuscarNomeCliente.ForeColor = Color.White;
            buttonBuscarNomeCliente.Location = new Point(1200, 295);
            buttonBuscarNomeCliente.Name = "buttonBuscarNomeCliente";
            buttonBuscarNomeCliente.Size = new Size(75, 30);
            buttonBuscarNomeCliente.TabIndex = 11;
            buttonBuscarNomeCliente.Text = "Buscar";
            buttonBuscarNomeCliente.UseVisualStyleBackColor = false;
            // 
            // buttonGerarRelatorio
            // 
            buttonGerarRelatorio.Anchor = AnchorStyles.Top;
            buttonGerarRelatorio.BackColor = Color.Transparent;
            buttonGerarRelatorio.Cursor = Cursors.Hand;
            buttonGerarRelatorio.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonGerarRelatorio.FlatStyle = FlatStyle.Flat;
            buttonGerarRelatorio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonGerarRelatorio.ForeColor = Color.White;
            buttonGerarRelatorio.Location = new Point(1232, 900);
            buttonGerarRelatorio.Name = "buttonGerarRelatorio";
            buttonGerarRelatorio.Size = new Size(75, 30);
            buttonGerarRelatorio.TabIndex = 12;
            buttonGerarRelatorio.Text = "Gerar";
            buttonGerarRelatorio.UseVisualStyleBackColor = false;
            // 
            // comboBoxGerarRelatorio
            // 
            comboBoxGerarRelatorio.FormattingEnabled = true;
            comboBoxGerarRelatorio.Items.AddRange(new object[] { "Relatório de Pedidos Entregues", "Relatório Aluguéis por Cliente", "Relatório Jogos Mais Alugados", "Relatório Pedidos com Multa", "Relatório Jogos em Aluguel" });
            comboBoxGerarRelatorio.Location = new Point(842, 902);
            comboBoxGerarRelatorio.Name = "comboBoxGerarRelatorio";
            comboBoxGerarRelatorio.Size = new Size(384, 23);
            comboBoxGerarRelatorio.TabIndex = 13;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.BackColor = Color.Transparent;
            labelErro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelErro.ForeColor = Color.White;
            labelErro.Location = new Point(1014, 968);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(114, 17);
            labelErro.TabIndex = 14;
            labelErro.Text = "me deixe invisivel";
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelErro);
            Controls.Add(comboBoxGerarRelatorio);
            Controls.Add(buttonGerarRelatorio);
            Controls.Add(buttonBuscarNomeCliente);
            Controls.Add(textBoxBuscarNomeCliente);
            Controls.Add(dataGridViewHistorico);
            Controls.Add(buttonVoltarMenu);
            Name = "Historico";
            Text = "Historico";
            WindowState = FormWindowState.Maximized;
            Load += Historico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltarMenu;
        private DataGridView dataGridViewHistorico;
        private TextBox textBoxBuscarNomeCliente;
        private Button buttonBuscarNomeCliente;
        private Button buttonGerarRelatorio;
        private ComboBox comboBoxGerarRelatorio;
        private Label labelErro;
    }
}