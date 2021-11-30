using System;
using System.Collections.Generic;
using System.Text;
using Desktop.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Desktop.Controller
{
    class CTR_CheckIn
    {
        Mensagem Mensagem = new Mensagem();
        Credenciais credenciais = new Credenciais(); //Classe que contém as credenciais de acesso ao servidor do Banco de Dados
        SqlConnection con;
        SqlCommand cmd;

        public Mensagem PesquisarHospede(CheckIn CheckIn)
        {
            SqlDataReader reader;

            try
            {
                con.Open(); //Abrindo a conexão com o servidor

                Mensagem.sql = "SELECT * FROM HOSPEDES WHERE DOCID = @DocId"; //Setando o comando SQL

                cmd = new SqlCommand(Mensagem.sql, con); //Executando o comando SQL

                cmd.Parameters.AddWithValue("@DocId", CheckIn.IdPesquisa); //Atribuindo o valor

                reader = cmd.ExecuteReader();

                if (reader.HasRows.Equals(false)) //Verificando se foi encontrado um registro dom o ID informado
                {
                    Mensagem.VerificaReturnFuncao = false;
                    Mensagem.TMensagem = "Erro: Não foi encontrado um cliente com este ID.";
                }
                else
                {
                    while (reader.Read()) //Lendo os dados do registro
                    {
                        CheckIn.NomePesquisa = Convert.ToString(reader["NOME"]);
                        CheckIn.IdPesquisa = Convert.ToString(reader["DOCID"]);

                        Mensagem.VerificaReturnFuncao = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Mensagem.VerificaReturnFuncao = false;
                Mensagem.TMensagem = "Erro: " + ex.Message;
            }
            finally
            {
                con.Close();
            }

            return Mensagem;
        }

        public CheckIn CarregarLista(CheckIn CheckIn)
        { 
            SqlDataAdapter DA;
            con = new SqlConnection(credenciais.constring);
            try
            {
                con.Open(); //Abindo a conexão com o servidor 

                Mensagem.sql = "SELECT NUMEROQUARTO FROM QUARTOS WHERE TIPODOQUARTO = @TipoDoQuarto AND STATUS = @Status"; //Setando o comando SQL 

                cmd = new SqlCommand(Mensagem.sql, con); //Executando o comando SQL
                
                //Atribuindo os valores
                cmd.Parameters.AddWithValue("@TipoDoQuarto", CheckIn.IdQuarto);
                cmd.Parameters.AddWithValue("@Status", "Livre");

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);

                CheckIn.Lista = new DataTable();

                DA.Fill(CheckIn.Lista); //Preenchento o DataAdapter com o DataTable ChecInk.Lista
            }
            catch
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados, por favor tente novamente em instantes. Se o problema persistir, entre em contato conosco pelos canais de atendimento.", "Erro: Conexão falhou", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            return CheckIn;
        }

        public Mensagem FinalizarCheckIn(CheckIn CheckIn)
        {
            try
            {
                con.Open(); //Abrindo a conexão com o servido

                Mensagem.sql = "UPDATE QUARTOS SET STATUS = @Status, HOSPEDES = @Hospedes , ENTRADA = @Entrada, SAÍDA = @Saída, VALOR = @Valor WHERE NUMEROQUARTO = @NumeroQuarto"; //Setando o comando SQL

                cmd = new SqlCommand(Mensagem.sql, con); //Executando o comando SQL

                //Atribuindo os valores

                cmd.Parameters.AddWithValue("@Status", "Indisponível");
                cmd.Parameters.AddWithValue("@Hospedes", CheckIn.NomePesquisa);
                cmd.Parameters.AddWithValue("@NumeroQuarto", CheckIn.NumeroQuarto);
                cmd.Parameters.AddWithValue("@Entrada", CheckIn.Chegada);
                cmd.Parameters.AddWithValue("@Saída", CheckIn.Saida);
                cmd.Parameters.AddWithValue("@Valor", CheckIn.ValorFinal);
                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0) //Verificando se houveram atualizações
                    Mensagem.TMensagem = "CheckIn realizado com sucesso!";
            }
            catch (Exception ex)
            {
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
