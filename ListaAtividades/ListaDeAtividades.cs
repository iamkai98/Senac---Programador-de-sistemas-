using ListaAtividades.Dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        private Atividade? atividadeEmAndamento;
        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {

           labelErro.Text = string.Empty; // Limpa o texto de erro ao carregar o formulário

            CarregarAtividadeEmAndamento(); // Carregar a atividade em andamento
            CarregarListaDeAtividades(); // Carregar a lista de atividades pendentes

        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento == null || atividadeEmAndamento.Id <= 0)
            {
                labelErro.Text = "Não há atividade em andamento.";
                return;
            }

            if (!atividadeEmAndamento.AtualizarSituacao())
            {
                labelErro.Text = "Erro ao finalizar atividade.";
                return;
            }
            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione uma atividade.";
                return;
            }

            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];
            Atividade atividade = new()

            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value
            };

            if (!atividade.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possível atualizar a atividade.";
                return;
            }

            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
            CarregarListaDeAtividades();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
           var resultado = new CriarAtividade().ShowDialog(); // Abre o formulário de criação de atividade como um diálogo

            if (resultado != DialogResult.OK) // Verifica se o resultado do diálogo é OK
            {
                labelErro.Text = "A criação da atividade não foi concluída com sucesso.";
                return;
            }

            labelErro.Text = "Atividade criada com sucesso!";
            CarregarListaDeAtividades();
        }

        private void CarregarListaDeAtividades()
        {
            Atividade atividade = new(); // instância da classe Atividade

            var atividadePendente = atividade.ListarAtividadePendentes(); // criar uma lista de atividades pendentes
            dataGridViewAtividades.DataSource = atividadePendente;
        }

        private void CarregarAtividadeEmAndamento()
        {

            Atividade atividade = new(); // instância da classe Atividade

            atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento(); // buscar a atividade em andamento
            string textoAtividade = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}"; // criar uma string com o id e o título da atividade
            textBoxAtividadeEmAndamento.Text = atividadeEmAndamento.Id > 0 ? textoAtividade : string.Empty;
        }



}
}
