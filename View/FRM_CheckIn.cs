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
            ListViewItem item = lviewSubTotal.FindItemWithText($"{CheckIn.NumeroQuarto}");
            if (!lviewSubTotal.Items.Contains(item))
            {
                lviewSubTotal.Items.Add($"{CheckIn.NumeroQuarto}");
                cBoxSelectQuarto.Items.Add($"{CheckIn.IdQuarto}: {CheckIn.NumeroQuarto}");
                HabilitarDepoisQuartos();
            }
            else
            {
                MessageBox.Show("Este quarto já foi adicionado!", "Aviso: Quarto já Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radBtnDelux_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Deluxe";
            HabilitarControles();
        }

        private void radBtnDeuses_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Suite dos Deuses";
            HabilitarControles();
        }

        private void radBtnFam_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Familia";
            HabilitarControles();
        }

        private void radBtnStand_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = "Quarto Standard";
            HabilitarControles();
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

        private void dgvMapaQuartos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckIn.NumeroQuarto = Convert.ToInt32(dgvMapaQuartos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            btnEscolherQuartos.Enabled = true;
            btnEscolherQuartos.Visible = true;
        }

        private void maskTxbRg_Click(object sender, EventArgs e)
        {
            maskTxbRg.SelectionStart = 0;
        }

        private void btnFinalizarCheckIn_Click(object sender, EventArgs e)
        {

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
            cBoxSelectQuarto.Enabled = true;
            btnAddMaisHosp.Enabled = true;
            btnPesquisar.Enabled = true;
            lviewSubTotal.Enabled = true;
            btnFinalizarCheckIn.Enabled = true;

            //deixando-os visíveis
            lblMaisHospedes.Visible = true;
            lblRG.Visible = true;
            maskTxbRg.Visible = true;
            txbNome.Visible = true;
            cBoxSelectQuarto.Visible = true;
            btnAddMaisHosp.Visible = true;
            btnPesquisar.Visible = true;
            lviewSubTotal.Visible = true;
            btnFinalizarCheckIn.Visible = true;
        }
    }
}
