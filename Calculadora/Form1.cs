namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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

        private void radioButtonDivdir_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new GeoCalc();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form circle = new Circle();
            circle.Show();
            this.Hide();
        }
    }
}
