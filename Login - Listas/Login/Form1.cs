using System.Configuration;

namespace Login
{
    public partial class FormLogin : Form
    {
        List<string> listaEspeciais = new List<string> { "!", "@", "#", "$", "%", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", ":", ";", "<", ">", ",", ".", "?", "/", "|", "\\" };

        List<string> listaUsuarios = new List<string> { "neymar.jr", "pablo.vittar", "sukuna.silva" };
        // neymar posi��o 0 - pablo posi��o 1 - sukuna posi��o 2    
        List<string> listaSenhas = new List<string> { "marquezine", "1234", "777" };
        // marquezine posi��o 0 - 1234 posi��o 1 - 777 posi��o 2
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

            if (senha == null || senha == "")
            {
                Aviso.Text = "Senha eh obrigatoria";
                Aviso.ForeColor = Color.Red;
                return;
            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++) // primeira condi��o inicio, segunda condi��o fim, terceira condi��o incremento
            {
                if (usuarioBuscado == listaUsuarios[i])//se o usuario buscado for igual ao usuario na posi��o i
                {
                    posicaoUsuarioEncontrado = i; //s� funciona se a condi��o acima for verdadeira
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            //se a posi��o do usuario for maior que -1 e a senha for igual a senha na posi��o do usuario
            {
                Aviso.Text = "Usuario logado com sucesso";
                Aviso.ForeColor = Color.Green;
            }
            else
            {
                Aviso.Text = "Usuario ou senha incorretos";
                Aviso.ForeColor = Color.Red;
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NovoUsuario = textBox1LoginCadastro.Text;
            string NovaSenha = textBox2SenhaCadastro.Text;

            bool UsuarioEncontrado = false; //cria uma variavel booleana que � falsa

            if (string.IsNullOrWhiteSpace(NovaSenha) || string.IsNullOrWhiteSpace(NovoUsuario))
            {
                AvisoCadastro.Text = "Login e senha s�o obrigatorios";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }


            for (int i = 0; i < listaUsuarios.Count; i++) //la�o de repeti��o percorre toda a lista "listaUsuarios", de 0 at� a �ltima posi��o
            {
                if (NovoUsuario == listaUsuarios[i])//se o novo usuario for igual ao usuario na posi��o i
                {
                    UsuarioEncontrado = true; //s� funciona se a condi��o acima for verdadeira
                }
            }

            if (UsuarioEncontrado)
            {
                AvisoCadastro.Text = "Usuario ja existe";//avisa que o usuario foi cadastrado
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }
         

            if (NovaSenha.Length < 8)
            {
                AvisoCadastro.Text = "Senha deve ter no minimo 8 caracteres";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (!NovaSenha.Any(char.IsUpper))
            {
                AvisoCadastro.Text = "Senha deve ter no minimo 1 letra maiuscula";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }
            
            if (!NovaSenha.Any(char.IsLower))
            {
                AvisoCadastro.Text = "Senha deve ter no m�nimo 1 letra minuscula ";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (!NovaSenha.Any(char.IsNumber))
            {
                AvisoCadastro.Text = "Senha deve ter no m�nimo 1 n�mero";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (NovaSenha.Any(char.IsWhiteSpace))
            {
                AvisoCadastro.Text = "Senha n�o pode ter espa�o em branco";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            bool posicaoChar = false;

            for (int i = 0; i < NovaSenha.Length; i++)
            {
                if (NovaSenha.Contains(listaEspeciais[i]))
                {
                    posicaoChar = true;
                    return;
                }

            }

            if (!posicaoChar)
            {
                AvisoCadastro.Text = "Senha deve ter no m�nimo 1 caractere especial";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            listaUsuarios.Add(NovoUsuario);//adiciona o novo usuario na lista de usuarios
            listaSenhas.Add(NovaSenha);//adiciona a nova senha na lista de senhas
            AvisoCadastro.Text = "Usu�rio Cadastrado";
            AvisoCadastro.ForeColor = Color.Green;

        }

        private void textBox2SenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
