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
    public partial class FRM_CheckOut : Form
    {
        CheckOut CheckOut;
        Mensagem Mensagem;
        CTR_CheckOut CTR_CheckOut;
        public FRM_CheckOut()
        {
            InitializeComponent();
            CheckOut = new CheckOut();
            Mensagem = new Mensagem();
            CTR_CheckOut = new CTR_CheckOut();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcurarQuarto_Click(object sender, EventArgs e)
        {
            CheckOut.NumeroQuarto = txbProcurarQuarto.Text;

            Mensagem = CTR_CheckOut.ProcurarQuarto(CheckOut);

            if (Mensagem.TMensagem.Equals(string.Empty))
            {
                lviewTotal.Items.Clear();

                lviewTotal.Items.Add($"{CheckOut.NumeroQuarto}");
                lviewTotal.Items[0].SubItems.Add($"{CheckOut.Hospedadas}");
                lviewTotal.Items[0].SubItems.Add(" ");
                lviewTotal.Items[0].SubItems.Add(" ");

                if(CheckOut.PeriodoTotal > 1)
                    lviewTotal.Items[0].SubItems[2].Text = Convert.ToString(CheckOut.PeriodoTotal) + " Noites";
                else
                    lviewTotal.Items[0].SubItems[2].Text = Convert.ToString(CheckOut.PeriodoTotal) + " Noite";

                lviewTotal.Items[0].SubItems[3].Text = "R$ " + CheckOut.Valor;
            }
            else
            {
                MessageBox.Show(Mensagem.TMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            CheckOut.NumeroQuarto = txbProcurarQuarto.Text;

            Mensagem = CTR_CheckOut.FinalizarCheckOut(CheckOut);

            MessageBox.Show(Mensagem.TMensagem, "Sucesso", MessageBoxButtons.OK);

            lviewTotal.Items.Clear();
            txbProcurarQuarto.Text = " ";
        }
    }
}
