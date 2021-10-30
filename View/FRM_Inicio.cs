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
            FRM_PreCheckIn FRM_PreCheckIn = new FRM_PreCheckIn();
            Hide();
            FRM_PreCheckIn.ShowDialog();
            Show();
        }

        private void btnListaHospede_Click(object sender, EventArgs e)
        {
            FRM_ListaHospedes FRM_ListaHospedes = new FRM_ListaHospedes();
            Hide();
            FRM_ListaHospedes.ShowDialog();
            Show();
        }

        private void btnGerenciarQuartos_Click(object sender, EventArgs e)
        {
            FRM_GerenciarQuartos FRM_GerenciarQuartos = new FRM_GerenciarQuartos();
            Hide();
            FRM_GerenciarQuartos.ShowDialog();
            Show();
        }
    }
}
