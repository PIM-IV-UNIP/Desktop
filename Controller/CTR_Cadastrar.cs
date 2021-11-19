using System;
using System.Collections.Generic;
using System.Text;
using Desktop.Model;
using System.Data;
using System.Data.SqlClient;

namespace Desktop.Controller
{
    class CTR_Cadastrar
    {
        Credenciais cred = new Credenciais();
        SqlConnection con;
        SqlCommand cmd;
        Mensagem Mensagem = new Mensagem();

        public Mensagem CadastrarLogin(Cadastrar Cadastrar)
        {
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
                {
                    Mensagem.VerificaReturnFuncao = true;
                    Mensagem.TMensagem = "Funcionário cadastrado com sucesso.";
                }
                    
            }
            catch
            {
                Mensagem.VerificaReturnFuncao = false;
                Mensagem.TMensagem = "Já existe um funcionário cadastrado com este usuário.";
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }

            return Mensagem;
        }
    }
}
