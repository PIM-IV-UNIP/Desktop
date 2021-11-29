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
    public partial class FRM_GerenciarQuartos : Form
    {
        GerenciarQuartos GerenciarQuartos;
        CTR_GerenciarQuartos CTR_GerenciarQuartos;
        Mensagem Mensagem;
        public FRM_GerenciarQuartos()
        {
            InitializeComponent();
            GerenciarQuartos = new GerenciarQuartos();
            CTR_GerenciarQuartos = new CTR_GerenciarQuartos();
            Mensagem = new Mensagem();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnAddQuarto_Click(object sender, EventArgs e)
        {
            GerenciarQuartos.TipoQuarto = (cmbTiposQuartos.SelectedIndex.ToString());

            if (txbNumeroQuarto.Text.Equals(""))
            {
                MessageBox.Show("Você não selecionou um quarto!", "Erro: Quarto não selecionado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else {
                switch (GerenciarQuartos.TipoQuarto)
                {
                    case "0":
                        GerenciarQuartos.TipoQuarto = cmbTiposQuartos.SelectedItem.ToString();
                        GerenciarQuartos.NumeroQuarto = Convert.ToInt32(txbNumeroQuarto.Text);
                        Mensagem = CTR_GerenciarQuartos.AdicionarQuadruplo(GerenciarQuartos);
                        MessageBox.Show(Mensagem.TMensagem);
                        break;

                    case "1":
                        GerenciarQuartos.TipoQuarto = cmbTiposQuartos.SelectedItem.ToString();
                        GerenciarQuartos.NumeroQuarto = Convert.ToInt32(txbNumeroQuarto.Text);
                        Mensagem = CTR_GerenciarQuartos.AdicionarTriplo(GerenciarQuartos);
                        MessageBox.Show(Mensagem.TMensagem);
                        break;

                    case "2":
                        GerenciarQuartos.TipoQuarto = cmbTiposQuartos.SelectedItem.ToString();
                        GerenciarQuartos.NumeroQuarto = Convert.ToInt32(txbNumeroQuarto.Text);
                        Mensagem = CTR_GerenciarQuartos.AdicionarDuplo(GerenciarQuartos);
                        MessageBox.Show(Mensagem.TMensagem);
                        break;

                    case "3":
                        GerenciarQuartos.TipoQuarto = cmbTiposQuartos.SelectedItem.ToString();
                        GerenciarQuartos.NumeroQuarto = Convert.ToInt32(txbNumeroQuarto.Text);
                        Mensagem = CTR_GerenciarQuartos.AdicionarIndividual(GerenciarQuartos);
                        MessageBox.Show(Mensagem.TMensagem);
                        break;
                }
            }
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            dgvListaHospedes.DataSource = null;
            dgvListaHospedes.Columns.Clear();
            dgvListaHospedes.Rows.Clear();
            dgvListaHospedes.Refresh();

            CTR_GerenciarQuartos.CarregarLista(GerenciarQuartos);

            dgvListaHospedes.DataSource = GerenciarQuartos.Lista;

            AparecerLadoEsquerdo();

        }

        private void btnAlterarQuarto_Click(object sender, EventArgs e)
        {
            if (txbNumeroQuarto.Text.Equals("")) 
            {
                MessageBox.Show("Você não selecionou um quarto!", "Erro: Quarto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GerenciarQuartos.NumeroQuarto = Convert.ToInt32(txbNumeroQuarto.Text);
                GerenciarQuartos.TipoQuarto = cmbTiposQuartos.SelectedItem.ToString();

                Mensagem = CTR_GerenciarQuartos.AlterarQuarto(GerenciarQuartos);
                MessageBox.Show(Mensagem.TMensagem);
            }
        }

        private void dgvListaHospedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaHospedes.CurrentRow.Cells["Status"].Value.Equals("Indisponível"))
            {
                MessageBox.Show("Este quarto está ocupado, selecione outro quarto para editar!", "Erro: Quarto Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txbNumeroQuarto.Text = Convert.ToString(dgvListaHospedes.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        public void AparecerLadoEsquerdo()
        {
            btnAddQuarto.Visible = true;
            btnAlterarQuarto.Visible = true;
            lblNumeroQuarto.Visible = true;
            lblTipoQuarto.Visible = true;
            txbNumeroQuarto.Visible = true;
            cmbTiposQuartos.Visible = true;
        }
    }
}
