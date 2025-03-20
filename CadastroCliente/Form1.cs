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

            string DataNascimentoValida = maskedTextBoxDataNascimento.Text.Replace("/", "").Replace(" ", "").Trim();

            if (DataNascimentoValida.Distinct().Count() == 1) //
            {
                labelAviso.Text = "O campo data de nascimento n�o pode conter todos os d�gitos repetidos";
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
            //m�todo Distict.().Count() tem a fun��o de contar quantos valores �nicos existem euma cole��o 
            // Distinct = remove os n�mero repetidos, matendo apenas os diferentes
            // Count = conta quantos n�meros �nicos restaram
            // ==1 se s�brou 1 n�mero �nico, significa que o usu�rio digitou o mesmo n�mero repetido v�rias vezes
        }
        public bool ValidarCampoTelefone() // M�todo para avaliar o campo telefone
        {
            if (!maskedTextBoxTelefone.MaskFull) // verifica se o campo est� preenchido completamente
            {
                labelAviso.Text = "O campo telefone � obrigat�rio, preencha corretamente";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            string verificarNumerorepetido = maskedTextBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();
            if (verificarNumerorepetido.Distinct().Count() == 1)
            {
                labelAviso.Text = "O campo n�mero de telefone n�o pode conter todos os d�gitos repetidos";
                labelAviso.ForeColor= Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
            //m�todo Distict.().Count() tem a fun��o de contar quantos valores �nicos existem euma cole��o 
            // Distinct = remove os n�mero repetidos, matendo apenas os diferentes
            // Count = conta quantos n�meros �nicos restaram
            // ==1 se s�brou 1 n�mero �nico, significa que o usu�rio digitou o mesmo n�mero repetido v�rias vezes
        }
        public bool ValidarCampoEmail() // M�todo para avaliar o campo email
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text)) // verifica se o campo est� preenchido
            {
                labelAviso.Text = "O campo email � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (textBoxEmail.Text.Length < 10) // verifica se o campo tem no m�nimo 9 caracteres
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
        public bool ValidarCampoGenero()// M�todo para avaliar o campo g�nero
        {
            if (string.IsNullOrEmpty(comboBoxGenero.Text)) // verifica se o campo est� preenchido com pelo menos uma op��o do comboBox
            {
                labelAviso.Text = "O campo g�nero � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }
        public bool ValidarEtnia() // M�todo para avaliar o campo etnia
        {
            if (string.IsNullOrWhiteSpace(comboBoxEtnia.Text)) //verifica se o campo est� nulo ou com espa�os em branco 
            {
                labelAviso.Text = "O campo etnia � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        public bool ValidarNomeSocial() //M�todo para avaliar o campo nome social 
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeSocial.Text))
            {
                return true; //se caso n�o for selelcionado retorna true, j� que n�o � obrigat�rio  
            }

            if (textBoxNomeSocial.Text.Any(char.IsDigit)) // se caso o usu�rio digitar algo, n�o ser� permitido n�meros
            {
                labelAviso.Text = "O campo nome social n�o pode conter n�meros";
                labelAviso.ForeColor = Color.Red;
                return false;
            }

            if (textBoxNomeSocial.Text.Length < 3)// se o usu�rio digitar algo, o texbox ir� permitir no m�nimo 3 caracteres 
            {
                labelAviso.Text = "O campo nome social deve conter no m�nimo 3 caracteres";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }
        public bool ValidarTipo() //M�todo para avaliar o campo tipo 
        {
            if (!radioButtonTipoPF.Checked && !radioButtonTipoPJ.Checked)
            {
                labelAviso.Text = "Preencha alguma das op��es no campo tipo";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            labelAviso.Text = "";
            return true;
        }
        public bool ValidarEstrangeiro() //M�todo para avaliar o campo estrangeiro 
        {
            return true;
        }
        public bool ValidarCep()
        {
            string CEP = maskedTextBoxCEP.Text.Replace("-", "").Trim(); // "Replace" � um m�todo que remove o tra�o, deixando apenas os n�meros do campo CEP
                                                                        // "Trim" � um m�todo que remove espa�os extras ao redor do texto 

            if (!maskedTextBoxCEP.MaskFull)
            {
                labelAviso.Text = "O campo CEP � obrigat�rio, preencha corretamente";
                labelAviso.ForeColor = Color.Red;
                return false;
            }
            if (CEP.Distinct().Count() == 1)  
            {
                labelAviso.Text = "Digite um CEP v�lido";
                labelAviso.ForeColor = Color.Red; 
                return false;
            }
            labelAviso.Text = "";
            return true;

            //m�todo Distict.().Count() tem a fun��o de contar quantos valores �nicos existem euma cole��o 
            // Distinct = remove os n�mero repetidos, matendo apenas os diferentes
            // Count = conta quantos n�meros �nicos restaram
            // ==1 se s�brou 1 n�mero �nico, significa que o usu�rio digitou o mesmo n�mero repetido v�rias vezes
        }
        public bool ValidarMunicipio()
        {
            if(string.IsNullOrWhiteSpace(textBoxMunicipio.Text))
            {
                labelAviso.Text = "O campo municipio � obrigat�rio";
                labelAviso.ForeColor= Color.Red;
            }
            return true;
        }
        public bool ValidarEstado()
        {
            if (string.IsNullOrWhiteSpace(textBoxEstado.Text))
            {
                labelAviso.Text = "O campo estado � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
            }
            return true;
        }

        public bool ValidarBairro()
        {
            if (string.IsNullOrWhiteSpace(textBoxBairro.Text))
            {
                labelAviso.Text = "O campo bairro � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
            }
            return true;
        }
        public bool ValidarLogradouro()
        {
            if (string.IsNullOrWhiteSpace(textBoxLogradouro.Text))
            {
                labelAviso.Text = "O campo logradouro � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
            }
            return true;
        }
        public bool ValidarNumero()
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero.Text))
            {
                labelAviso.Text = "O campo numero � obrigat�rio";
                labelAviso.ForeColor = Color.Red;
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
                !ValidarCep () ||
                !ValidarMunicipio()||
                !ValidarEstado () ||
                !ValidarBairro () ||
                !ValidarLogradouro() ||
                !ValidarNumero () ||
                !ValidarComplemento())
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
