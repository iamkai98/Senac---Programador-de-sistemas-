using ListaAtividades.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace ListaAtividades
{
    public partial class CriarAtividade : Form
    {
        public CriarAtividade()
        {
            InitializeComponent();
        }

        private void buttonDescartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Define o resultado do diálogo como Cancel
            this.Close(); // Fecha o formulário
        }

        private void CriarAtividade_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty; // Limpa o texto de erro ao carregar o formulário
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade()

            {
                Titulo = textBoxTitulo.Text // Obtém o título da atividade do TextBox
            };

            if (!atividade.Criar()) // Tenta criar a atividade
            {
                labelErro.Text = "Erro ao criar atividade."; // Exibe mensagem de erro se falhar
                return;
            }

            this.DialogResult = DialogResult.OK; // Define o resultado do diálogo como OK
            this.Close();

        }
    }
}
