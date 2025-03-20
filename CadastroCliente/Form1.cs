using CadastroDeCliente;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();

            //Cliente Maria 
            EnderecoCliente EnderecoMaria = new EnderecoCliente() { Logradouro = "Rua 1", Numero = "123", Complemento = "Casa", Bairro = "Centro", Municipio = "S�o Paulo", Estado = "SP", CEP = "12345-678" };
            Cliente Maria = new Cliente() { Id = 1, Nome = "Maria Aparecida", DataNascimento = "26/09/2000", Telefone = "55 11 95687-5246", Email = "maria_aparecida@email.com", Endereco = EnderecoMaria, Genero = GeneroCliente.Feminino, NomeSocial = "", Etnia = EtniaCliente.Negra, Estrangeiro = false, Tipo = TipoCliente.PF };
            clientes.Add(Maria);

            //Cliente Jos�
            EnderecoCliente EnderecoJose = new EnderecoCliente() { Logradouro = "Rua 2", Numero = "456", Complemento = "Casa", Bairro = "Centro", Municipio = "S�o Paulo", Estado = "SP", CEP = "12345-678" };
            Cliente Jose = new Cliente() { Id = 2, Nome = "Jos� da Silva", DataNascimento = "15/07/1990", Telefone = "55 11 95687-5246", Email = "jose_da_silva@email.com", Endereco = EnderecoJose, Genero = GeneroCliente.Masculino, NomeSocial = "", Etnia = EtniaCliente.Indigena, Estrangeiro = false, Tipo = TipoCliente.PJ };
            clientes.Add(Jose);

            //Cliente John Marye
            EnderecoCliente EnderecoJoaoMaria = new EnderecoCliente() { Logradouro = "Rua 3", Numero = "789", Complemento = "Casa", Bairro = "Centro", Municipio = "S�o Paulo", Estado = "SP", CEP = "12345-678" };
            Cliente JoaoMaria = new Cliente()
            {
                Id = 789123,
                Nome = "John Marye",
                DataNascimento = "10/05/1980",
                Telefone = "55 11 95687-5246",
                Email = "josemaria@email.com",
                Endereco = EnderecoJoaoMaria,
                Genero = GeneroCliente.Masculino,
                NomeSocial = "Bonnie",
                Etnia = EtniaCliente.Branca,
                Estrangeiro = true,
                Tipo = TipoCliente.PF
            };
            clientes.Add(JoaoMaria);
        }


        public bool ValidarCampoNome() // M�todo para avaliar se os campos est�o nulos ou vazios
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelAviso.Text = "O campo nome � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxNome.Text.Any(char.IsDigit))
            {
                labelAviso.Text = "O campo nome n�o pode conter n�meros";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxNome.Text.Length < 3)
            {
                labelAviso.Text = "O campo nome deve conter no m�nimo 3 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            if (!textBoxNome.Text.Contains(" "))
            {
                labelAviso.Text = "O campo nome deve conter nome e sobrenome";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }

        public bool ValidarCampoDataNascimento() // M�todo para avaliar o campo data de nascimento  
        {
            if (!maskedTextBoxDataNascimento.MaskFull) // verifica se o campo est� preenchido completamente
            {
                labelAviso.Text = "O campo data de nascimento � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (!DateTime.TryParse(maskedTextBoxDataNascimento.Text, out DateTime dataNascimento)) // Verifica se a data � v�lida. Exemplo "32/01/2024" n�o ser� uma data v�lida.
            {
                labelAviso.Text = "Data de nascimento inv�lida";
                labelAviso.ForeColor = Color.Red;
                return false;

            }
            if (dataNascimento > DateTime.Now) // Verifica se a data de nascimento � maior que a data atual. Exemplo: "01/01/2024" n�o ser� uma data v�lida.
            {
                labelAviso.Text = "A data de nascimento n�o pode ser maior que a data atual";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            int idade = DateTime.Now.Year - dataNascimento.Year; // Calcula a idade do cliente para saber se o cliente � maior de idade
            if (idade < 18)
            {
                labelAviso.Text = "O cliente deve ser maior de idade";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            
            labelAviso.Text = "";
            return true;
        }

        public bool ValidarCampoTelefone() // M�todo para avaliar o campo telefone
        {
            if (!maskedTextBoxTelefone.MaskFull) // verifica se o campo est� preenchido completamente
            {
                labelAviso.Text = "O campo telefone � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            //if (!maskedTextBoxTelefone.Text.
            //{

            //}
            labelAviso.Text = "";
            return true;
        }

        public bool ValidarCampoEmail() // M�todo para avaliar o campo email
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text)) // verifica se o campo est� preenchido
            {
                labelAviso.Text = "O campo email � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxEmail.Text.Length < 10) // verifica se o campo tem no m�nimo 10 caracteres
            {
                labelAviso.Text = "O campo email deve conter no m�nimo 9 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            if (!textBoxEmail.Text.Contains("@")) // verifica se o campo cont�m "@"
            {
                labelAviso.Text = "O campo email deve conter @";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxEmail.Text.Contains("."))// verifica se o campo cont�m "."
            {
                labelAviso.Text = "O campo email deve conter .";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }

        public bool ValidarCampoGenero()// m�todo para avaliar o campo g�nero
        {
            if (string.IsNullOrEmpty(comboBoxGenero.Text)) // verifica se o campo est� preenchido
            {
                labelAviso.Text = "O campo g�nero � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (comboBoxGenero.SelectedIndex == 0)
            {
                labelAviso.Text = "Selecione uma op��o no campo g�nero";
            }

            labelAviso.Text = "";
            return true;
        }


        public bool ValidarNomeSocial()
        {
            if (textBoxNomeSocial.Text.Any(char.IsDigit))
            {
                labelAviso.Text = "O campo nome social n�o pode conter n�meros";
                labelAviso.ForeColor = Color.Red;
            }

            if (textBoxNomeSocial.Text.Any(char.IsLetter)) //se caso o textbox do nome social tiver alguma letra, o usu�rio deve colocar no m�nimo 3 letras 
            {
                if (textBoxNomeSocial.Text.Length < 3)
                {
                    labelAviso.Text = "O campo nome social deve conter no m�nimo 3 caracteres";
                    labelAviso.ForeColor = Color.Red;
                }
            }
            
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!ValidarCampoNome())
            {
                return;
            }

            if (!ValidarCampoDataNascimento())
            {
                return;
            }

            if (!ValidarCampoTelefone())
            {
                return;
            }

            if (!ValidarCampoEmail())
            {
                return;
            }

            if (!ValidarCampoGenero())
            {
                return;
            }
            if (!ValidarNomeSocial())
            {
                return;
            }

            string nome = textBoxNome.Text;
            string dataNascimento = maskedTextBoxDataNascimento.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string email = textBoxEmail.Text;
            bool estrangeiro = checkBoxEstrangeiro.Checked;

            string genero = comboBoxGenero.Text;
            string nomeSocial = textBoxNomeSocial.Text;
            string etnia = comboBoxEtnia.Text;

            TipoCliente tipoCliente;
            if (radioButtonTipoPF.Checked)
            {
                tipoCliente = TipoCliente.PF;
            }
            else
            {
                tipoCliente = TipoCliente.PJ;
            }

            string cep = maskedTextBoxCEP.Text;
            string logradouro = textBoxLogradouro.Text;
            string bairro = textBoxBairro.Text;
            string municipio = textBoxMunicipio.Text;
            string estado = textBoxEstado.Text;


        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}
