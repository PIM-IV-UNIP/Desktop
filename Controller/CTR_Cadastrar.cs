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
        Credenciais cred = new Credenciais(); // Classe que contém as credenciais de conexão do servidor do Banco de Dados
        SqlConnection con;
        SqlCommand cmd;
        Mensagem Mensagem = new Mensagem();

        public Mensagem CadastrarLogin(Cadastrar Cadastrar)
        {
            con = new SqlConnection(cred.constring);
            
            try
            {
                con.Open(); //Abrindo a conexão com o servidor

                Mensagem.sql = "INSERT INTO FUNCIONARIOS (USUÁRIO, SENHA) " + "VALUES (@User, @Senha)";

                cmd = new SqlCommand(Mensagem.sql, con);

                //Atribuindos os valores
                cmd.Parameters.AddWithValue("@User", Cadastrar.User); 
                cmd.Parameters.AddWithValue("@Senha", Cadastrar.Senha);

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0) //verificando se houveram alterações 
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
                con.Close(); //fechando a conexão com o servidor
            }

            return Mensagem;
        }
    }
}
