using System;
using System.Collections.Generic;
using System.Text;
using Desktop.Model;
using System.Data;
using System.Data.SqlClient;

namespace Desktop.Controller
{
    class CTR_GerenciarQuartos
    {
        GerenciarQuartos GerenciarQuartos = new GerenciarQuartos();
        Mensagem Mensagem = new Mensagem();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=35.198.4.184;Initial Catalog=BDHOTEL;User ID=sqlserver;Password=pim4semestre;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //connection string do BD


        public Mensagem AdicionarDeluxe(GerenciarQuartos GerenciarQuartos)
        {
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

        public Mensagem AdicionarStandard(GerenciarQuartos GerenciarQuartos)
        {
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
        public Mensagem AdicionarFamilia(GerenciarQuartos GerenciarQuartos)
        {
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
        public Mensagem AdicionarDeuses(GerenciarQuartos GerenciarQuartos)
        {
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
                Mensagem.TMensagem = ("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }

            return Mensagem;
        }

        public Mensagem AlterarQuarto(GerenciarQuartos GerenciarQuartos)
        {
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


