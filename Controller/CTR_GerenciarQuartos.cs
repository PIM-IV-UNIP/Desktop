using System;
using System.Collections.Generic;
using System.Text;
using Desktop.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Desktop.Controller
{
    class CTR_GerenciarQuartos
    {
        Mensagem Mensagem = new Mensagem();
        SqlCommand cmd;
        Credenciais cred = new Credenciais();
        SqlConnection con;

        public Mensagem AdicionarTriplo(GerenciarQuartos GerenciarQuartos)
        {
            con = new SqlConnection(cred.constring);

            try
            {
                con.Open();

                //insert na tabela quartos
                Mensagem.sql = "INSERT INTO QUARTOS (NUMEROQUARTO, TIPODOQUARTO, STATUS) VALUES (@NumeroQuarto, @TipoDoQuarto, @Status)";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@NumeroQuarto", GerenciarQuartos.NumeroQuarto);
                cmd.Parameters.AddWithValue("@TipoDoQuarto", GerenciarQuartos.TipoQuarto);
                cmd.Parameters.AddWithValue("@Status", "Livre");

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "Quarto adicionado com sucesso à categoria Triplo.";
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

        public Mensagem AdicionarIndividual(GerenciarQuartos GerenciarQuartos)
        {
            con = new SqlConnection(cred.constring);
            try
            {
                con.Open();

                //insert na tabela quartos
                Mensagem.sql = "INSERT INTO QUARTOS (NUMEROQUARTO, TIPODOQUARTO, STATUS) VALUES (@NumeroQuarto, @TipoDoQuarto, @Status)";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@NumeroQuarto", GerenciarQuartos.NumeroQuarto);
                cmd.Parameters.AddWithValue("@TipoDoQuarto", GerenciarQuartos.TipoQuarto);
                cmd.Parameters.AddWithValue("@Status", "Livre");

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "Quarto adicionado com sucesso à categoria Individual.";
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
        public Mensagem AdicionarDuplo(GerenciarQuartos GerenciarQuartos)
        {
            con = new SqlConnection(cred.constring);
            try
            {
                con.Open();

                //insert na tabela quartos
                Mensagem.sql = "INSERT INTO QUARTOS (NUMEROQUARTO, TIPODOQUARTO, STATUS) VALUES (@NumeroQuarto, @TipoDoQuarto, @Status)";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@NumeroQuarto", GerenciarQuartos.NumeroQuarto);
                cmd.Parameters.AddWithValue("@TipoDoQuarto", GerenciarQuartos.TipoQuarto);
                cmd.Parameters.AddWithValue("@Status", "Livre");

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "Quarto adicionado com sucesso à categoria Duplo.";
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
        public Mensagem AdicionarQuadruplo(GerenciarQuartos GerenciarQuartos)
        {
            con = new SqlConnection(cred.constring);

            try
            {
                con.Open();

                //insert na tabela QUARTOS na categoria deuses
                Mensagem.sql = "INSERT INTO QUARTOS (NUMEROQUARTO, TIPODOQUARTO, STATUS) VALUES (@NumeroQuarto, @TipoDoQuarto, @Status)";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@NumeroQuarto", GerenciarQuartos.NumeroQuarto);
                cmd.Parameters.AddWithValue("@TipoDoQuarto", GerenciarQuartos.TipoQuarto);
                cmd.Parameters.AddWithValue("@Status", "Livre");

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "Quarto adicionado com sucesso à categoria Quádruplo.";
            }
            catch (Exception ex)
            {
                Mensagem.TMensagem = "Erro: " + ex.ToString();
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }

            return Mensagem;
        }

        public Mensagem AlterarQuarto(GerenciarQuartos GerenciarQuartos)
        {
            con = new SqlConnection(cred.constring);

            try
            {
                con.Open();

                Mensagem.sql = "UPDATE QUARTOS SET TIPODOQUARTO = @TipoDoQuarto WHERE NUMEROQUARTO = @NumeroQuarto";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@NumeroQuarto", GerenciarQuartos.NumeroQuarto);
                cmd.Parameters.AddWithValue("@TipoDoQuarto", GerenciarQuartos.TipoQuarto);

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();
                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "Tipo do quarto atualizado com sucesso.";
            }
            catch (Exception ex)
            {
                Mensagem.TMensagem = "Erro: " + ex.ToString();
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }

            return Mensagem;
        }

        public GerenciarQuartos CarregarLista(GerenciarQuartos GerenciarQuartos)
        {
            SqlDataAdapter DA;
            con = new SqlConnection(cred.constring);

            try
            {
                con.Open();
                Mensagem.sql = "SELECT * FROM QUARTOS";
                cmd = new SqlCommand(Mensagem.sql, con);

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);

                GerenciarQuartos.Lista = new DataTable();

                DA.Fill(GerenciarQuartos.Lista);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados, por favor tente novamente em instantes. Se o problema persistir, entre em contato conosco pelos canais de atendimento.", "Erro: Conexão falhou", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            return GerenciarQuartos;
        }
    } 
}


