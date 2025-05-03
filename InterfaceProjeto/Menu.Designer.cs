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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCriarPedido
            // 
            buttonCriarPedido.Cursor = Cursors.Hand;
            buttonCriarPedido.FlatAppearance.BorderSize = 0;
            buttonCriarPedido.FlatStyle = FlatStyle.Flat;
            buttonCriarPedido.Location = new Point(97, 176);
            buttonCriarPedido.Name = "buttonCriarPedido";
            buttonCriarPedido.Size = new Size(206, 113);
            buttonCriarPedido.TabIndex = 0;
            buttonCriarPedido.Text = "Criar pedido";
            buttonCriarPedido.UseVisualStyleBackColor = true;
            buttonCriarPedido.Click += buttonCriarPedido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 426);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // buttonCriarCliente
            // 
            buttonCriarCliente.Cursor = Cursors.Hand;
            buttonCriarCliente.FlatAppearance.BorderSize = 0;
            buttonCriarCliente.FlatStyle = FlatStyle.Flat;
            buttonCriarCliente.Location = new Point(309, 176);
            buttonCriarCliente.Name = "buttonCriarCliente";
            buttonCriarCliente.Size = new Size(206, 113);
            buttonCriarCliente.TabIndex = 2;
            buttonCriarCliente.Text = "Criar cliente";
            buttonCriarCliente.UseVisualStyleBackColor = true;
            buttonCriarCliente.Click += buttonCriarCliente_Click;
            // 
            // buttonEditarPedido
            // 
            buttonEditarPedido.Cursor = Cursors.Hand;
            buttonEditarPedido.FlatAppearance.BorderSize = 0;
            buttonEditarPedido.FlatStyle = FlatStyle.Flat;
            buttonEditarPedido.Location = new Point(521, 176);
            buttonEditarPedido.Name = "buttonEditarPedido";
            buttonEditarPedido.Size = new Size(206, 113);
            buttonEditarPedido.TabIndex = 3;
            buttonEditarPedido.Text = "Editar pedido ";
            buttonEditarPedido.UseVisualStyleBackColor = true;
            buttonEditarPedido.Click += buttonEditarPedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dd2oj85_b5bab19d_e110_4f51_ae2b_ca39dd6d8d74;
            pictureBox1.Location = new Point(351, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonEditarPedido);
            Controls.Add(buttonCriarCliente);
            Controls.Add(label1);
            Controls.Add(buttonCriarPedido);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCriarPedido;
        private Label label1;
        private Button buttonCriarCliente;
        private Button buttonEditarPedido;
        private PictureBox pictureBox1;
    }
}
