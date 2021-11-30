using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Desktop.Model;
using Desktop.View;

namespace Desktop.Controller
{
    class CTR_Login
    {
        SqlConnection con;
        SqlCommand cmd;
        Mensagem Mensagem = new Mensagem();
        Credenciais cred = new Credenciais(); //Classe que contém as credenciais de acesso ao servidor do Banco de Dados

        public Mensagem AutenticarLogin(Login Login)
        {
            con = new SqlConnection(cred.constring);

            SqlDataReader reader;

            try
            {
                con.Open();//Abrindo a conexão com o servidor

                Mensagem.sql = "SELECT * FROM FUNCIONARIOS WHERE USUÁRIO = @User AND SENHA = @Senha"; //Setando o comando SQL

                cmd = new SqlCommand(Mensagem.sql, con);//Executando o comando SQL

                //Atribuindo os valores
                cmd.Parameters.AddWithValue("@User", Login.User);
                cmd.Parameters.AddWithValue("Senha", Login.Senha);

                reader = cmd.ExecuteReader();

                if (reader.Read()) //Verificando se existe um registro
                {
                    Mensagem.VerificaReturnFuncao = true;

                    Login.User = string.Empty;
                    Login.Senha = string.Empty;
                }
                else
                {
                    Mensagem.VerificaReturnFuncao = false;
                    Mensagem.TMensagem = "Usuário ou senha incorretos";
                }
            }

            catch (Exception ex)
            {
                Mensagem.VerificaReturnFuncao = false;
                Mensagem.TMensagem = "Erro: " + ex.ToString();
            }
            finally
            {
                con.Close(); //fechando a conexão com o servidor
            }

            return Mensagem;
        }

    }
}
