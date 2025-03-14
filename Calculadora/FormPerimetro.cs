using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormPerimetro : Form
    {
        public FormPerimetro()
        {
            InitializeComponent();
        }

        private bool ValidarForm()
        {
            string medida = textBoxQuadrado.Text;

            if (string.IsNullOrWhiteSpace(medida) || !textBoxQuadrado.Text.All(char.IsNumber))
            {
                MessageBox.Show("Por favor, preencha o campo corretamente e digite apenas números!");
                return false;
            }

            return true;
        }

        private void textBoxMedidaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarForm())
            {
                return;
            }

            string medida = textBoxQuadrado.Text;

            float perimetro = float.Parse(medida) * 4;
            float area = float.Parse(medida) * float.Parse(medida);
            float volume = float.Parse(medida) * float.Parse(medida) * float.Parse(medida);

            textBoxPerimetro.Text = perimetro.ToString();
            textBoxArea.Text = area.ToString();
            textBoxVolume.Text = volume.ToString();


        }

        private void button2Voltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {   textBoxQuadrado.Enabled = true;
                textBoxLado1Rtagl.Enabled = false;
                textBoxLado2Rtagl.Enabled = false;
                textBoxAltura.Enabled = false;
                return;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                textBoxLado1Rtagl.Enabled = true;
                textBoxLado2Rtagl.Enabled = true;
                textBoxAltura.Enabled = true;
                textBoxQuadrado.Enabled = false;
                return;
            }
        }
    }
}
