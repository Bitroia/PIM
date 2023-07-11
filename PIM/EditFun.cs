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

namespace PIM_CASI
{
    public partial class EditFun : Form
    {
        // C R I A R   C O N E X A O

        private MySqlConnection Conexao;
        private string data_source = "datasource=127.0.0.1;username=root;password=010254;database=PIM";


        public void Fun()
        {
            InitializeComponent();

            lstFuncionario.View = View.Details;
            lstFuncionario.LabelEdit = true;
            lstFuncionario.AllowColumnReorder = true;
            lstFuncionario.FullRowSelect = true;
            lstFuncionario.GridLines = true;

            lstFuncionario.Columns.Add("NOME", 200, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("CPF", 120, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("FONE", 120, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("CARGO", 100, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("R$/HORA", 90, HorizontalAlignment.Left);

            CarregraContato();

        }

        private void btnBuscarFun_Click(object sender, EventArgs e)
        {

        }

        private void CarregraContato()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                // B U S C A R   F U N C I O N A R I O

                cmd.CommandText = "SELECT * FROM FUNCIONARIO ORDER BY  NOME_FUNCIONARIO ASC";

                // executa comando

                MySqlDataReader reader = cmd.ExecuteReader();

                lstFuncionario.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                    };

                    lstFuncionario.Items.Add(new ListViewItem(row));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Conexao.Close();
            }
        }

        private void lstFuncionario_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }
    }
}
