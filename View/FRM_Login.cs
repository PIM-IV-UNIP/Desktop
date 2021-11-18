using Desktop.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Desktop.Controller;

namespace Desktop.View
{
    public partial class FRM_Login : Form
    {
        Login Login;
        Mensagem Mensagem;
        CTR_Login CTR_Login;

        public FRM_Login()
        {
            InitializeComponent();
            Login = new Login();
            Mensagem = new Mensagem();
            CTR_Login = new CTR_Login();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login.User = txbUser.Text;
            Login.Senha = txbSenha.Text;

            Hide();

            Mensagem = CTR_Login.AutenticarUser(Login);

            if (Mensagem.VerificaReturnFuncao.Equals(false))
            {
                MessageBox.Show(Mensagem.TMensagem, "Erro: Falha no Login", MessageBoxButtons.OK);
            }
            else
            {
                FRM_Inicio FRM_Inicio = new FRM_Inicio();
                FRM_Inicio.ShowDialog();
            }
            
            txbUser.Text = Login.User;
            txbSenha.Text = Login.Senha;

            Show();
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FRM_Cadastrar FRM_Cadastrar = new FRM_Cadastrar();
            Hide();
            FRM_Cadastrar.ShowDialog();
            Show();
        }
    }
}
