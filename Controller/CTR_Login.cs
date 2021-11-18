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
        Credenciais cred = new Credenciais();

        public Mensagem AutenticarUser(Login Login)
        {
            con = new SqlConnection(cred.constring);

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
                con.Close();
            }

            return Mensagem;
        }

    }
}
