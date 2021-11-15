using Desktop.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Desktop.View
{
    public partial class FRM_CheckIn : Form
    {
        CheckIn CheckIn;
        Mensagem Mensagem;
        public FRM_CheckIn()
        {
            InitializeComponent();
            CheckIn = new CheckIn();
            Mensagem = new Mensagem();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FRM_CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void lviewQuartos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) e.Item.Selected = false;
        }

        private void btnAddMaisHosp_Click(object sender, EventArgs e)
        {
            //Fazer a verificação de hospede duplicado

            /*CheckIn.teste = maskTxbRg.Text;

            if (CheckIn.teste.Equals(CheckIn.IdPesquisa))
            {
                MessageBox.Show(CheckIn.IdPesquisa);
            }
            else
            {
                MessageBox.Show(CheckIn.teste);
            }*/
            
                if (lviewSubTotal.Items[0].SubItems[1].Text.Equals(" "))
                {
                    CheckIn.AddPessoas = txbNome.Text;
                }
                else
                {
                    CheckIn.AddPessoas += ", " + txbNome.Text;
                }

            lviewSubTotal.Items[0].SubItems[1].Text = CheckIn.AddPessoas;
        }

        private void lviewSubTotal_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) e.Item.Selected = false;
        }

        private void btnEscolherQuartos_Click(object sender, EventArgs e)
        {
            lviewSubTotal.Items.Add(CheckIn.NumeroQuarto);
            lviewSubTotal.Items[0].SubItems.Add(" ");
            lviewSubTotal.Items[0].SubItems.Add(" ");
            lviewSubTotal.Items[0].SubItems.Add(" ");
            HabilitarDepoisQuartos();
            DeshabilitarEsquerda();

            //colocar os preos no lviewsubtotal
        }

        private void radBtnDelux_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Triplo";
            HabilitarControles();
            CheckIn.Valor = 270M;
        }

        private void radBtnDeuses_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Quádruplo";
            HabilitarControles();
            CheckIn.Valor = 360M;
        }

        private void radBtnFam_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Duplo";
            HabilitarControles();
            CheckIn.Valor = 180M;
        }

        private void radBtnStand_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Individual";
            HabilitarControles();
            CheckIn.Valor = 100M;
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            Credenciais credenciais = new Credenciais();
            SqlCommand cmd;
            SqlDataAdapter DA;
            SqlConnection con = new SqlConnection(credenciais.constring); //connection string do BD
            DataTable lista = new DataTable();

            dgvMapaQuartos.DataSource = null;
            dgvMapaQuartos.Columns.Clear();
            dgvMapaQuartos.Rows.Clear();
            dgvMapaQuartos.Refresh();
            try
            {
                con.Open();
                Mensagem.sql = "SELECT NUMEROQUARTO FROM QUARTOS WHERE TIPODOQUARTO = @TipoDoQuarto AND STATUS = @Status";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@TipoDoQuarto", CheckIn.IdQuarto);
                cmd.Parameters.AddWithValue("@Status", "Livre");

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);

                DA.Fill(lista);
            }

            catch (Exception ex)
            {
                Mensagem.TMensagem = "Erro: " + ex.ToString();
            }
            finally
            {
                con.Close();
            }
            dgvMapaQuartos.DataSource = lista;
        }

        private void cBoxSelectQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            Credenciais credenciais = new Credenciais();
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(credenciais.constring); //connection string do BD
            SqlDataReader reader;

            CheckIn.IdPesquisa = maskTxbRg.Text;

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
                    MessageBox.Show(Mensagem.TMensagem, "Erro: ID não encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    while (reader.Read())
                    {
                        CheckIn.NomePesquisa = Convert.ToString(reader["NOME"]);
                        CheckIn.IdPesquisa = Convert.ToString(reader["DOCID"]);
                    }
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

            maskTxbRg.Text = CheckIn.IdPesquisa;
            txbNome.Text = CheckIn.NomePesquisa;


        }

        private void dgvMapaQuartos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckIn.NumeroQuarto = Convert.ToString(dgvMapaQuartos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            btnEscolherQuartos.Enabled = true;
            btnEscolherQuartos.Visible = true;
        }

        private void maskTxbRg_Click(object sender, EventArgs e)
        {
            maskTxbRg.SelectionStart = 0;
        }

        private void btnFinalizarCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn.NumeroQuarto = lviewSubTotal.Items[0].Text;
            CheckIn.NomePesquisa = lviewSubTotal.Items[0].SubItems[1].Text;

            Credenciais credenciais = new Credenciais();
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(credenciais.constring); //connection string do BD

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

            MessageBox.Show(Mensagem.TMensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HabilitarControles()
        {
            //habilitando os controles
            btnCarregarLista.Enabled = true;
            dgvMapaQuartos.Enabled = true;


            //deixando-os visíveis
            btnCarregarLista.Visible = true;
            dgvMapaQuartos.Visible = true;
        }

        private void HabilitarDepoisQuartos()
        {
            //habilitando os controles
            maskTxbRg.Enabled = true;
            txbNome.Enabled = true;
            btnAddMaisHosp.Enabled = true;
            btnPesquisar.Enabled = true;
            lviewSubTotal.Enabled = true;
            btnFinalizarCheckIn.Enabled = true;
            lblPeriodo.Enabled = true;
            lblDe.Enabled = true;
            lblAte.Enabled = true;
            dateTimeFinal.Enabled = true;
            dateTimeInicio.Enabled = true;
            btnConfirmarData.Enabled = true;


            //deixando-os visíveis
            lblMaisHospedes.Visible = true;
            lblRG.Visible = true;
            maskTxbRg.Visible = true;
            txbNome.Visible = true;
            btnAddMaisHosp.Visible = true;
            btnPesquisar.Visible = true;
            lviewSubTotal.Visible = true;
            btnFinalizarCheckIn.Visible = true;
            lblPeriodo.Visible = true;
            lblAte.Visible = true;
            lblDe.Visible = true;
            dateTimeFinal.Visible = true;
            dateTimeInicio.Visible = true;
            btnConfirmarData.Visible = true;
        }

        private void DeshabilitarEsquerda()
        {
            //deshabilitando os componentes da esquerda
            btnCarregarLista.Enabled = false;
            dgvMapaQuartos.Enabled = false;
            lviewQuartos.Enabled = false;
            radBtnTriplo.Enabled = false;
            radBtnQuadruplo.Enabled = false;
            radBtnDuplo.Enabled = false;
            radBtnIndividual.Enabled = false;
            btnEscolherQuartos.Enabled = false;


            //deixando-os invisíveis
            btnCarregarLista.Visible = false;
            dgvMapaQuartos.Visible = false;
            lviewQuartos.Visible = false;
            radBtnTriplo.Visible = false;
            radBtnQuadruplo.Visible = false;
            radBtnDuplo.Visible = false;
            radBtnIndividual.Visible = false;
            btnEscolherQuartos.Visible = false;
        }

        private void btnConfirmarData_Click(object sender, EventArgs e)
        {
            CheckIn.Chegada = dateTimeInicio.Value;
            CheckIn.Saida = dateTimeFinal.Value;

            lviewSubTotal.Items[0].SubItems[2].Text = Convert.ToString(Math.Ceiling((CheckIn.Saida - CheckIn.Chegada).TotalDays)) + " Noites"; //Fazer uma verificação para quando for apenas uma noite e para quando for 2 ou mais.

            CheckIn.Valor = CheckIn.Valor * Convert.ToDecimal(Math.Ceiling((CheckIn.Saida - CheckIn.Chegada).TotalDays));

            lviewSubTotal.Items[0].SubItems[3].Text = "R$ " + Convert.ToString(CheckIn.Valor);
        }
    }
}
