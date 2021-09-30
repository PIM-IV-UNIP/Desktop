using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Frm_Hospede : Form
    {
        Hospede Hospede;
        Ctr_Hospede Ctr_Hospede;
        public Frm_Hospede()
        {
            InitializeComponent();
            Hospede = new Hospede();
            Ctr_Hospede = new Ctr_Hospede();
        }
        private void Frm_Hospede_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Hospede.nomePessoa = txbNome.Text;
            Hospede.emailPessoa = txbEmail.Text;
            Hospede.enderecoPessoa = txbEndereco.Text;
            Hospede.telfonePessoa = Convert.ToDouble(txbTelefone.Text);
            Hospede.rgPessoa = Convert.ToDouble(txbRG.Text);
            Hospede.nascimentoPessoa = Convert.ToDateTime(maskTxbNasc.Text);
            Hospede.nacionalidade = txbNacionalidade.Text;

            Mensagem Mensagem = new Mensagem();

            Mensagem = Ctr_Hospede.AdicionarHospede(Hospede);
            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txbNome.Text = Hospede.nomePessoa;
            txbEmail.Text = Hospede.emailPessoa;
            txbEndereco.Text = Hospede.enderecoPessoa;
            txbTelefone.Text = Convert.ToString(Hospede.telfonePessoa);
            txbRG.Text = Convert.ToString(Hospede.rgPessoa);
            maskTxbNasc.Text = Convert.ToString(Hospede.nascimentoPessoa);
            txbNacionalidade.Text = Hospede.nacionalidade;
        }
    }
}
