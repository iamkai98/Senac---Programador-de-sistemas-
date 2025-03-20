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
            Cliente Maria = new Cliente() { Id = 1, Nome = "Maria Aparecida", DataNascimento = "26/09/2000", Telefone = "11 96688-5246", Email = "maria_aparecida@email.com", Endereco = EnderecoMaria, Genero = GeneroCliente.Feminino, NomeSocial = "", Etnia = EtniaCliente.Negra, Estrangeiro = false, Tipo = TipoCliente.PF };
            clientes.Add(Maria);

            //Cliente José
            EnderecoCliente EnderecoJose = new EnderecoCliente() { Logradouro = "Rua 2", Numero = "456", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", CEP = "12345-678" };
            Cliente Jose = new Cliente() { Id = 2, Nome = "José da Silva", DataNascimento = "15/07/1990", Telefone = " 11 95687-5247", Email = "jose_da_silva@email.com", Endereco = EnderecoJose, Genero = GeneroCliente.Masculino, NomeSocial = "", Etnia = EtniaCliente.Indigena, Estrangeiro = false, Tipo = TipoCliente.PJ };
            clientes.Add(Jose);

            //Cliente John Marye
            EnderecoCliente EnderecoJoaoMaria = new EnderecoCliente() { Logradouro = "Rua 3", Numero = "789", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", CEP = "12345-678" };
            Cliente JoaoMaria = new Cliente()
            {
                Id = 789123,
                Nome = "John Marye",
                DataNascimento = "10/05/1980",
                Telefone = "11 95687-6241",
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


        public bool ValidarCampoNome() // Método para avaliar se os campos estão nulos ou vazios
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelAviso.Text = "O campo nome é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxNome.Text.Any(char.IsDigit))
            {
                labelAviso.Text = "O campo nome não pode conter números";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxNome.Text.Length < 3)
            {
                labelAviso.Text = "O campo nome deve conter no mínimo 3 caracteres";
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
        public bool ValidarCampoDataNascimento() // Método para avaliar o campo data de nascimento  
        {
            if (!maskedTextBoxDataNascimento.MaskFull) // verifica se o campo está preenchido completamente
            {
                labelAviso.Text = "O campo data de nascimento é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            string DataNascimentoValida = maskedTextBoxDataNascimento.Text.Replace("/", "").Replace(" ", "").Trim();

            if (DataNascimentoValida.Distinct().Count() == 1) //
            {
                labelAviso.Text = "O campo data de nascimento não pode conter todos os dígitos repetidos";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            if (!DateTime.TryParse(maskedTextBoxDataNascimento.Text, out DateTime dataNascimento)) // Verifica se a data é válida. Exemplo "32/01/2024" não será uma data válida.
            {
                labelAviso.Text = "Data de nascimento inválida";
                labelAviso.ForeColor = Color.Red;
                return false;

            }
            if (dataNascimento > DateTime.Now) // Verifica se a data de nascimento é maior que a data atual. Exemplo: "01/01/2024" não será uma data válida.
            {
                labelAviso.Text = "A data de nascimento não pode ser maior que a data atual";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            int idade = DateTime.Now.Year - dataNascimento.Year; // Calcula a idade do cliente para saber se o cliente é maior de idade
            if (idade < 18)
            {
                labelAviso.Text = "O cliente deve ser maior de idade";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            labelAviso.Text = "";
            return true;
            //método Distict.().Count() tem a função de contar quantos valores únicos existem euma coleção 
            // Distinct = remove os número repetidos, matendo apenas os diferentes
            // Count = conta quantos números únicos restaram
            // ==1 se sóbrou 1 número único, significa que o usuário digitou o mesmo número repetido várias vezes
        }
        public bool ValidarCampoTelefone() // Método para avaliar o campo telefone
        {
            if (!maskedTextBoxTelefone.MaskFull) // verifica se o campo está preenchido completamente
            {
                labelAviso.Text = "O campo telefone é obrigatório, preencha corretamente";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            string verificarNumerorepetido = maskedTextBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
            if (verificarNumerorepetido.Distinct().Count() == 1)
            {
                labelAviso.Text = "O campo número de telefone não pode conter todos os dígitos repetidos";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
            //método Distict.().Count() tem a função de contar quantos valores únicos existem euma coleção 
            // Distinct = remove os número repetidos, matendo apenas os diferentes
            // Count = conta quantos números únicos restaram
            // ==1 se sóbrou 1 número único, significa que o usuário digitou o mesmo número repetido várias vezes
        }
        public bool ValidarCampoEmail() // Método para avaliar o campo email
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text)) // verifica se o campo está preenchido
            {
                labelAviso.Text = "O campo email é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxEmail.Text.Length < 10) // verifica se o campo tem no mínimo 9 caracteres
            {
                labelAviso.Text = "O campo email deve conter no mínimo 9 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            if (!textBoxEmail.Text.Contains("@")) // verifica se o campo contém "@"
            {
                labelAviso.Text = "O campo email deve conter '@'";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxEmail.Text.Contains("."))// verifica se o campo contém "."
            {
                labelAviso.Text = "O campo email deve conter '.'";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }
        public bool ValidarCampoGenero()// Método para avaliar o campo gênero
        {
            if (string.IsNullOrEmpty(comboBoxGenero.Text)) // verifica se o campo está preenchido com pelo menos uma opção do comboBox
            {
                labelAviso.Text = "O campo gênero é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }
        public bool ValidarEtnia() // Método para avaliar o campo etnia
        {
            if (string.IsNullOrWhiteSpace(comboBoxEtnia.Text)) //verifica se o campo está nulo ou com espaços em branco 
            {
                labelAviso.Text = "O campo etnia é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        public bool ValidarNomeSocial() //Método para avaliar o campo nome social 
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeSocial.Text))
            {
                return true; //se caso não for selelcionado retorna true, já que não é obrigatório  
            }

            if (textBoxNomeSocial.Text.Any(char.IsDigit)) // se caso o usuário digitar algo, não será permitido números
            {
                labelAviso.Text = "O campo nome social não pode conter números";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            if (textBoxNomeSocial.Text.Length < 3)// se o usuário digitar algo, o texbox irá permitir no mínimo 3 caracteres 
            {
                labelAviso.Text = "O campo nome social deve conter no mínimo 3 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }
        public bool ValidarTipo() //Método para avaliar o campo tipo 
        {
            if (!radioButtonTipoPF.Checked && !radioButtonTipoPJ.Checked)
            {
                labelAviso.Text = "Escolha uma das opções no campo tipo";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }
        public bool ValidarEstrangeiro() //Método para avaliar o campo estrangeiro 
        {
            return true;
        }
        public bool ValidarCep()
        {
            string CEP = maskedTextBoxCEP.Text.Replace("-", "").Trim(); // "Replace" é um método que remove o traço, deixando apenas os números do campo CEP
                                                                        // "Trim" é um método que remove espaços extras ao redor do texto 

            if (!maskedTextBoxCEP.MaskFull)
            {
                labelAviso.Text = "O campo CEP é obrigatório, preencha corretamente";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (CEP.Distinct().Count() == 1)
            {
                labelAviso.Text = "O campo CEP não pode conter todos os dígitos repetidos";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;

            //método Distict.().Count() tem a função de contar quantos valores únicos existem euma coleção 
            // Distinct = remove os número repetidos, matendo apenas os diferentes
            // Count = conta quantos números únicos restaram
            // ==1 se sóbrou 1 número único, significa que o usuário digitou o mesmo número repetido várias vezes
        }
        public bool ValidarMunicipio()
        {
            if (string.IsNullOrWhiteSpace(textBoxMunicipio.Text))
            {
                labelAviso.Text = "O campo município é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            if (textBoxMunicipio.Text.Length < 4)
            {
                labelAviso.Text = "O campo município deve ter no mínimo 4 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        public bool ValidarEstado()
        {
            if (string.IsNullOrWhiteSpace(comboBoxEstado.Text))
            {
                labelAviso.Text = "O campo estado é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            if(comboBoxEstado.Text.Any(char.IsNumber))
            {
                labelAviso.Text = "O campo estado não pode ter número";
                labelAviso.ForeColor = Color.Red; 
                return false;
            }
            if (comboBoxEstado.Text.Length < 4)
            {
                labelAviso.Text = "O campo estado deve ter no mínimo 4 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        public bool ValidarBairro()
        {
            if (string.IsNullOrWhiteSpace(textBoxBairro.Text))
            {
                labelAviso.Text = "O campo bairro é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxBairro.Text.Length < 3)
            {
                labelAviso.Text = "O campo estado deve ter no mínimo 3 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if(textBoxBairro.Text.Any(char.IsNumber))
            {
                labelAviso.Text = "Digite um bairro válido (ex:Jardim Guarujá, Centro, Santo Amaro";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        public bool ValidarLogradouro()
        {
            if (string.IsNullOrWhiteSpace(textBoxLogradouro.Text))
            {
                labelAviso.Text = "O campo logradouro é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxLogradouro.Text.Length < 4)
            {
                labelAviso.Text = "O campo logradouro deve ter no mínimo 4 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxLogradouro.Text.Any(char.IsNumber))
            {
                labelAviso.Text = "Digite um logradouro válido (ex:Avenida Brasil)";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        public bool ValidarNumero()
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero.Text))
            {
                labelAviso.Text = "O campo numero é obrigatório";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (!textBoxNumero.Text.Any(char.IsNumber) || textBoxNumero.Text.Length > 6)
            {
                labelAviso.Text = "Digite um número de residência válido";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        public bool ValidarComplemento()
        {

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!ValidarCampoNome() ||
                !ValidarCampoDataNascimento() ||
                !ValidarCampoTelefone() ||
                !ValidarCampoEmail() ||
                !ValidarCampoGenero() ||
                !ValidarEtnia() ||
                !ValidarNomeSocial() ||
                !ValidarTipo() ||
                !ValidarEstrangeiro() ||
                !ValidarCep() ||
                !ValidarMunicipio() ||
                !ValidarEstado() ||
                !ValidarBairro() ||
                !ValidarLogradouro() ||
                !ValidarNumero() ||
                !ValidarComplemento())
            {
                return;
            }


            int ID;
            string nome = textBoxNome.Text;
            string dataNascimento = maskedTextBoxDataNascimento.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string email = textBoxEmail.Text;
            string genero = comboBoxGenero.Text;

            EtniaCliente etniaCliente = (EtniaCliente)comboBoxEtnia.SelectedItem;

            string nomeSocial = textBoxNomeSocial.Text;
            TipoCliente tipoCliente;
            if (radioButtonTipoPF.Checked)
            {
                tipoCliente = TipoCliente.PF;
            }
            else
            {
                tipoCliente = TipoCliente.PJ;
            }

            bool estrangeiro = checkBoxEstrangeiro.Checked;

            string cep = maskedTextBoxCEP.Text;
            string municipio = textBoxMunicipio.Text;

            string estado = comboBoxEstado.SelectedItem?.ToString();

            string logradouro = textBoxLogradouro.Text;
            string bairro = textBoxBairro.Text;

            bool EmailEncontrado = false;
            bool TelefoneEncontrado = false;
 

            for (int i = 0; i < clientes.Count; i++)
            {
                if (email == clientes[i].Email)
                {
                    EmailEncontrado = true;
                    break;
                    
                }
                if (telefone == clientes[i].Telefone)
                {
                    TelefoneEncontrado = true;
                    break;
                }
            }
            if (!EmailEncontrado)
            {
                labelAviso.Text = "Email cadastrado";
            }
            else if (!TelefoneEncontrado)
            {
                labelAviso.Text = "Telefone cadastrado";
            }
            else
            {
                labelAviso.Text = ""
            }
        }
        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}
