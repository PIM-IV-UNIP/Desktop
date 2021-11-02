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
            Hospede.idPessoa = maskTxbRg.Text;
            Hospede.nascimentoPessoa = Convert.ToDateTime(maskTxbNasc.Text);
            Hospede.nacionalidade = txbNacionalidade.Text;
            Hospede.cpfPessoa = Convert.ToDouble(maskTxbCpf.Text);
            Hospede.localNascimento = txbLocalNasc.Text;

            Mensagem = CTR_Hospede.AdicionarHospede(Hospede);

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Hospede.idPessoa = masktxbPesquisaID.Text;

            Mensagem = CTR_Hospede.ConsultarHospede(Hospede);

            txbNome.Text = Hospede.nomePessoa;
            txbEmail.Text = Hospede.emailPessoa;
            txbEndereco.Text = Hospede.enderecoPessoa;
            txbTelefone.Text = (Hospede.telefonePessoa);
            maskTxbRg.Text = Convert.ToString(Hospede.idPessoa);
            maskTxbNasc.Text = Convert.ToString(Hospede.nascimentoPessoa);
            txbNacionalidade.Text = Hospede.nacionalidade;
            txbLocalNasc.Text = Hospede.localNascimento;
            maskTxbCpf.Text = Convert.ToString(Hospede.cpfPessoa);
            txbLocalNasc.Text = Hospede.localNascimento;

            MessageBox.Show(Mensagem.TMensagem);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Hospede.Limpar();

            txbNome.Text = Hospede.nomePessoa;
            txbEmail.Text = Hospede.emailPessoa;
            txbEndereco.Text = Hospede.enderecoPessoa;
            txbTelefone.Text = (Hospede.telefonePessoa);
            maskTxbRg.Text = Convert.ToString(Hospede.idPessoa);
            maskTxbNasc.Text = Convert.ToString(Hospede.nascimentoPessoa);
            txbNacionalidade.Text = Hospede.nacionalidade;
            txbLocalNasc.Text = Hospede.localNascimento;
            maskTxbCpf.Text = Convert.ToString(Hospede.cpfPessoa);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Hospede.idPessoa = masktxbPesquisaID.Text;

            Mensagem = CTR_Hospede.ExcluirHospede(Hospede);

            Hospede.Limpar();

            txbNome.Text = Hospede.nomePessoa;
            txbEmail.Text = Hospede.emailPessoa;
            txbEndereco.Text = Hospede.enderecoPessoa;
            txbTelefone.Text = (Hospede.telefonePessoa);
            masktxbPesquisaID.Text = Convert.ToString(Hospede.idPessoa);
            maskTxbRg.Text = Convert.ToString(Hospede.idPessoa);
            maskTxbNasc.Text = Convert.ToString(Hospede.nascimentoPessoa);
            txbNacionalidade.Text = Hospede.nacionalidade;
            txbLocalNasc.Text = Hospede.localNascimento;
            maskTxbCpf.Text = Convert.ToString(Hospede.cpfPessoa);

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Hospede.nomePessoa = txbNome.Text;
            Hospede.emailPessoa = txbEmail.Text;
            Hospede.enderecoPessoa = txbEndereco.Text;
            Hospede.telefonePessoa = txbTelefone.Text;
            Hospede.idPessoa = maskTxbRg.Text;
            Hospede.nascimentoPessoa = Convert.ToDateTime(maskTxbNasc.Text);
            Hospede.nacionalidade = txbNacionalidade.Text;
            Hospede.cpfPessoa = Convert.ToDouble(maskTxbCpf.Text);
            Hospede.localNascimento = txbLocalNasc.Text;
            
            Mensagem = CTR_Hospede.AtualizarHospede(Hospede);

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnProsseguirCheckIn_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_CheckIn FRM_CheckIn = new FRM_CheckIn();
            FRM_CheckIn.Show();
        }
    }
}
