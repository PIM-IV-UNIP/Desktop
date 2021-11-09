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
    public partial class FRM_ListaHospedes : Form
    {
        SqlCommand cmd;
        SqlDataAdapter DA;
        SqlConnection con = new SqlConnection(@"Data Source=35.198.4.184;Initial Catalog=BDHOTEL;User ID=sqlserver;Password=pim4semestre;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //connection string do BD
        Mensagem Mensagem = new Mensagem();
        DataTable lista;
        ListaHospede ListaHospede = new ListaHospede();

        public FRM_ListaHospedes()
        {
            InitializeComponent();
        }

        private void FRM_ListaHospedes_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnPesquise_Click(object sender, EventArgs e)
        {
            if (txbPesquise.Text.Equals(""))
            {
                MessageBox.Show("Por favor digite um Documento de ID para procurar!", "Erro: Sem ID",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ListaHospede.DocumentoID = txbPesquise.Text;
                try
                {

                    con.Open();
                    Mensagem.sql = "SELECT * FROM HOSPEDES WHERE DOCID = @DocumentoID";
                    cmd = new SqlCommand(Mensagem.sql, con);
                    cmd.Parameters.AddWithValue("@DocumentoID", ListaHospede.DocumentoID);

                    cmd.CommandType = CommandType.Text;

                    DA = new SqlDataAdapter(cmd);
                    lista = new DataTable();

                    DA.Fill(lista);
                }

                catch (Exception ex)
                {
                    Mensagem.TMensagem = "Erro: " + ex.ToString();
                    MessageBox.Show(Mensagem.TMensagem);
                }
                finally
                {
                    con.Close();
                }
                dgvListaHospedes.DataSource = lista;
                dgvListaHospedes.Refresh();
            }
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            dgvListaHospedes.DataSource = null;
            dgvListaHospedes.Columns.Clear();
            dgvListaHospedes.Rows.Clear();
            dgvListaHospedes.Refresh();
            try
            {
                con.Open();
                Mensagem.sql = "SELECT * FROM HOSPEDES";
                cmd = new SqlCommand(Mensagem.sql, con);

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);
                lista = new DataTable();

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
    }
}
