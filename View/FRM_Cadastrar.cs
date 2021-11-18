using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Desktop.Model;
using Desktop.Controller;
using System.Data.SqlClient;

namespace Desktop.View
{
    public partial class FRM_Cadastrar : Form
    {
        Cadastrar Cadastrar;
        Mensagem Mensagem;
        CTR_Cadastrar CTR_Cadastrar;

        public FRM_Cadastrar()
        {
            InitializeComponent();
            Cadastrar = new Cadastrar();
            Mensagem = new Mensagem();
            CTR_Cadastrar = new CTR_Cadastrar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar.User = txbUser.Text;
            Cadastrar.Senha = txbSenha.Text;

            Mensagem = CTR_Cadastrar.CadastrarLogin(Cadastrar);

            MessageBox.Show(Mensagem.TMensagem, "Sucesso", MessageBoxButtons.OK);
        }

        private void FRM_Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
