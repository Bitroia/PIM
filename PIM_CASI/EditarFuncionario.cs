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
using MySql.Data.MySqlClient;

namespace PIM_CASI
{
    public partial class EditarFuncionario : Form
    {
        // C R I A R   C O N E X A O

        private MySqlConnection Conexao;
        private string data_source = "datasource=127.0.0.1;username=root;password=010254;database=PIM";

        
            
        public EditarFuncionario()
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
            lstFuncionario.Columns.Add("RUA", 200, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("COMPLEMENTO", 150, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("N°", 40, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("BAIRRO", 100, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("UF", 40, HorizontalAlignment.Left);
            lstFuncionario.Columns.Add("CIDADE", 100, HorizontalAlignment.Left);


            CarregraContato();

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
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),
                        reader.GetString(8),
                        reader.GetString(9),
                        reader.GetString(10),
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

        //NAO MEXE NISSO AQUI
        private void EditarFuncionario_Load(object sender, EventArgs e)
        {

        }
        //NAO MEXE NISSO AQUI

        private void lstFuncionario_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstFuncionario.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                

                txtNome.Text = item.SubItems[0].Text;
                txtCPF.Text = item.SubItems[1].Text;
                txtFone.Text = item.SubItems[2].Text;
                txtCargo.Text = item.SubItems[3].Text;
                txtValorHora.Text = item.SubItems[4].Text;
                txtRua.Text = item.SubItems[5].Text;
                txtComplemento.Text = item.SubItems[6].Text;
                txtNumero.Text = item.SubItems[7].Text;
                txtBairro.Text = item.SubItems[8].Text;
                txtUF.Text = item.SubItems[9].Text;
                txtCidade.Text = item.SubItems[10].Text;

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "UPDATE FUNCIONARIO SET " +
                    "NOME_FUNCIONARIO=@NOME_FUNCIONARIO, " +
                    "CPF_FUNCIONARIO=@CPF_FUNCIONARIO, " +
                    "FONE_FUNCIONARIO=@FONE_FUNCIONARIO, " +
                    "CARGO_FUNCIONARIO=@CARGO_FUNCIONARIO, " +
                    "VALOR_HORA=@VALOR_HORA, " +
                    "RUA=@RUA, " +
                    "COMPLEMENTO=@COMPLEMENTO, " +
                    "NUMERO=@NUMERO, " +
                    "BAIRRO=@BAIRRO, " +
                    "UF=@UF, " +
                    "CIDADE=@CIDADE " +
                    "WHERE  CPF_FUNCIONARIO=@CPF_FUNCIONARIO";

                cmd.Parameters.AddWithValue("@NOME_FUNCIONARIO", txtNome.Text);
                cmd.Parameters.AddWithValue("@CPF_FUNCIONARIO", txtCPF.Text);
                cmd.Parameters.AddWithValue("@FONE_FUNCIONARIO", txtFone.Text);
                cmd.Parameters.AddWithValue("@CARGO_FUNCIONARIO", txtCargo.Text);
                cmd.Parameters.AddWithValue("@VALOR_HORA", txtValorHora.Text);
                cmd.Parameters.AddWithValue("@RUA", txtRua.Text);
                cmd.Parameters.AddWithValue("@COMPLEMENTO", txtComplemento.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txtNumero.Text);
                cmd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                cmd.Parameters.AddWithValue("@UF", txtUF.Text);
                cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario atualizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtNome.Text = string.Empty;
                txtCPF.Text = string.Empty;
                txtFone.Text = string.Empty;
                txtCargo.Text = string.Empty;
                txtValorHora.Text = string.Empty;
                txtRua.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                txtNumero.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtUF.Text = string.Empty;
                txtCidade.Text = string.Empty;

                CarregraContato();

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
    }
}
