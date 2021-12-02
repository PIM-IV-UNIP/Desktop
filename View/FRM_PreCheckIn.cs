using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop.View
{
    public partial class FRM_PreCheckIn : Form
    {
        public FRM_PreCheckIn()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Esconte a tela de PreCheckIn e abre a tela de Hóspede
            Hide();
            FRM_Hospede FRM_Hospede = new FRM_Hospede();
            FRM_Hospede.ShowDialog();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            //Esconte a tela de PreCheckIn e abre a tela de CheckIn
            Hide();
            FRM_CheckIn FRM_CheckIn = new FRM_CheckIn();
            FRM_CheckIn.ShowDialog();
        }

        private void lblPergunta_Click(object sender, EventArgs e)
        {

        }
    }
}
