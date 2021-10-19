using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Desktop.Model;
using Desktop.Controller;

namespace Desktop.View
{
    public partial class FRM_Inicio : Form
    {
        public FRM_Inicio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            FRM_Hospede Frm_Hospede = new FRM_Hospede();
            Hide();
            Frm_Hospede.ShowDialog();
            Show();
        }
    }
}
