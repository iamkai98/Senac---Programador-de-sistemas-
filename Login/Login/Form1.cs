namespace Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1Usuario.Text;
            string senha = textBox2Senha.Text;
            
            if (usuario == null || usuario == "")
            {
                Recebe.Text = "Usuario é obrigatório";
                Recebe.ForeColor = Color.Red;
            }

            else if (usuario == "kaique.pereira" && senha == "123")
            {
                Recebe.Text = "Autenticado com sucesso";
                Recebe.ForeColor = Color.Green;
            }
            else 
            {
                Recebe.Text = "Usuario ou senha incorretos";
                Recebe.ForeColor = Color.Red;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1Usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
