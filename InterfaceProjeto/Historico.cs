using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceProjeto
{
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void buttonVoltarMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
        }
    }
}
