namespace InterfaceProjeto
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonCriarPedido_Click(object sender, EventArgs e)
        {
            CriarPedido criarPedido = new CriarPedido();
            criarPedido.Show();
            this.Hide();
        }

        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            CriarCliente criarCliente = new CriarCliente();
            criarCliente.Show();
            this.Hide();
        }

        private void buttonEditarPedido_Click(object sender, EventArgs e)
        {
            EditarPedido editarPedido = new EditarPedido();
            editarPedido.Show();
            this.Hide();
        }

        private void buttonCriarCliente_MouseEnter(object sender, EventArgs e)
        {
            buttonCriarCliente.BackColor = ColorTranslator.FromHtml("#2314BC");
            buttonCriarCliente.ForeColor = Color.White;
        }

        private void buttonCriarCliente_MouseLeave(object sender, EventArgs e)
        {
            buttonCriarCliente.BackColor = SystemColors.Control;
            buttonCriarCliente.ForeColor = Color.Black;
        }
    }
}
