using Desktop.Controller;
using Desktop.Model;
using System;
using System.Windows.Forms;

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
            //Atribuindo o valor do TextBox para o atributo
            CheckOut.NumeroQuarto = txbProcurarQuarto.Text;

            //Chamada da função
            Mensagem = CTR_CheckOut.ProcurarQuarto(CheckOut);

            //Verificação de TextBox vazio
            if (Mensagem.TMensagem.Equals(string.Empty))
            {
                lviewTotal.Items.Clear();

                lviewTotal.Items.Add($"{CheckOut.NumeroQuarto}");
                lviewTotal.Items[0].SubItems.Add($"{CheckOut.Hospedadas}");
                lviewTotal.Items[0].SubItems.Add(" ");
                lviewTotal.Items[0].SubItems.Add(" ");

                //Verificação de quantidade de noites que o hóspede ficará hospedado
                if (CheckOut.PeriodoTotal > 1)
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
            //Atribuindo o valor do TextBox para o atributo
            CheckOut.NumeroQuarto = txbProcurarQuarto.Text;

            //Chamada da função
            Mensagem = CTR_CheckOut.FinalizarCheckOut(CheckOut);

            MessageBox.Show(Mensagem.TMensagem, "Sucesso", MessageBoxButtons.OK);

            lviewTotal.Items.Clear(); //Limpeza do ListView
            txbProcurarQuarto.Text = " "; //Limpeza do TextBox

            DialogResult = DialogResult.OK;
        }
    }
}
