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
            SetarAtributos();

            Mensagem = CTR_Hospede.AdicionarHospede(Hospede);

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Hospede.IDPessoa = masktxbPesquisaID.Text;

            Mensagem = CTR_Hospede.ConsultarHospede(Hospede);

            SetarTextbox();

            MessageBox.Show(Mensagem.TMensagem);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Hospede.Limpar();

            SetarTextbox();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Hospede.IDPessoa = masktxbPesquisaID.Text;

            Mensagem = CTR_Hospede.ExcluirHospede(Hospede);

            Hospede.Limpar();

            SetarTextbox();

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SetarAtributos();
            
            Mensagem = CTR_Hospede.AtualizarHospede(Hospede);

            MessageBox.Show(Mensagem.TMensagem);
        }

        private void btnProsseguirCheckIn_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_CheckIn FRM_CheckIn = new FRM_CheckIn();
            FRM_CheckIn.ShowDialog();
        }

        private void maskTxbRg_Click(object sender, EventArgs e)
        {
            maskTxbRg.SelectionStart = 0;
        }

        private void maskTxbCpf_Click(object sender, EventArgs e)
        {
            maskTxbCpf.SelectionStart = 0;
        }

        private void maskTxbNasc_Click(object sender, EventArgs e)
        {
            maskTxbNasc.SelectionStart = 0;
        }

        private void txbTelefone_Click(object sender, EventArgs e)
        {
            txbTelefone.SelectionStart = 0;
        }

        private void masktxbPesquisaID_Click(object sender, EventArgs e)
        {
            masktxbPesquisaID.SelectionStart = 0;
        }

        public void SetarTextbox()
        {
            txbNome.Text = Hospede.NomePessoa;
            txbEmail.Text = Hospede.EmailPessoa;
            txbEndereco.Text = Hospede.EnderecoPessoa;
            txbTelefone.Text = (Hospede.TelefonePessoa);
            masktxbPesquisaID.Text = Convert.ToString(Hospede.IDPessoa);
            maskTxbRg.Text = Convert.ToString(Hospede.IDPessoa);
            maskTxbNasc.Text = Convert.ToString(Hospede.NascimentoPessoa);
            txbNacionalidade.Text = Hospede.Nacionalidade;
            txbCity.Text = Hospede.Cidade;
            maskTxbCpf.Text = Convert.ToString(Hospede.CPFPessoa);
        }

        public void SetarAtributos()
        {
            Hospede.NomePessoa = txbNome.Text;
            Hospede.EmailPessoa = txbEmail.Text;
            Hospede.EnderecoPessoa = txbEndereco.Text;
            Hospede.TelefonePessoa = txbTelefone.Text;
            Hospede.IDPessoa = maskTxbRg.Text;
            Hospede.NascimentoPessoa = Convert.ToDateTime(maskTxbNasc.Text);
            Hospede.Nacionalidade = txbNacionalidade.Text;
            Hospede.CPFPessoa = Convert.ToDouble(maskTxbCpf.Text);
            Hospede.Cidade = txbCity.Text;
        }
    }
}
