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
            EnderecoCliente EnderecoMaria = new EnderecoCliente() { Logradouro = "Rua 1", Numero = "123", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", CEP = "12345-678" };
            Cliente Maria = new Cliente() { Id = 1, Nome = "Maria Aparecida", DataNascimento = "26/09/2000", Telefone = "55 11 95687-5246", Email = "maria_aparecida@email.com", Endereco = EnderecoMaria, Genero = GeneroCliente.Feminino, NomeSocial = "", Etnia = EtniaCliente.Negra, Estrangeiro = false, Tipo = TipoCliente.PF };
            clientes.Add(Maria);

            //Cliente José
            EnderecoCliente EnderecoJose = new EnderecoCliente() { Logradouro = "Rua 2", Numero = "456", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", CEP = "12345-678" };
            Cliente Jose = new Cliente() { Id = 2, Nome = "José da Silva", DataNascimento = "15/07/1990", Telefone = "55 11 95687-5246", Email = "jose_da_silva@email.com", Endereco = EnderecoJose, Genero = GeneroCliente.Masculino, NomeSocial = "", Etnia = EtniaCliente.Indigena, Estrangeiro = false, Tipo = TipoCliente.PJ };
            clientes.Add(Jose);

            //Cliente John Marye
            EnderecoCliente EnderecoJoaoMaria = new EnderecoCliente() { Logradouro = "Rua 3", Numero = "789", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", CEP = "12345-678" };
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


        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string dataNascimento = maskedTextBoxDataNascimento.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string email = textBoxEmail.Text;
            //endereço
            //genero
            string nomeSocial = textBoxNomeSocial.Text;
            string etnia = comboBoxEtnia.Text;
            string estrangeiro = checkBoxEstrangeiro.Checked.ToString();




            string cep = maskedTextBoxCEP.Text;
            string logradouro = textBoxLogradouro.Text;
            string bairro = textBoxBairro.Text;
            string municipio = textBoxMunicipio.Text;
            string estado = textBoxEstado.Text;

             
        }
    }

}
