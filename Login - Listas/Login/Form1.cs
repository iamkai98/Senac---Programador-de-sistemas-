using MySql.Data.MySqlClient;
using System.Configuration;

namespace Login
{
    public partial class FormLogin : Form
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";
        private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);
        
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
            string usuarioBuscado = textBox1Login.Text;
            string senha = textBox2Senha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))//se o usuario for nulo ou vazio
            {
                Aviso.Text = "Usuario eh obrigatorio";
                Aviso.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                Aviso.Text = "Senha eh obrigatoria";
                Aviso.ForeColor = Color.Red;
                return;
            }

            bool autenticado = false;

            try
            {
                Connection.Open(); //abre a conex�o com o banco de dados

                string query = $"SELECT senha FROM usuario WHERE email = '{usuarioBuscado}';"; //cria��o da query com do MYSQL com o usuario buscado

                MySqlCommand mySQLCommand = new MySqlCommand(query, Connection);//cria um comando MySQL com a query definida l� no MYSQL e a conex�o
                MySqlDataReader reader = mySQLCommand.ExecuteReader(); //executa o comando e armazena o resultado na variavel reader

                autenticado = reader.Read() && reader.GetString(0) == senha; //verifica se o reader leu algum dado e se a senha do banco de dados � igual a senha digitada pelo usuario
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            
            }

            if (!autenticado)
            {
                Aviso.Text = "Usuario ou senha incorretos"; //se o usuario ou a senha estiverem incorretos ir� aparecer a mensagem "usuario ou senha incorretos" e a cor do texto ser� vermelha
                Aviso.ForeColor = Color.Red;
                return;
            }

            label1.Text = "Autenticado com sucesso!";
            label1.ForeColor = Color.Green;

            textBox1Login.Clear(); //limpa o textBox1Login
            textBox2Senha.Clear(); //limpa o textBox2Senha

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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NovoUsuario = textBox1LoginCadastro.Text; //pega o texto do textBox1LoginCadastro e armazena na variavel NovoUsuario
            string NovaSenha = textBox2SenhaCadastro.Text; //pega o texto do textBox2SenhaCadastro e armazena na variavel NovaSenha

            if (string.IsNullOrWhiteSpace(NovaSenha) || string.IsNullOrWhiteSpace(NovoUsuario)) //se a senha ou o usuario for nulo ou vazio ir� aparecer a mensagem "login e senha s�o obrigatorios"
            {
                AvisoCadastro.Text = "Login e senha s�o obrigatorios";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (NovaSenha.Length < 8) //se a senha tiver menos de 8 caracteres ir� aparecer a mensagem "senha deve ter no minimo 8 caracteres"
            {
                AvisoCadastro.Text = "Senha deve ter no minimo 8 caracteres";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (!NovaSenha.Any(char.IsUpper))//se a senha n�o tiver nenhuma letra maiuscula ir� aparecer a mensagem "senha deve ter no minimo 1 letra maiuscula"
            {
                AvisoCadastro.Text = "Senha deve ter no minimo 1 letra maiuscula";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }
            
            if (!NovaSenha.Any(char.IsLower))//se a senha n�o tiver nenhuma letra minuscula ir� aparecer a mensagem "senha deve ter no minimo 1 letra minuscula"
            {
                AvisoCadastro.Text = "Senha deve ter no m�nimo 1 letra minuscula ";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (!NovaSenha.Any(char.IsNumber))//se a senha n�o tiver nenhum numero ir� aparecer a mensagem "senha deve ter no minimo 1 numero"
            {
                AvisoCadastro.Text = "Senha deve ter no m�nimo 1 n�mero";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (NovaSenha.Any(char.IsWhiteSpace))//se a senha tiver espa�o em branco ir� aparecer a mensagem "senha n�o pode ter espa�o em branco"
            {
                AvisoCadastro.Text = "Senha n�o pode ter espa�o em branco";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

           if (!NovaSenha.Any(char.IsPunctuation))//se a senha n�o tiver nenhum caractere especial ir� aparecer a mensagem "senha deve ter no minimo 1 caractere especial"
            {
                AvisoCadastro.Text = "Senha deve ter no m�nimo 1 caractere especial";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            bool encontrado = false; 
          
           try
            {
                Connection.Open();

                string query = $"SELECT email FROM usuario WHERE email = '{NovoUsuario}';"; //cria��o da query com do MYSQL com o usuario buscado

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);//cria um comando MySQL com a query definida l� no MYSQL e a conex�o
                MySqlDataReader reader = mySqlCommand.ExecuteReader(); //executa o comando e armazena o resultado na variavel reader

                encontrado = reader.Read(); //verifica se o reader leu algum dado
            }

            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }

           if (encontrado)
            {
               AvisoCadastro.Text = "Usuario ja existe"; //se o usuario j� existir ir� aparecer a mensagem "usuario ja existe" e a cor do texto ser� vermelha
            }

           try
            {
                Connection.Open();

                string query = $"INSERT INTO usuario (email, senha) VALUES ('{NovoUsuario} ', '{NovaSenha} ');"; //cria��o da query com do MYSQL com o usuario buscado

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);//cria um comando MySQL com a query definida l� no MYSQL e a conex�o
                mySqlCommand.ExecuteNonQuery(); //executa o comando e armazena o resultado na variavel reader

                AvisoCadastro.Text = "Usuario cadastrado com sucesso"; //se o usuario for cadastrado com sucesso ir� aparecer a mensagem "usuario cadastrado com sucesso" e a cor do texto ser� verde
                textBox1LoginCadastro.Clear(); //limpa o textBox1LoginCadastro
                textBox2SenhaCadastro.Clear(); //limpa o textBox2SenhaCadastro
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }


          

        }

        private void textBox2SenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
