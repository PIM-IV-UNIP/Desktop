using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop.View
{
    public partial class FRM_MapaQuartos : Form
    {
        public FRM_MapaQuartos()
        {
            InitializeComponent();
        }

        private void FRM_MapaQuartos_Load(object sender, EventArgs e)
        {

        }
        
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
