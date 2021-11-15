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
    public partial class FRM_CheckOut : Form
    {
        CheckOut CheckOut;
        Mensagem Mensagem;
        public FRM_CheckOut()
        {
            InitializeComponent();
            CheckOut = new CheckOut();
            Mensagem = new Mensagem();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcurarQuarto_Click(object sender, EventArgs e)
        {
            Credenciais credenciais = new Credenciais();
            SqlDataReader reader;
            SqlConnection con = new SqlConnection(credenciais.constring);
            SqlCommand cmd;

            CheckOut.NumeroQuarto = txbProcurarQuarto.Text;

            try
            {
                con.Open();
                Mensagem.sql = "SELECT HOSPEDES, ENTRADA, SAÍDA, VALOR FROM QUARTOS WHERE NUMEROQUARTO = @NumeroQuarto";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@NumeroQuarto", CheckOut.NumeroQuarto);


                reader = cmd.ExecuteReader();

                if (reader.HasRows.Equals(false))
                {
                    Mensagem.TMensagem = "Erro: Não foi encontrado um quarto com este número.";
                    MessageBox.Show(Mensagem.TMensagem, "Erro: Quarto não encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    lviewTotal.Items.Add($"{CheckOut.NumeroQuarto}");
                    lviewTotal.Items[0].SubItems.Add($"{CheckOut.Hospedadas}");
                    lviewTotal.Items[0].SubItems.Add(" ");
                    lviewTotal.Items[0].SubItems.Add(" ");
                    lviewTotal.Items[0].SubItems[2].Text = Convert.ToString(Math.Ceiling((CheckOut.PeriodoFinal - CheckOut.PeriodoInicio).TotalDays)) + " Noites"; //Fazer uma verificação para quando for apenas uma noite e para quando for 2 ou mais.
                    lviewTotal.Items[0].SubItems[3].Text = "R$ " + CheckOut.Valor;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Credenciais credenciais = new Credenciais();
            SqlConnection con = new SqlConnection(credenciais.constring);
            SqlCommand cmd;

            CheckOut.NumeroQuarto = txbProcurarQuarto.Text;

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
                    MessageBox.Show("CheckOut finalizado.", "Pronto", MessageBoxButtons.OK);

                lviewTotal.Items.Clear();
                txbProcurarQuarto.Text = " ";
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
    }
}
