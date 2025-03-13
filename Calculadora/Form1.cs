namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            if (radioButtonSomar.Checked)
            {
                textBoxResultado.Text = (float.Parse(textBoxNumero1.Text) + float.Parse(textBoxNumero2.Text)).ToString();
            }
            if (radioButtonSubtrair.Checked)
            {
                textBoxResultado.Text = (float.Parse(textBoxNumero1.Text) - float.Parse(textBoxNumero2.Text)).ToString();
            }
            if (radioButtonMultiplicar.Checked)
            {
                textBoxResultado.Text = (float.Parse(textBoxNumero1.Text) * float.Parse(textBoxNumero2.Text)).ToString();
            }
            if (radioButtonDividir.Checked)
            {
                textBoxResultado.Text = (float.Parse(textBoxNumero1.Text) / float.Parse(textBoxNumero2.Text)).ToString();
            }

            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string numero1 = textBoxNumero1.Text; // Pegando o texto do textBox1
            string numero2 = textBoxNumero2.Text; // Pegando o texto do textBox2


            if (!textBoxNumero1.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero1))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero1.Clear();
                return;
            }
            if (!textBoxNumero2.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero2))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero2.Clear();
                return;
            }




        }

        private void buttonSubtracao_Click(object sender, EventArgs e)

        {
            string numero1 = textBoxNumero1.Text; // Pegando o texto do textBox1
            string numero2 = textBoxNumero2.Text; // Pegando o texto do textBox2


            if (!textBoxNumero1.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero1))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero1.Clear();
                return;
            }
            if (!textBoxNumero2.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero2))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero2.Clear();
                return;
            }
            labelResultado.Text = (float.Parse(textBoxNumero1.Text) - float.Parse(textBoxNumero2.Text)).ToString();
            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            string numero1 = textBoxNumero1.Text; // Pegando o texto do textBox1
            string numero2 = textBoxNumero2.Text; // Pegando o texto do textBox2


            if (!textBoxNumero1.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero1))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero1.Clear();
                return;
            }
            if (!textBoxNumero2.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero2))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero2.Clear();
                return;
            }
            labelResultado.Text = (float.Parse(textBoxNumero1.Text) * float.Parse(textBoxNumero2.Text)).ToString();
            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            string numero1 = textBoxNumero1.Text; // Pegando o texto do textBox1
            string numero2 = textBoxNumero2.Text; // Pegando o texto do textBox2


            if (!textBoxNumero1.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero1))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero1.Clear();
                return;
            }
            if (!textBoxNumero2.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero2))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero2.Clear();
                return;
            }

            labelResultado.Text = (float.Parse(textBoxNumero1.Text) / float.Parse(textBoxNumero2.Text)).ToString();
            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
        }

        private void textBoxNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSomar_CheckedChanged(object sender, EventArgs e)
        {

            string numero1 = textBoxNumero1.Text; // Pegando o texto do textBox1
            string numero2 = textBoxNumero2.Text; // Pegando o texto do textBox2


            if (!textBoxNumero1.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero1))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero1.Clear();
                return;
            }
            if (!textBoxNumero2.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero2))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero2.Clear();
                return;
            }


        }

        private void radioButtonSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            string numero1 = textBoxNumero1.Text; // Pegando o texto do textBox1
            string numero2 = textBoxNumero2.Text; // Pegando o texto do textBox2


            if (!textBoxNumero1.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero1))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero1.Clear();
                return;
            }
            if (!textBoxNumero2.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero2))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero2.Clear();
                return;
            }



        }

        private void radioButtonMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            string numero1 = textBoxNumero1.Text; // Pegando o texto do textBox1
            string numero2 = textBoxNumero2.Text; // Pegando o texto do textBox2


            if (!textBoxNumero1.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero1))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero1.Clear();
                return;
            }
            if (!textBoxNumero2.Text.All(char.IsNumber) || string.IsNullOrEmpty(numero2))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero2.Clear();
                return;
            }


        }

        private void radioButtonDividir_CheckedChanged(object sender, EventArgs e)
        {
            string numero1 = textBoxNumero1.Text; // Pegando o texto do textBox1
            string numero2 = textBoxNumero2.Text; // Pegando o texto do textBox2


            if (!textBoxNumero1.Text.All(char.IsNumber))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero1.Clear();
                return;
            }
            if (!textBoxNumero2.Text.All(char.IsNumber))
            {
                labelResultado.Text = "Digite um número válido";
                textBoxNumero2.Clear();
                return;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.Show();
        }

        private void textBoxNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPerimetro newform = new FormPerimetro();
            newform.Show();
            this.Hide();

        }
    }
}
