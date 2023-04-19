using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace pimteste
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String senha = txtSenha.Text;

            if (senha == "b" & usuario == "c")
            {

                Form_inicio frmin = new Form_inicio();
                frmin.ShowDialog();


            }
            else
            {
                MessageBox.Show("senha errada");
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {

        }

        private void Login_Layout(object sender, LayoutEventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var strConexao = "localhost:3306/?user=root";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }
    }
}
