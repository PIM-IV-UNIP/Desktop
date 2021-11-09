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
                        Mensagem = CTR_GerenciarQuartos.AdicionarDeluxe(GerenciarQuartos);
                        MessageBox.Show(Mensagem.TMensagem);
                        break;

                    case "1":
                        GerenciarQuartos.TipoQuarto = cmbTiposQuartos.SelectedItem.ToString();
                        GerenciarQuartos.NumeroQuarto = Convert.ToInt32(txbNumeroQuarto.Text);
                        Mensagem = CTR_GerenciarQuartos.AdicionarFamilia(GerenciarQuartos);
                        MessageBox.Show(Mensagem.TMensagem);
                        break;

                    case "2":
                        GerenciarQuartos.TipoQuarto = cmbTiposQuartos.SelectedItem.ToString();
                        GerenciarQuartos.NumeroQuarto = Convert.ToInt32(txbNumeroQuarto.Text);
                        Mensagem = CTR_GerenciarQuartos.AdicionarStandard(GerenciarQuartos);
                        MessageBox.Show(Mensagem.TMensagem);
                        break;

                    case "3":
                        GerenciarQuartos.TipoQuarto = cmbTiposQuartos.SelectedItem.ToString();
                        GerenciarQuartos.NumeroQuarto = Convert.ToInt32(txbNumeroQuarto.Text);
                        Mensagem = CTR_GerenciarQuartos.AdicionarDeuses(GerenciarQuartos);
                        MessageBox.Show(Mensagem.TMensagem);
                        break;
                }
            }
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataAdapter DA;
            SqlConnection con = new SqlConnection(@"Data Source=35.198.4.184;Initial Catalog=BDHOTEL;User ID=sqlserver;Password=pim4semestre;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //connection string do BD;
            DataTable lista = new DataTable();

            dgvListaHospedes.DataSource = null;
            dgvListaHospedes.Columns.Clear();
            dgvListaHospedes.Rows.Clear();
            dgvListaHospedes.Refresh();
            try
            {
                con.Open();
                Mensagem.sql = "SELECT * FROM QUARTOS";
                cmd = new SqlCommand(Mensagem.sql, con);

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
            dgvListaHospedes.DataSource = lista;
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
                int val;

                if (int.TryParse(GerenciarQuartos.Validar, out val).Equals(true))
                {
                    txbNumeroQuarto.Text = Convert.ToString(dgvListaHospedes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                else
                {
                    MessageBox.Show("Selecione o número do quarto!", "Erro: Número do quarto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
