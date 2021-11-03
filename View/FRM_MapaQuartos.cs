using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Desktop.Model;
using Desktop.Controller;

namespace Desktop.View
{
    public partial class FRM_MapaQuartos : Form
    {
        Mensagem Mensagem;
        MapaQuartos MapaQuartos;
        public FRM_MapaQuartos()
        {
            InitializeComponent();
            Mensagem = new Mensagem();
            MapaQuartos = new MapaQuartos();
        }

        private void FRM_MapaQuartos_Load(object sender, EventArgs e)
        {

            SqlCommand cmd;
            SqlDataAdapter DA;
            SqlConnection con = new SqlConnection(@"Data Source=35.198.4.184;Initial Catalog=BDHOTEL;User ID=sqlserver;Password=pim4semestre;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //connection string do BD
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
                cmd.Parameters.AddWithValue("@TipoDoQuarto", MapaQuartos.TipoQuarto);

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

        private void btnSelecionarQuartos_Click(object sender, EventArgs e)
        {
            MapaQuartos.NumeroQuarto = Convert.ToInt32(txbDigiteQuarto.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
