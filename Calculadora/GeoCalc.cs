using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraDoOdio
{
    public partial class GeoCalc : Form
    {
        public GeoCalc()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxLadoQuadrado.Enabled = true;
                textBoxLadoRetangulo.Enabled = false;
                textBoxLarguraRetangulo.Enabled = false;
                textBoxAlturaRetangulo.Enabled = false;
                return;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                textBoxLadoQuadrado.Enabled = false;
                textBoxLadoRetangulo.Enabled = true;
                textBoxLarguraRetangulo.Enabled = true;
                textBoxAlturaRetangulo.Enabled = true;
                return;
            }
        }

        private bool ValidarForm()
        {

            string ladoQuadrado = textBoxLadoQuadrado.Text;
            string ladoRetangulo = textBoxLadoRetangulo.Text;
            string larguraRetangulo = textBoxLarguraRetangulo.Text;
            string alturaRetangulo = textBoxAlturaRetangulo.Text;

            if (comboBox1.SelectedIndex == 0)
            { 
                if (string.IsNullOrWhiteSpace(ladoQuadrado))
                {
                MessageBox.Show("Insira um valor válido");
                return false;
                }
                if (!textBoxLadoQuadrado.Text.All(char.IsNumber))
                {
                MessageBox.Show("Insira apenas números");
                return false;
                }
                return true;

            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(ladoRetangulo) || string.IsNullOrWhiteSpace(larguraRetangulo) || string.IsNullOrWhiteSpace (alturaRetangulo))
                {
                    MessageBox.Show("Todos os campos do retângulo devem ser preenchidos");
                    return false;
                }
                if (!textBoxLadoRetangulo.Text.All(char.IsNumber) || !textBoxLarguraRetangulo.Text.All(char.IsNumber) || !textBoxAlturaRetangulo.Text.All(char.IsNumber))
                {
                    MessageBox.Show("Insira apenas números");
                    return false;
                }
                return true;
            }

            return true;
        }

            

        private void buttonCalcularQuad_Click(object sender, EventArgs e)
        {
            if (!ValidarForm())
            {
                return;
            }



            double ladoQuadrado = double.Parse(textBoxLadoQuadrado.Text);

            double areaQuadrado = ladoQuadrado * ladoQuadrado;
            double perimetroQuadrado = 4 * ladoQuadrado;
            double volumeQuadrado = ladoQuadrado * ladoQuadrado * ladoQuadrado;

            textBoxPeriQuad.Text = perimetroQuadrado.ToString();
            textBoxAreaQuad.Text = areaQuadrado.ToString();
            textBoxVolQuad.Text = volumeQuadrado.ToString();

            textBoxLadoQuadrado.Clear();

        }

        private void buttonCalcularRet_Click(object sender, EventArgs e)
        {
            if(ValidarForm())
            {
                return;
            }
        }
    }
}
