namespace InterfaceProjeto
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            buttonCriarPedido = new Button();
            label1 = new Label();
            buttonCriarCliente = new Button();
            buttonEditarPedido = new Button();
            buttonRelatorio = new Button();
            pictureBoxSetaCriarPedido = new PictureBox();
            pictureBoxSetaCriarCliente = new PictureBox();
            pictureBoxSetaEditarPedido = new PictureBox();
            pictureBoxSetaRelatorios = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetaCriarPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetaCriarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetaEditarPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetaRelatorios).BeginInit();
            SuspendLayout();
            // 
            // buttonCriarPedido
            // 
            buttonCriarPedido.Anchor = AnchorStyles.None;
            buttonCriarPedido.BackColor = Color.Transparent;
            buttonCriarPedido.Cursor = Cursors.Hand;
            buttonCriarPedido.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonCriarPedido.FlatStyle = FlatStyle.Flat;
            buttonCriarPedido.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonCriarPedido.ForeColor = Color.AliceBlue;
            buttonCriarPedido.Location = new Point(521, 376);
            buttonCriarPedido.Name = "buttonCriarPedido";
            buttonCriarPedido.Size = new Size(344, 150);
            buttonCriarPedido.TabIndex = 0;
            buttonCriarPedido.Text = "Criar pedido";
            buttonCriarPedido.UseVisualStyleBackColor = false;
            buttonCriarPedido.Click += buttonCriarPedido_Click;
            buttonCriarPedido.MouseEnter += buttonCriarPedido_MouseEnter;
            buttonCriarPedido.MouseLeave += buttonCriarPedido_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(915, 1013);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // buttonCriarCliente
            // 
            buttonCriarCliente.Anchor = AnchorStyles.None;
            buttonCriarCliente.BackColor = Color.Transparent;
            buttonCriarCliente.Cursor = Cursors.Hand;
            buttonCriarCliente.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonCriarCliente.FlatStyle = FlatStyle.Flat;
            buttonCriarCliente.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCriarCliente.ForeColor = Color.White;
            buttonCriarCliente.Location = new Point(521, 544);
            buttonCriarCliente.Name = "buttonCriarCliente";
            buttonCriarCliente.Size = new Size(344, 150);
            buttonCriarCliente.TabIndex = 2;
            buttonCriarCliente.Text = "Criar Cliente\r\n";
            buttonCriarCliente.UseVisualStyleBackColor = false;
            buttonCriarCliente.Click += buttonCriarCliente_Click;
            buttonCriarCliente.MouseEnter += buttonCriarCliente_MouseEnter;
            buttonCriarCliente.MouseLeave += buttonCriarCliente_MouseLeave;
            // 
            // buttonEditarPedido
            // 
            buttonEditarPedido.Anchor = AnchorStyles.None;
            buttonEditarPedido.BackColor = Color.Transparent;
            buttonEditarPedido.Cursor = Cursors.Hand;
            buttonEditarPedido.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonEditarPedido.FlatStyle = FlatStyle.Flat;
            buttonEditarPedido.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonEditarPedido.ForeColor = Color.White;
            buttonEditarPedido.Location = new Point(1024, 376);
            buttonEditarPedido.Name = "buttonEditarPedido";
            buttonEditarPedido.Size = new Size(344, 150);
            buttonEditarPedido.TabIndex = 3;
            buttonEditarPedido.Text = "Editar pedido ";
            buttonEditarPedido.UseVisualStyleBackColor = false;
            buttonEditarPedido.Click += buttonEditarPedido_Click;
            buttonEditarPedido.MouseEnter += buttonEditarPedido_MouseEnter;
            buttonEditarPedido.MouseLeave += buttonEditarPedido_MouseLeave;
            // 
            // buttonRelatorio
            // 
            buttonRelatorio.Anchor = AnchorStyles.None;
            buttonRelatorio.BackColor = Color.Transparent;
            buttonRelatorio.Cursor = Cursors.Hand;
            buttonRelatorio.FlatAppearance.MouseOverBackColor = Color.HotPink;
            buttonRelatorio.FlatStyle = FlatStyle.Flat;
            buttonRelatorio.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRelatorio.ForeColor = Color.White;
            buttonRelatorio.Location = new Point(1024, 544);
            buttonRelatorio.Name = "buttonRelatorio";
            buttonRelatorio.Size = new Size(344, 150);
            buttonRelatorio.TabIndex = 4;
            buttonRelatorio.Text = "Relatórios";
            buttonRelatorio.UseVisualStyleBackColor = false;
            buttonRelatorio.Click += buttonRelatorio_Click;
            buttonRelatorio.MouseEnter += buttonRelatorio_MouseEnter;
            buttonRelatorio.MouseLeave += buttonRelatorio_MouseLeave;
            // 
            // pictureBoxSetaCriarPedido
            // 
            pictureBoxSetaCriarPedido.BackColor = Color.Transparent;
            pictureBoxSetaCriarPedido.Image = (Image)resources.GetObject("pictureBoxSetaCriarPedido.Image");
            pictureBoxSetaCriarPedido.Location = new Point(392, 386);
            pictureBoxSetaCriarPedido.Name = "pictureBoxSetaCriarPedido";
            pictureBoxSetaCriarPedido.Size = new Size(128, 79);
            pictureBoxSetaCriarPedido.TabIndex = 5;
            pictureBoxSetaCriarPedido.TabStop = false;
            // 
            // pictureBoxSetaCriarCliente
            // 
            pictureBoxSetaCriarCliente.BackColor = Color.Transparent;
            pictureBoxSetaCriarCliente.Image = (Image)resources.GetObject("pictureBoxSetaCriarCliente.Image");
            pictureBoxSetaCriarCliente.Location = new Point(392, 571);
            pictureBoxSetaCriarCliente.Name = "pictureBoxSetaCriarCliente";
            pictureBoxSetaCriarCliente.Size = new Size(128, 79);
            pictureBoxSetaCriarCliente.TabIndex = 6;
            pictureBoxSetaCriarCliente.TabStop = false;
            // 
            // pictureBoxSetaEditarPedido
            // 
            pictureBoxSetaEditarPedido.Anchor = AnchorStyles.None;
            pictureBoxSetaEditarPedido.BackColor = Color.Transparent;
            pictureBoxSetaEditarPedido.Image = (Image)resources.GetObject("pictureBoxSetaEditarPedido.Image");
            pictureBoxSetaEditarPedido.Location = new Point(889, 395);
            pictureBoxSetaEditarPedido.Name = "pictureBoxSetaEditarPedido";
            pictureBoxSetaEditarPedido.Size = new Size(129, 79);
            pictureBoxSetaEditarPedido.TabIndex = 7;
            pictureBoxSetaEditarPedido.TabStop = false;
            // 
            // pictureBoxSetaRelatorios
            // 
            pictureBoxSetaRelatorios.Anchor = AnchorStyles.None;
            pictureBoxSetaRelatorios.BackColor = Color.Transparent;
            pictureBoxSetaRelatorios.Image = (Image)resources.GetObject("pictureBoxSetaRelatorios.Image");
            pictureBoxSetaRelatorios.Location = new Point(889, 571);
            pictureBoxSetaRelatorios.Name = "pictureBoxSetaRelatorios";
            pictureBoxSetaRelatorios.Size = new Size(119, 79);
            pictureBoxSetaRelatorios.TabIndex = 8;
            pictureBoxSetaRelatorios.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1900, 1037);
            Controls.Add(pictureBoxSetaRelatorios);
            Controls.Add(pictureBoxSetaEditarPedido);
            Controls.Add(pictureBoxSetaCriarCliente);
            Controls.Add(pictureBoxSetaCriarPedido);
            Controls.Add(buttonCriarPedido);
            Controls.Add(buttonRelatorio);
            Controls.Add(buttonEditarPedido);
            Controls.Add(buttonCriarCliente);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetaCriarPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetaCriarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetaEditarPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSetaRelatorios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCriarPedido;
        private Label label1;
        private Button buttonCriarCliente;
        private Button buttonEditarPedido;
        private Button buttonRelatorio;
        private PictureBox pictureBoxSetaCriarPedido;
        private PictureBox pictureBoxSetaCriarCliente;
        private PictureBox pictureBoxSetaEditarPedido;
        private PictureBox pictureBoxSetaRelatorios;
    }
}
