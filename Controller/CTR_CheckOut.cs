using System;
using System.Collections.Generic;
using System.Text;
using Desktop.Model;
using System.Data.SqlClient;
using System.Data;

namespace Desktop.Controller
{
    class CTR_CheckOut
    {
        Mensagem Mensagem = new Mensagem();
        Credenciais credenciais = new Credenciais();
        SqlDataReader reader;
        SqlConnection con;
        SqlCommand cmd;

        public Mensagem ProcurarQuarto(CheckOut CheckOut)
        {
            con = new SqlConnection(credenciais.constring);

            try
            {
                con.Open();
                Mensagem.sql = "SELECT HOSPEDES, ENTRADA, SAÍDA, VALOR FROM QUARTOS WHERE NUMEROQUARTO = @NumeroQuarto AND STATUS = @Status";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@NumeroQuarto", CheckOut.NumeroQuarto);
                cmd.Parameters.AddWithValue("@Status", "Indisponível");

                reader = cmd.ExecuteReader();

                if (reader.HasRows.Equals(false))
                {
                    Mensagem.TMensagem = "Erro: Não foi encontrado um ocupado com este número.";
                }
                else
                {
                    while (reader.Read())
                    {
                        CheckOut.PeriodoFinal = Convert.ToDateTime(reader["SAÍDA"]);
                        CheckOut.PeriodoInicio = Convert.ToDateTime(reader["ENTRADA"]);
                        CheckOut.Hospedadas = Convert.ToString(reader["HOSPEDES"]);
                        CheckOut.Valor = Convert.ToDecimal(reader["VALOR"]);
                    }

                    CheckOut.PeriodoTotal = Math.Ceiling((CheckOut.PeriodoFinal - CheckOut.PeriodoInicio).TotalDays);
                    Mensagem.TMensagem = string.Empty;
                }
            }

            catch (Exception ex)
            {
                Mensagem.TMensagem = "Erro: " + ex.ToString();
            }
            finally
            {
                con.Close();
            }

            return Mensagem;
        }

        public Mensagem FinalizarCheckOut(CheckOut CheckOut)
        {
            con = new SqlConnection(credenciais.constring);

            try
            {
                con.Open(); //conectando ao BD
                Mensagem.sql = "UPDATE QUARTOS set STATUS = @Status, HOSPEDES = @Hospedes, Entrada = @Entrada, SAÍDA = @Saída, VALOR = @Valor WHERE NUMEROQUARTO = @NumeroQuarto";
                cmd = new SqlCommand(Mensagem.sql, con);

                cmd.Parameters.AddWithValue("@Status", "Livre");
                cmd.Parameters.AddWithValue("@Hospedes", string.Empty);
                cmd.Parameters.AddWithValue("@Entrada", string.Empty);
                cmd.Parameters.AddWithValue("@Saída", string.Empty);
                cmd.Parameters.AddWithValue("@Valor", decimal.Zero);
                cmd.Parameters.AddWithValue("@NumeroQuarto", CheckOut.NumeroQuarto);

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "CheckOut finalizado.";
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
    }
}
