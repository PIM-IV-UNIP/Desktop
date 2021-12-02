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
            //Atribuição dos valores dos TextBox aos atributos
            Login.User = txbUser.Text;
            Login.Senha = txbSenha.Text;

            Hide(); //Esconde a tela de Login

            //Chamada de Função
            Mensagem = CTR_Login.AutenticarLogin(Login);

            //Verificação do sucesso da função
            if (Mensagem.VerificaReturnFuncao.Equals(false))
            {
                MessageBox.Show(Mensagem.TMensagem, "Erro: Falha no Login", MessageBoxButtons.OK);
            }
            else
            {
                //Abre a tela de Início
                FRM_Inicio FRM_Inicio = new FRM_Inicio();
                FRM_Inicio.ShowDialog();
            }

            //Limpa os TextBox
            txbUser.Text = string.Empty;
            txbSenha.Text = string.Empty;

            Show(); //Mostra novamente a tela de login após o usuário clicar no botão Sair da tela Inicial
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
            //Limpa os TextBox
            txbUser.Text = string.Empty;
            txbSenha.Text = string.Empty;

            //Mostra a tela de Cadastro e esconde a tela de Login
            FRM_Cadastrar FRM_Cadastrar = new FRM_Cadastrar();
            Hide();
            FRM_Cadastrar.ShowDialog();
            Show(); //Mostra novamente a tela de Login após o usuário clicar no botão Voltar
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
