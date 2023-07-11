using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PIM_CASI
{
    public partial class FrmPrincipal : Form
    {
        private Form frmAtivo;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // codigo para mudar os forms no painel
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }


        // isso aqui muda as cores do botao
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control crtl in panelMenu.Controls)
                crtl.BackColor = Color.FromArgb(25, 25, 25);

            foreach (Control crtl in panelMenu.Controls)
                crtl.ForeColor = Color.WhiteSmoke;
            
            frmAtivo.ForeColor = Color.White;
            frmAtivo.BackColor = Color.FromArgb(51, 51, 51) ;
        }

        // botoes... aqui cada um vai chamar sua tela
        private void btnFun_Click(object sender, EventArgs e)
        {
            ActiveButton(btnFun);
            FormShow(new Fun());
        }

        private void btnAddFun_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAddFun);
            FormShow(new AddFun());
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            ActiveButton(btnPonto);
            FormShow(new Ponto());
        }

        private void btnAddHora_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAddHora);
            FormShow(new AddHora());
        }

        private void btnHole_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHole);
            FormShow(new Hole());
        }


        // botao sair perguntado para confirmar
        private void btnSair_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSair);
            ActiveFormClose();
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ActiveFormClose();
                Application.Exit();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEditar);
            FormShow(new EditarFuncionario());
        }
    }
}
