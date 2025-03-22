using CadastroDeCliente;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Clientes> clientes = new List<Clientes>();
        private readonly BindingSource BindingSource = [];


        public Form1()
        {
            InitializeComponent();


            //Cliente Maria 
            EnderecoCliente EnderecoMaria = new EnderecoCliente() { Logradouro = "Rua 1", Numero = "123", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", CEP = "12345-678" };
            Clientes Maria = new Clientes() { Id = 1, Nome = "Maria Aparecida", DataNascimento = "26/09/2000", Telefone = "11966885246", Email = "maria_aparecida@email.com", Endereco = EnderecoMaria, Genero = GeneroCliente.Feminino, NomeSocial = "", Etnia = EtniaCliente.Negra, Estrangeiro = false, Tipo = TipoCliente.PF };
            clientes.Add(Maria);

            //Cliente José
            EnderecoCliente EnderecoJose = new EnderecoCliente() { Logradouro = "Rua 2", Numero = "456", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", CEP = "12345-678" };
            Clientes Jose = new Clientes() { Id = 2, Nome = "José da Silva", DataNascimento = "15/07/1990", Telefone = "11956875247", Email = "jose_da_silva@email.com", Endereco = EnderecoJose, Genero = GeneroCliente.Masculino, NomeSocial = "", Etnia = EtniaCliente.Indigena, Estrangeiro = false, Tipo = TipoCliente.PJ };
            clientes.Add(Jose);

            //Cliente John Marye
            EnderecoCliente EnderecoJoaoMaria = new EnderecoCliente() { Logradouro = "Rua 3", Numero = "789", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", CEP = "12345-678" };
            Clientes JoaoMaria = new Clientes()
            {
                Id = 3,
                Nome = "John Marye",
                DataNascimento = "10/05/1980",
                Telefone = "11956876241",
                Email = "josemaria@email.com",
                Endereco = EnderecoJoaoMaria,
                Genero = GeneroCliente.Masculino,
                NomeSocial = "Bonnie",
                Etnia = EtniaCliente.Branca,
                Estrangeiro = true,
                Tipo = TipoCliente.PF
            };
            clientes.Add(JoaoMaria);
            
            BindingSource.DataSource = clientes;
            dataGridViewTabelaClientes.DataSource = BindingSource;
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

            for (int i = 0; i < clientes.Count; i++)
            {
                if (verificarNumerorepetido == clientes[i].Telefone)
                {
                    labelAviso.Text = "Este número já está em uso";
                    labelAviso.ForeColor = Color.Red;
                    return false;
                }
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

            for (int i = 0; i < clientes.Count; i++)
            {
                if (textBoxEmail.Text == clientes[i].Email)
                {

                    labelAviso.Text = "Este email já está cadastrado";
                    labelAviso.ForeColor = Color.Red;
                    return false;
                }
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
        public bool ValidarCep() //Método para avaliar o campo CEP 
        {
            string CEP = maskedTextBoxCEP.Text.Replace("-", "").Trim(); // "Replace" é um método que remove o traço, deixando apenas os números do campo CEP
                                                                        // "Trim" é um método que remove espaços extras ao redor do texto 

            if (!maskedTextBoxCEP.MaskFull)//analisa se todo o campo do masked está preenchido
            {
                labelAviso.Text = "O campo CEP é obrigatório, preencha corretamente";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (CEP.Distinct().Count() == 1)// confere se todos os número dentro do textbox são iguais 
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
        public bool ValidarMunicipio() //Método para avaliar o campo municipio 
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
        public bool ValidarEstado() //Método para avaliar o campo estado
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

        public bool ValidarBairro() //Método para avaliar o campo bairro
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
        public bool ValidarLogradouro() // método para avaliar o campo logradouro
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
        public bool ValidarNumero() //método para avaliar o numero
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
        public bool ValidarComplemento() // método para avaliar o complemento
        {

            return true;
        }

        public bool ValidarCadastro()
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
                return false;
            } 
            return true;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCadastro())
            {
                return;
            }
            
            int NovoID = 1;
            while (clientes.Any(c => c.Id == NovoID))
            {
                NovoID++;  
            }

            string NovoNome = textBoxNome.Text;
            string NovoDataNascimento = maskedTextBoxDataNascimento.Text;
            string NovoTelefone = maskedTextBoxTelefone.Text;
            string NovoEmail = textBoxEmail.Text;
            GeneroCliente NovoGenero = (GeneroCliente)comboBoxGenero.SelectedIndex;
            EtniaCliente NovoEtniaCliente = (EtniaCliente)comboBoxEtnia.SelectedIndex;
            string NovoNomeSocial = textBoxNomeSocial.Text;
            TipoCliente NovoTipoCliente;
            if (radioButtonTipoPF.Checked)
            {
                NovoTipoCliente = TipoCliente.PF;
            }
            else
            {
                NovoTipoCliente = TipoCliente.PJ;
            }

            bool NovoEstrangeiro = checkBoxEstrangeiro.Checked;

            EnderecoCliente NovoEndereco = new EnderecoCliente();
            {
                string NovoCep = maskedTextBoxCEP.Text;
                string NovoMunicipio = textBoxMunicipio.Text;
                string NovoLogradouro = textBoxLogradouro.Text;
                string NovoBairro = textBoxBairro.Text;
            }

            clientes.Add(new Clientes ()
            {   Id = NovoID,
                Nome = NovoNome,
                DataNascimento = NovoDataNascimento,
                Telefone = NovoTelefone,
                Email = NovoEmail,
                Genero = NovoGenero,
                Etnia = NovoEtniaCliente,
                NomeSocial = NovoNomeSocial,
                Tipo = NovoTipoCliente,
                Estrangeiro = NovoEstrangeiro,
                Endereco = NovoEndereco 
            });

            

 
            

            BindingSource.ResetBindings(false);
        }
        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}
