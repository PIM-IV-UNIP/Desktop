using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop.View
{
    public partial class FRM_CheckIn : Form
    {
        public FRM_CheckIn()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FRM_CheckIn_Load(object sender, EventArgs e)
        {
        }

        private void lviewQuartos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
