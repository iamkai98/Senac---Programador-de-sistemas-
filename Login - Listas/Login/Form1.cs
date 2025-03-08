using System.Configuration;

namespace Login
{
    public partial class FormLogin : Form
    {
        Usuario neymar = new Usuario() { Email = "neymar.jr@email.com", Senha = "Brun@123" };
        Usuario pablo = new Usuario() { Email = "pablo.vitar@email.com", Senha = "12345Abc!" };
        Usuario sukuna = new Usuario() { Email = "sukuna.silva@email.com", Senha = "Sete7Sete!" };


        List<Usuario> usuarios = new List<Usuario>();
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

            int posicaoUsuarioEncontrado = listaUsuarios.IndexOf(usuarioBuscado);

            for (int i = 0; i < listaUsuarios.Count; i++) // primeira condição inicio, segunda condição fim, terceira condição incremento
            {
                if (usuarioBuscado == listaUsuarios[i])//se o usuario buscado for igual ao usuario na posição i
                {
                    posicaoUsuarioEncontrado = i; //só funciona se a condição acima for verdadeira
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            //se a posição do usuario for maior que -1 e a senha for igual a senha na posição do usuario
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
            string NovoUsuario = textBox1LoginCadastro.Text; //pega o texto do textBox1LoginCadastro e armazena na variavel NovoUsuario
            string NovaSenha = textBox2SenhaCadastro.Text; //pega o texto do textBox2SenhaCadastro e armazena na variavel NovaSenha

            if (string.IsNullOrWhiteSpace(NovaSenha) || string.IsNullOrWhiteSpace(NovoUsuario)) //se a senha ou o usuario for nulo ou vazio irá aparecer a mensagem "login e senha são obrigatorios"
            {
                AvisoCadastro.Text = "Login e senha são obrigatorios";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (NovaSenha.Length < 8) //se a senha tiver menos de 8 caracteres irá aparecer a mensagem "senha deve ter no minimo 8 caracteres"
            {
                AvisoCadastro.Text = "Senha deve ter no minimo 8 caracteres";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (!NovaSenha.Any(char.IsUpper))//se a senha não tiver nenhuma letra maiuscula irá aparecer a mensagem "senha deve ter no minimo 1 letra maiuscula"
            {
                AvisoCadastro.Text = "Senha deve ter no minimo 1 letra maiuscula";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }
            
            if (!NovaSenha.Any(char.IsLower))//se a senha não tiver nenhuma letra minuscula irá aparecer a mensagem "senha deve ter no minimo 1 letra minuscula"
            {
                AvisoCadastro.Text = "Senha deve ter no mínimo 1 letra minuscula ";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (!NovaSenha.Any(char.IsNumber))//se a senha não tiver nenhum numero irá aparecer a mensagem "senha deve ter no minimo 1 numero"
            {
                AvisoCadastro.Text = "Senha deve ter no mínimo 1 número";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (NovaSenha.Any(char.IsWhiteSpace))//se a senha tiver espaço em branco irá aparecer a mensagem "senha não pode ter espaço em branco"
            {
                AvisoCadastro.Text = "Senha não pode ter espaço em branco";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

           if (!NovaSenha.Any(char.IsPunctuation))//se a senha não tiver nenhum caractere especial irá aparecer a mensagem "senha deve ter no minimo 1 caractere especial"
            {
                AvisoCadastro.Text = "Senha deve ter no mínimo 1 caractere especial";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            if (listaUsuarios.Contains(NovoUsuario))//se a lista de usuarios contiver o novo usuario irá aparecer a mensagem "usuário já cadastrado" e a cor do texto será vermelha
            {
                AvisoCadastro.Text = "Usuário já cadastrado";
                AvisoCadastro.ForeColor = Color.Red;
                return;
            }

            listaUsuarios.Add(NovoUsuario);//adiciona o novo usuario na lista de usuarios
            listaSenhas.Add(NovaSenha);//adiciona a nova senha na lista de senhas
            AvisoCadastro.Text = "Usuário Cadastrado";
            AvisoCadastro.ForeColor = Color.Green;
            textBox1LoginCadastro.Clear();//limpa o textBox1LoginCadastro
            textBox2SenhaCadastro.Clear();//limpa o textBox2SenhaCadastro

        }

        private void textBox2SenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
