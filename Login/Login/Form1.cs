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
            string usuario = textBox1Login.Text; // string com o nome "usu�rio" que ir� receber o que for preenchido no "text box" na frente de "login"
            string senha = textBox2Senha.Text; // string com o nome "senha" que ir� receber o que for preenchido no "text box" na frente da senha 

            if ((string.IsNullOrEmpty(usuario)) && (string.IsNullOrEmpty(senha))) //uso de uma nova propriedade para tratar o erro de usu�rio e senha nulos ou vazios
            {
                Aviso.Text = "Usu�rio e senha s�o obrigat�rios"; // se a condi��o acima for verdadeira, ir� aparecer essa mensagem
                Aviso.ForeColor = Color.Red; //alterar cor do texto acima para vermelho
                return; //retornar para o in�cio do c�digo
            }
            
             if (usuario == null || usuario == "") //usu�rio nulo ou vazio 
            {
                Aviso.Text = "Usuario � obrigat�rio";// se a condi��o acima for verdadeira, ir� aparecer essa mensagem
                Aviso.ForeColor = Color.Red; //alterar cor do texto acima para vermelho 
                return; //retornar para o in�cio do c�digo
            }
            
            if (senha == null || senha == "")// condi��o se caso a senha for nula ou n�o tenha nenhum caracter
            {
                Aviso.Text = "Senha � obrigat�ria"; //texto que ir� aparecer
                Aviso.ForeColor= Color.Red;// alterar a cor do texto acima para vermelho 
                return; //retornar para o in�cio do c�digo

            }

            if (usuario == "kaique.pereira" && senha == "123") //senha e login devem ser correspondentes a "kaique.pereira" e "123" para ser verdadeira 
            {
                Aviso.Text = "Autenticado com sucesso";//mensagem que ir� aparecer caso a condi��o ser verdadeira 
                Aviso.ForeColor = Color.Green;//alterar a cor do texto acima verde
            }
            else 
            {
                Aviso.Text = "Usu�rio ou senha incorretos";//caso o login e a senha n�o corresponder a condi��o do "else if" ir� aparecer esse aviso  
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
