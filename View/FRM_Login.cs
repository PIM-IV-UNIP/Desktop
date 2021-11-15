using Desktop.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Desktop.View
{
    public partial class FRM_Login : Form
    {
        Login Login;
        Mensagem Mensagem;

        public FRM_Login()
        {
            InitializeComponent();
            Login = new Login();
            Mensagem = new Mensagem();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Credenciais cred = new Credenciais();
            SqlConnection con = new SqlConnection(cred.constring);
            SqlCommand cmd;

            Login.User = txbUser.Text;
            Login.Senha = txbSenha.Text;

            SqlDataReader reader;

            try
            {
                con.Open();
                Mensagem.sql = "SELECT * FROM FUNCIONARIOS WHERE USUÁRIO = @User AND SENHA = @Senha";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@User", Login.User);
                cmd.Parameters.AddWithValue("Senha", Login.Senha);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    FRM_Inicio Inicio = new FRM_Inicio(); //Instância da do form Inicio
                    Hide(); //Esconde a tela do Login
                    Inicio.ShowDialog(); //Exibe a tela de Início
                    Show(); //Mostra a tela de Login novamente após o usuário clicar no botão sair
                    txbUser.Text = string.Empty;
                    txbSenha.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
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
