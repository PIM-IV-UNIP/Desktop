using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Desktop.Model;
using Desktop.Controller;

namespace Desktop.View
{
    public partial class FRM_Hospede : Form
    {
        Hospede Hospede;
        CTR_Hospede CTR_Hospede;
        Mensagem Mensagem;
        public FRM_Hospede()
        {
            InitializeComponent();
            Hospede = new Hospede();
            CTR_Hospede = new CTR_Hospede();
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

            Mensagem = CTR_Hospede.AdicionarHospede(Hospede);

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Mensagem = CTR_Hospede.ConsultarHospede(Hospede);

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Hospede.rgPessoa = Convert.ToDouble(txbRG.Text);
            Mensagem = CTR_Hospede.ExcluirHospede(Hospede);

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

    }
}
