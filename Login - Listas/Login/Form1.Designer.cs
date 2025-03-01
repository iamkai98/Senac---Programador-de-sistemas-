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
            button2 = new Button();
            textBox1LoginCadastro = new TextBox();
            textBox2SenhaCadastro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AvisoCadastro = new Label();
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
            // button2
            // 
            button2.Location = new Point(1388, 338);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1LoginCadastro
            // 
            textBox1LoginCadastro.Location = new Point(1347, 255);
            textBox1LoginCadastro.Name = "textBox1LoginCadastro";
            textBox1LoginCadastro.Size = new Size(151, 23);
            textBox1LoginCadastro.TabIndex = 9;
            // 
            // textBox2SenhaCadastro
            // 
            textBox2SenhaCadastro.Location = new Point(1347, 296);
            textBox2SenhaCadastro.Name = "textBox2SenhaCadastro";
            textBox2SenhaCadastro.Size = new Size(151, 23);
            textBox2SenhaCadastro.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1294, 258);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "Login:";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1292, 299);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 12;
            label2.Text = "Senha:";
            // 
            // AvisoCadastro
            // 
            AvisoCadastro.AutoSize = true;
            AvisoCadastro.Location = new Point(1414, 385);
            AvisoCadastro.Name = "AvisoCadastro";
            AvisoCadastro.Size = new Size(38, 15);
            AvisoCadastro.TabIndex = 13;
            AvisoCadastro.Text = "label3";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1764, 585);
            Controls.Add(AvisoCadastro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2SenhaCadastro);
            Controls.Add(textBox1LoginCadastro);
            Controls.Add(button2);
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
        private Button button2;
        private TextBox textBox1LoginCadastro;
        private TextBox textBox2SenhaCadastro;
        private Label label1;
        private Label label2;
        private Label AvisoCadastro;
    }
}
