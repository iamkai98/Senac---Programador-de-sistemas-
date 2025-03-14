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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private bool ValidarForm()
        {
            string centimetros = textBoxCM.Text;
            string kilogramas = textBoxKG.Text;

            if (string.IsNullOrWhiteSpace(centimetros) || !textBoxCM.Text.All(char.IsNumber))
            {
                MessageBox.Show("Por favor, preencha os campos corretamente e digite apenas números em centímetros!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(kilogramas) || !textBoxKG.Text.All(char.IsNumber))
            {
                MessageBox.Show("Por favor, preencha os campos corretamente e digite apenas números em kilogramas!");
                return false;
            }

            return true;
        }
               
        

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarForm()) 
            {
                return;
            }

            string centimetros = textBoxCM.Text;
            string kilogramas = textBoxKG.Text;

            float alturaMetros = float.Parse(centimetros) / 100;
            
            //CONVERTENDO CENTÍMETROS PARA METROS <<<<<<< HEAD
            float resultado = float.Parse(kilogramas) / ((alturaMetros) * (alturaMetros)); 
            
            //FÓRMULA DO IMC =======
            float resultado = float.Parse(kilogramas) / (alturaMetros) * (alturaMetros);
            
            //FÓRMULA DO IMC>>>>>>> 2559fffdb4bc3e9fda50173b5ca0df2bc1b2106c



            if (radioButtonFeminino.Checked) //Button Feminino 
            {
                    if (resultado < 19.1)
                    {
                        labelResultado.Text = $"Seu IMC é: {resultado:F2}! Você está abaixo do peso";
                    }

                    else if (resultado < 25.8)
                    {
                        labelResultado.Text = $"Seu IMC é: {resultado:F2}! Você está com o peso normal";
                    }
                    else if (resultado < 27.3)
                    {
                        labelResultado.Text = $"Seu IMC é: {resultado:F2}! Você está um pouco acima do peso";
                    }
                    else if (resultado < 32.3)
                    {
                        labelResultado.Text = $"Seu IMC é: {resultado:F2}! Você está acima do peso";
                    }
                    else
                    {
                        labelResultado.Text = $"Seu IMC é: {resultado:F2}! Você está obeso";
                    }
            }
            {


            }




        }
    }
}
