using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Frm_Hospede : Form
    {
        Hospede Hospede;
        Ctr_Hospede Ctr_Hospede;
        Mensagem Mensagem;
        public Frm_Hospede()
        {
            InitializeComponent();
            Hospede = new Hospede();
            Ctr_Hospede = new Ctr_Hospede();
            Mensagem = new Mensagem();
        }
        private void Frm_Hospede_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Hospede.nomePessoa = txbNome.Text;
            Hospede.emailPessoa = txbEmail.Text;
            Hospede.enderecoPessoa = txbEndereco.Text;
            Hospede.telefonePessoa = txbTelefone.Text;
            Hospede.rgPessoa = Convert.ToDouble(txbRG.Text);
            Hospede.nascimentoPessoa = Convert.ToDateTime(maskTxbNasc.Text);
            Hospede.nacionalidade = txbNacionalidade.Text;

            Mensagem = Ctr_Hospede.AdicionarHospede(Hospede);

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Mensagem = Ctr_Hospede.ConsultarHospede(Hospede);
            
                txbNome.Text = Hospede.nomePessoa;
                txbEmail.Text = Hospede.emailPessoa;
                txbEndereco.Text = Hospede.enderecoPessoa;
                txbTelefone.Text = (Hospede.telefonePessoa);
                txbRG.Text = Convert.ToString(Hospede.rgPessoa);
                maskTxbNasc.Text = Convert.ToString(Hospede.nascimentoPessoa);
                txbNacionalidade.Text = Hospede.nacionalidade;
            MessageBox.Show(Mensagem.TMensagem);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = " ";
            txbEmail.Text = " ";
            txbEndereco.Text = " ";
            txbTelefone.Text = " ";
            txbRG.Text = " " ;
            maskTxbNasc.Text = " ";
            txbNacionalidade.Text = " ";
        }
    }
}
