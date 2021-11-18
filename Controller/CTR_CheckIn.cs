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
        CheckIn CheckIn = new CheckIn();
        Mensagem Mensagem = new Mensagem();
        Credenciais credenciais = new Credenciais();
        SqlConnection con;
        SqlCommand cmd;

        public Mensagem PesquisarHospede(CheckIn CheckIn)
        {
            SqlDataReader reader;

            try
            {
                con.Open();
                Mensagem.sql = "SELECT * FROM HOSPEDES WHERE DOCID = @DocId";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@DocId", CheckIn.IdPesquisa);

                reader = cmd.ExecuteReader();

                if (reader.HasRows.Equals(false))
                {
                    Mensagem.TMensagem = "Erro: Não foi encontrado um cliente com este ID.";
                }
                else
                {
                    while (reader.Read())
                    {
                        CheckIn.NomePesquisa = Convert.ToString(reader["NOME"]);
                        CheckIn.IdPesquisa = Convert.ToString(reader["DOCID"]);

                        Mensagem.TMensagem = "Sucesso";
                    }
                }
            }
            catch (Exception ex)
            {
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
                con.Open();
                Mensagem.sql = "SELECT NUMEROQUARTO FROM QUARTOS WHERE TIPODOQUARTO = @TipoDoQuarto AND STATUS = @Status";
                cmd = new SqlCommand(Mensagem.sql, con);
                
                cmd.Parameters.AddWithValue("@TipoDoQuarto", CheckIn.IdQuarto);
                cmd.Parameters.AddWithValue("@Status", "Livre");

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);

                CheckIn.Lista = new DataTable();

                DA.Fill(CheckIn.Lista);
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
                con.Open(); //conectando ao BD
                Mensagem.sql = "UPDATE QUARTOS SET STATUS = @Status, HOSPEDES = @Hospedes , ENTRADA = @Entrada, SAÍDA = @Saída, VALOR = @Valor WHERE NUMEROQUARTO = @NumeroQuarto";
                cmd = new SqlCommand(Mensagem.sql, con);

                cmd.Parameters.AddWithValue("@Status", "Indisponível");
                cmd.Parameters.AddWithValue("@Hospedes", CheckIn.NomePesquisa);
                cmd.Parameters.AddWithValue("@NumeroQuarto", CheckIn.NumeroQuarto);
                cmd.Parameters.AddWithValue("@Entrada", CheckIn.Chegada);
                cmd.Parameters.AddWithValue("@Saída", CheckIn.Saida);
                cmd.Parameters.AddWithValue("@Valor", CheckIn.Valor);
                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "CheckIn realizado com sucesso!";
            }
            catch (Exception ex)
            {
                Mensagem.TMensagem = ("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }

            return Mensagem;
        }
    }
}
