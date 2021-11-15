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

        public FRM_Cadastrar()
        {
            InitializeComponent();
            Cadastrar = new Cadastrar();
            Mensagem = new Mensagem();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Credenciais cred = new Credenciais();
            SqlConnection con;
            SqlCommand cmd;

            Cadastrar.User = txbUser.Text;
            Cadastrar.Senha = txbSenha.Text;

            con = new SqlConnection(cred.constring);
            try
            {
                con.Open();

                Mensagem.sql = "INSERT INTO FUNCIONARIOS (USUÁRIO, SENHA)"
                    + "VALUES (@User, @Senha)";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@User", Cadastrar.User); //Atribuindos os valores
                cmd.Parameters.AddWithValue("@Senha", Cadastrar.Senha);

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0)
                    MessageBox.Show("Funcionário cadastrado com sucesso.","Sucesso!",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }
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
