namespace Login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textBox1Login = new TextBox();
            textBox2Senha = new TextBox();
            button1 = new Button();
            labelLogin = new Label();
            labelSenha = new Label();
            labelEsqueceuSuaSenha = new Label();
            Aviso = new Label();
            SuspendLayout();
            // 
            // textBox1Login
            // 
            textBox1Login.Location = new Point(420, 217);
            textBox1Login.Name = "textBox1Login";
            textBox1Login.Size = new Size(190, 23);
            textBox1Login.TabIndex = 0;
            textBox1Login.TextChanged += textBox1Usuario_TextChanged;
            // 
            // textBox2Senha
            // 
            textBox2Senha.Location = new Point(420, 255);
            textBox2Senha.Name = "textBox2Senha";
            textBox2Senha.Size = new Size(190, 23);
            textBox2Senha.TabIndex = 1;
            textBox2Senha.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(474, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.FlatStyle = FlatStyle.Popup;
            labelLogin.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(374, 219);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(40, 16);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Login:";
            labelLogin.Click += label1_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.BackColor = Color.Transparent;
            labelSenha.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSenha.ForeColor = Color.White;
            labelSenha.Location = new Point(374, 257);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(44, 16);
            labelSenha.TabIndex = 4;
            labelSenha.Text = "Senha:";
            // 
            // labelEsqueceuSuaSenha
            // 
            labelEsqueceuSuaSenha.AutoSize = true;
            labelEsqueceuSuaSenha.BackColor = Color.Transparent;
            labelEsqueceuSuaSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelEsqueceuSuaSenha.ForeColor = Color.White;
            labelEsqueceuSuaSenha.Location = new Point(459, 342);
            labelEsqueceuSuaSenha.Name = "labelEsqueceuSuaSenha";
            labelEsqueceuSuaSenha.Size = new Size(108, 15);
            labelEsqueceuSuaSenha.TabIndex = 6;
            labelEsqueceuSuaSenha.Text = "Esqueceu a senha?";
            labelEsqueceuSuaSenha.Click += label4_Click;
            // 
            // Aviso
            // 
            Aviso.AutoSize = true;
            Aviso.BackColor = Color.Transparent;
            Aviso.ForeColor = Color.White;
            Aviso.Location = new Point(474, 385);
            Aviso.Name = "Aviso";
            Aviso.Size = new Size(38, 15);
            Aviso.TabIndex = 7;
            Aviso.Text = "label1";
            Aviso.Click += label1_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1014, 585);
            Controls.Add(Aviso);
            Controls.Add(labelEsqueceuSuaSenha);
            Controls.Add(labelSenha);
            Controls.Add(labelLogin);
            Controls.Add(button1);
            Controls.Add(textBox2Senha);
            Controls.Add(textBox1Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1Login;
        private TextBox textBox2Senha;
        private Button button1;
        private Label labelLogin;
        private Label labelSenha;
        private Label labelEsqueceuSuaSenha;
        private Label Aviso;
    }
}
