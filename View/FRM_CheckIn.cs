using Desktop.Model;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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
            if (lviewSubTotal.Items[cBoxSelectQuarto.SelectedIndex].SubItems[1].Text.Equals(" "))
            {
                CheckIn.AddPessoas = txbNome.Text;
            }
            else
            {
                CheckIn.AddPessoas += ", " + txbNome.Text;
            }

            lviewSubTotal.Items[cBoxSelectQuarto.SelectedIndex].SubItems[1].Text = CheckIn.AddPessoas;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void lviewSubTotal_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) e.Item.Selected = false;
        }

        private void btnEscolherQuartos_Click(object sender, EventArgs e)
        {
            lviewSubTotal.Items.Add($"{CheckIn.NumeroQuarto}");
            cBoxSelectQuarto.Items.Add($"{CheckIn.IdQuarto}: {CheckIn.NumeroQuarto}");

        }

        private void radBtnDelux_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Deluxe";
            btnCarregarLista.Enabled = true;
        }

        private void radBtnDeuses_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Suite dos Deuses";
            btnCarregarLista.Enabled = true;
        }

        private void radBtnFam_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Familia";
            btnCarregarLista.Enabled = true;
        }

        private void radBtnStand_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Standard";
            btnCarregarLista.Enabled = true;
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
                Mensagem.sql = "SELECT NUMEROQUARTO FROM QUARTOS WHERE TIPODOQUARTO = @TipoDoQuarto";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@TipoDoQuarto", CheckIn.IdQuarto);

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

        private void dgvMapaQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckIn.NumeroQuarto = Convert.ToInt32(dgvMapaQuartos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            btnEscolherQuartos.Enabled = true;
        }

        private void cBoxSelectQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lviewSubTotal.Items[cBoxSelectQuarto.SelectedIndex].SubItems.Add(" ");
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            Credenciais credenciais = new Credenciais();
            Hospede Hospede = new Hospede();
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(credenciais.constring); //connection string do BD
            SqlDataReader reader;

            Hospede.idPessoa = maskTxbRg.Text;

            try
            {
                con.Open();
                Mensagem.sql = "SELECT * FROM HOSPEDES WHERE DOCID = @DocId";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@DocId", Hospede.idPessoa);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Hospede.nomePessoa = Convert.ToString(reader["NOME"]);
                    Hospede.idPessoa = Convert.ToString(reader["DOCID"]);
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

            maskTxbRg.Text = Hospede.idPessoa;
            txbNome.Text = Hospede.nomePessoa;

        }
    }
}
