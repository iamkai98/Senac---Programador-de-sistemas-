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

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string ladoQuadrado = textBoxLadoQuadrado.Text;

            if(!textBoxLadoQuadrado.Text.All(char.IsNumber))
            {
                MessageBox.Show("")
            }

            if (string.IsNullOrEmpty(ladoQuadrado))
            {
                
            }
        }
    }
}
