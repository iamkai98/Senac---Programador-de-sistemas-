namespace Login
{
    public partial class FormLogin : Form
    {
        List<string> listaUsuarios = new List<string> { "neymar.jr", "pablo.vittar", "sukuna.silva" };
        // neymar posição 0 - pablo posição 1 - sukuna posição 2    
        List<string> listaSenhas = new List<string> { "marquezine", "1234", "777" };
        // marquezine posição 0 - 1234 posição 1 - 777 posição 2
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
            string NovoUsuario = textBox1LoginCadastro.Text;
            string NovaSenha = textBox2SenhaCadastro.Text;

            bool UsuarioEncontrado = false; //cria uma variavel booleana que é falsa

            for (int i = 0; i < listaUsuarios.Count; i++) // primeira condição inicio, segunda condição fim, terceira condição incremento
            {
                if (NovoUsuario == listaUsuarios[i])//se o usuario buscado for igual ao usuario na posição i
                {
                    UsuarioEncontrado = true; //só funciona se a condição acima for verdadeira
                }
            }
            if (!UsuarioEncontrado)
            {
                listaUsuarios.Add(NovoUsuario);//adiciona o novo usuario na lista de usuarios
                listaSenhas.Add(NovaSenha);//adiciona a nova senha na lista de senhas
                AvisoCadastro.Text = "Usuario cadastrado com sucesso";//avisa que o usuario foi cadastrado
                AvisoCadastro.ForeColor = Color.Green;
            }
            else
            {
                AvisoCadastro.Text = "Usuario ja cadastrado";
                AvisoCadastro.ForeColor = Color.Red;

            }
        }
    }
}
