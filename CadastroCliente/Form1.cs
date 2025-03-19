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
            if (string.IsNullOrEmpty(textBoxNome.Text))
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

            if(!textBoxNome.Text.Contains(" "))
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
            if (string.IsNullOrEmpty(maskedTextBoxDataNascimento.Text))
            {
                labelAviso.Text = "O campo data de nascimento � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }

        public bool ValidarCampoTelefone() // M�todo para avaliar o campo telefone
        {
            if (string.IsNullOrEmpty(maskedTextBoxTelefone.Text))
            {
                labelAviso.Text = "O campo telefone � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }

        public bool ValidarCampoEmail() // M�todo para avaliar o campo email
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                labelAviso.Text = "O campo email � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxEmail.Text.Contains("@"))
            {
                labelAviso.Text = "O campo email deve conter @";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxEmail.Text.Contains("."))
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
            if (string.IsNullOrEmpty(comboBoxGenero.Text))
            {
                labelAviso.Text = "O campo g�nero � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
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
    }

}
