using Desktop.Model;
using System;
using System.Windows.Forms;

namespace Desktop.View
{
    public partial class FRM_CheckIn : Form
    {
        CheckIn CheckIn;
        public FRM_CheckIn()
        {
            InitializeComponent();
            CheckIn = new CheckIn();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FRM_CheckIn_Load(object sender, EventArgs e)
        {
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Quarto selecionado: " + CheckIn.IdQuarto);
        }

        private void lviewQuartos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) e.Item.Selected = false;
        }

        private void btnAddMaisHosp_Click(object sender, EventArgs e)
        {
            
            lviewSubTotal.Items[0].SubItems.Add(txbNome.Text);
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
            FRM_MapaQuartos FRM_MapaQuartos = new FRM_MapaQuartos();
            Hide();
            FRM_MapaQuartos.ShowDialog();
            Show();
        }

        private void radBtnDelux_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = 2;
            btnEscolherQuartos.Enabled = true;
        }

        private void radBtnDeuses_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = 1;
            btnEscolherQuartos.Enabled = true;
        }

        private void radBtnFam_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = 3;
            btnEscolherQuartos.Enabled = true;
        }

        private void radBtnStand_CheckedChanged(object sender, EventArgs e)
        {
            CheckIn.IdQuarto = 4;
            btnEscolherQuartos.Enabled = true;
        }
    }
}
