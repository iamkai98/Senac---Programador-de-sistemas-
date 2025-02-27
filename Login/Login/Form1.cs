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
            string usuario = textBox1Login.Text; // string com o nome "usuário" que irá receber o que for preenchido no "text box" na frente de "login"
            string senha = textBox2Senha.Text; // string com o nome "senha" que irá receber o que for preenchido no "text box" na frente da senha 

            if ((string.IsNullOrEmpty(usuario)) && (string.IsNullOrEmpty(senha))) //uso de uma nova propriedade para tratar o erro de usuário e senha nulos ou vazios
            {
                Aviso.Text = "Usuário e senha são obrigatórios"; // se a condição acima for verdadeira, irá aparecer essa mensagem
                Aviso.ForeColor = Color.Red; //alterar cor do texto acima para vermelho
                return; //retornar para o início do código
            }
            
             if (usuario == null || usuario == "") //usuário nulo ou vazio 
            {
                Aviso.Text = "Usuario é obrigatório";// se a condição acima for verdadeira, irá aparecer essa mensagem
                Aviso.ForeColor = Color.Red; //alterar cor do texto acima para vermelho 
                return; //retornar para o início do código
            }
            
            if (senha == null || senha == "")// condição se caso a senha for nula ou não tenha nenhum caracter
            {
                Aviso.Text = "Senha é obrigatória"; //texto que irá aparecer
                Aviso.ForeColor= Color.Red;// alterar a cor do texto acima para vermelho 
                return; //retornar para o início do código

            }

            if (usuario == "kaique.pereira" && senha == "123") //senha e login devem ser correspondentes a "kaique.pereira" e "123" para ser verdadeira 
            {
                Aviso.Text = "Autenticado com sucesso";//mensagem que irá aparecer caso a condição ser verdadeira 
                Aviso.ForeColor = Color.Green;//alterar a cor do texto acima verde
            }
            else 
            {
                Aviso.Text = "Usuário ou senha incorretos";//caso o login e a senha não corresponder a condição do "else if" irá aparecer esse aviso  
                Aviso.ForeColor = Color.Red;// alterar a cor do texto acima para vermelho 
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
