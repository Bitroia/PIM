using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pimteste
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            //Se o usuário clicar em sim, feche o formulario atual

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void holeriteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
