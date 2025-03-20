using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }
        private bool ValidarRaio()
        {
            string raio = textBoxRaio.Text;
            if (string.IsNullOrWhiteSpace(raio))
            {
                MessageBox.Show("Insira um valor válido");
                return false;
            }
            if (!textBoxRaio.Text.All(char.IsNumber))
            {
                MessageBox.Show("Insira apenas números");
                return false;
            }
            return true;
        }

        private bool ValidarRadioButtons()
        {
            if (!radioButtonArea.Checked && !radioButtonDiametro.Checked && !radioButtonPerimetro.Checked && !radioButtonVolume.Checked)
            {
                MessageBox.Show("Selecione uma opção");
                return false;
            }
            
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
