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



        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();
            historico.Show();
            this.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            pictureBoxSetaCriarPedido.Visible = false;
            pictureBoxSetaEditarPedido.Visible = false;
            pictureBoxSetaCriarCliente.Visible = false;
            pictureBoxSetaRelatorios.Visible = false;
        }

        private void buttonCriarPedido_MouseEnter(object sender, EventArgs e)
        {
            if (!pictureBoxSetaCriarPedido.Visible)
            {
                pictureBoxSetaCriarPedido.Visible = true;
            }

        }

        private void buttonCriarPedido_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBoxSetaCriarPedido.Visible)
            {
                pictureBoxSetaCriarPedido.Visible = false;
            }
        }

        private void buttonCriarCliente_MouseEnter(object sender, EventArgs e)
        {
            if (!pictureBoxSetaCriarCliente.Visible)
            {
                pictureBoxSetaCriarCliente.Visible = true;
            }
        }

        private void buttonCriarCliente_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBoxSetaCriarCliente.Visible)
            {
                pictureBoxSetaCriarCliente.Visible = false;
            }

        }

        private void buttonEditarPedido_MouseEnter(object sender, EventArgs e)
        {
            if (!pictureBoxSetaEditarPedido.Visible)
            {
                pictureBoxSetaEditarPedido.Visible = true;
            }
        }

        private void buttonEditarPedido_MouseLeave(object sender, EventArgs e)
        {
            if (pictureBoxSetaEditarPedido.Visible)
            {
                pictureBoxSetaEditarPedido.Visible = false;
            }
        }

        private void buttonRelatorio_MouseEnter(object sender, EventArgs e)
        {
            if (!pictureBoxSetaRelatorios.Visible)
            {
                pictureBoxSetaRelatorios.Visible = true;
            }
        }

        private void buttonRelatorio_MouseLeave(object sender, EventArgs e)
        {
            if ( pictureBoxSetaRelatorios.Visible)
            {
                pictureBoxSetaRelatorios.Visible = false;
            }
        }
    }
}
