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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=35.198.4.184;Initial Catalog=BDHOTEL;User ID=sqlserver;Password=pim4semestre;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //connection string do BD
            SqlDataReader reader;

            CheckIn.IdPesquisa = maskTxbRg.Text;

            try
            {
                con.Open();
                Mensagem.sql = "SELECT NOME FROM HOSPEDES WHERE DOCID = @DocId";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@DocId", CheckIn.IdPesquisa);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CheckIn.IdPesquisa = Convert.ToString(reader["DOCID"]);
                    CheckIn.NomePesquisa = Convert.ToString(reader["NOME"]);
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

        private void lviewSubTotal_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) e.Item.Selected = false;
        }

        private void btnEscolherQuartos_Click(object sender, EventArgs e)
        {
            lviewSubTotal.Items.Add(CheckIn.NumeroQuarto);
            lviewSubTotal.Items[0].SubItems.Add(" ");
            HabilitarDepoisQuartos();
            DeshabilitarEsquerda();

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

            //deixando-os visíveis
            lblMaisHospedes.Visible = true;
            lblRG.Visible = true;
            maskTxbRg.Visible = true;
            txbNome.Visible = true;
            btnAddMaisHosp.Visible = true;
            btnPesquisar.Visible = true;
            lviewSubTotal.Visible = true;
            btnFinalizarCheckIn.Visible = true;
        }

        private void DeshabilitarEsquerda()
        {
            //deshabilitando os componentes da esquerda
            btnCarregarLista.Enabled = false;
            dgvMapaQuartos.Enabled = false;
            lviewQuartos.Enabled = false;
            radBtnDelux.Enabled = false;
            radBtnDeuses.Enabled = false;
            radBtnFam.Enabled = false;
            radBtnStand.Enabled = false;
            btnEscolherQuartos.Enabled = false;


            //deixando-os invisíveis
            btnCarregarLista.Visible = false;
            dgvMapaQuartos.Visible = false;
            lviewQuartos.Visible = false;
            radBtnDelux.Visible = false;
            radBtnDeuses.Visible = false;
            radBtnFam.Visible = false;
            radBtnStand.Visible = false;
            btnEscolherQuartos.Visible = false;
        }
    }
}
