using Desktop.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Desktop.Controller;

namespace Desktop.View
{
    public partial class FRM_CheckIn : Form
    {
        CheckIn CheckIn;
        Mensagem Mensagem;
        CTR_CheckIn CTR_CheckIn;
        public FRM_CheckIn()
        {
            InitializeComponent();
            CheckIn = new CheckIn();
            Mensagem = new Mensagem();
            CheckIn = new CheckIn();
            CTR_CheckIn = new CTR_CheckIn();

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
            dgvMapaQuartos.DataSource = null;
            dgvMapaQuartos.Columns.Clear();
            dgvMapaQuartos.Rows.Clear();
            dgvMapaQuartos.Refresh();

            CTR_CheckIn.CarregarLista(CheckIn);
            
            dgvMapaQuartos.DataSource = CheckIn.Lista;
        }

        private void cBoxSelectQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            CheckIn.IdPesquisa = maskTxbRg.Text;

            Mensagem = CTR_CheckIn.PesquisarHospede(CheckIn);

            if (Mensagem.TMensagem.Equals(true))
            {
                maskTxbRg.Text = CheckIn.IdPesquisa;
                txbNome.Text = CheckIn.NomePesquisa;
            }
            else
            {
                MessageBox.Show(Mensagem.TMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            Mensagem = CTR_CheckIn.FinalizarCheckIn(CheckIn);

            MessageBox.Show(Mensagem.TMensagem, " ", MessageBoxButtons.OK);
        }

        private void HabilitarControles()
        {
            //deixando-os visíveis
            btnCarregarLista.Visible = true;
            dgvMapaQuartos.Visible = true;
        }

        private void HabilitarDepoisQuartos()
        {
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
