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
    public partial class AddFun : Form
    {
        // C R I A R   C O N E X A O

        private MySqlConnection Conexao;
        private string data_source = "datasource=127.0.0.1;username=root;password=010254;database=PIM";


        public AddFun()
        {
            InitializeComponent();
        }

        private void btnAddFun_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                // A D D    F U N C I O N A R I O

                cmd.CommandText = "INSERT INTO FUNCIONARIO( " +
                    "NOME_FUNCIONARIO, " +
                    "CPF_FUNCIONARIO, " +
                    "FONE_FUNCIONARIO, " +
                    "CARGO_FUNCIONARIO, " +
                    "VALOR_HORA, " +
                        "RUA," +
                        "COMPLEMENTO, " +
                        "NUMERO, " +
                        "BAIRRO, " +
                        "UF, " +
                        "CIDADE) " +
                    "VALUES( @NOME_FUNCIONARIO," +
                    "@CPF_FUNCIONARIO," +
                    "@FONE_FUNCIONARIO," +
                    "@CARGO_FUNCIONARIO," +
                    "@VALOR_HORA_FUNCIONARIO," +
                    "@RUA," +
                    "@COMPLEMENTO," +
                    "@NUMERO," +
                    "@BAIRRO," +
                    "@UF," +
                    "@CIDADE)";

                cmd.Parameters.AddWithValue("@NOME_FUNCIONARIO",txtNome.Text);
                cmd.Parameters.AddWithValue("@CPF_FUNCIONARIO",txtCPF.Text);
                cmd.Parameters.AddWithValue("@FONE_FUNCIONARIO",txtFone.Text);
                cmd.Parameters.AddWithValue("@CARGO_FUNCIONARIO",txtCargo.Text);
                cmd.Parameters.AddWithValue("@VALOR_HORA_FUNCIONARIO",txtValorHora.Text);
                cmd.Parameters.AddWithValue("@RUA",txtRua.Text);
                cmd.Parameters.AddWithValue("@COMPLEMENTO",txtComplemento.Text);
                cmd.Parameters.AddWithValue("@NUMERO",txtNumero.Text);
                cmd.Parameters.AddWithValue("@BAIRRO",txtBairro.Text);
                cmd.Parameters.AddWithValue("@UF",txtUF.Text);
                cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                
                cmd.Prepare();
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario foi criado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { 
                Conexao.Close(); 
            }
        }
    }
}
