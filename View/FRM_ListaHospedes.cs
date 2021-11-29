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
        ListaHospedes ListaHospede;
        CTR_ListaHospedes CTR_ListaHospedes;

        public FRM_ListaHospedes()
        {
            InitializeComponent();
            ListaHospede = new ListaHospedes();
            CTR_ListaHospedes = new CTR_ListaHospedes();
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
            if (maskTxbPesquise.Text.Equals(""))
            {
                MessageBox.Show("Por favor digite um Documento de ID para procurar!", "Erro: Sem ID",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ListaHospede.DocumentoID = maskTxbPesquise.Text;

                CTR_ListaHospedes.PesquisarID(ListaHospede);             

                if(ListaHospede.Lista != null)
                {
                    if (ListaHospede.Lista.Rows.Count > 0)
                    {
                        dgvListaHospedes.DataSource = ListaHospede.Lista;
                        dgvListaHospedes.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado um cliente com o ID informado.", "Erro: ID não encontrado", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            dgvListaHospedes.DataSource = null;
            dgvListaHospedes.Columns.Clear();
            dgvListaHospedes.Rows.Clear();
            dgvListaHospedes.Refresh();

            CTR_ListaHospedes.CarregarLista(ListaHospede); 

            dgvListaHospedes.DataSource = ListaHospede.Lista;

        }

        private void maskTxbPesquise_Click(object sender, EventArgs e)
        {
            maskTxbPesquise.SelectionStart = 0;
        }
    }
}
