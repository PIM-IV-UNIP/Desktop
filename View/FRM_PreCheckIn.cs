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
            Hide();
            FRM_Hospede FRM_Hospede = new FRM_Hospede();
            FRM_Hospede.ShowDialog();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_CheckIn FRM_CheckIn = new FRM_CheckIn();
            FRM_CheckIn.ShowDialog();
        }

        private void lblPergunta_Click(object sender, EventArgs e)
        {

        }
    }
}
