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
        private bool Verifica;
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
            if(VerificarTextbox().Equals(true))
            {
                MessageBox.Show("Por favor verifique os campos vazios.", "Erro: Campos Incoretos", MessageBoxButtons.OK);
            }
            else
            {
                SetarAtributos();

                Mensagem = CTR_Hospede.AdicionarHospede(Hospede);

                MessageBox.Show(Mensagem.TMensagem);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (masktxbPesquisaID.Text.Equals(string.Empty))
            {
                MessageBox.Show("Campo de pesquisa vazio.", "Erro: Campo Vazio", MessageBoxButtons.OK);
            }
            else
            {
                Hospede.IDPessoa = masktxbPesquisaID.Text;

                Mensagem = CTR_Hospede.ConsultarHospede(Hospede);
                SetarTextbox();

                MessageBox.Show(Mensagem.TMensagem);
                btnExcluir.Visible = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Hospede.Limpar();

            SetarTextbox();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (masktxbPesquisaID.Text.Equals(string.Empty))
            {
                MessageBox.Show("Consulte o hóspede primeiro", "Erro: Campo Vazio", MessageBoxButtons.OK);
            }
            else
            {
                Hospede.IDPessoa = masktxbPesquisaID.Text;

                Mensagem = CTR_Hospede.ExcluirHospede(Hospede);
                Hospede.Limpar();
                SetarTextbox();

                MessageBox.Show(Mensagem.TMensagem);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarTextbox().Equals(true))
            {
                MessageBox.Show("Por favor verifique os campos vazios.", "Erro: Campos Incoretos", MessageBoxButtons.OK);
            }
            else
            {
                SetarAtributos();

                Mensagem = CTR_Hospede.AtualizarHospede(Hospede);

                MessageBox.Show(Mensagem.TMensagem);
            }
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

        private void SetarTextbox()
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

        private void SetarAtributos()
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

        private bool VerificarTextbox()
        {
            Verifica = (txbNome.Text.Equals(string.Empty) || txbEmail.Text.Equals(string.Empty) || txbEndereco.Text.Equals(string.Empty) || txbCity.Text.Equals(string.Empty) || txbTelefone.Text.Equals(string.Empty) || maskTxbRg.Text.Equals(string.Empty) || maskTxbCpf.Text.Equals(string.Empty) || maskTxbNasc.Text.Equals(string.Empty) || txbNacionalidade.Text.Equals(string.Empty)).Equals(true);
            return Verifica;
        }

        private void txbNome_Validating(object sender, CancelEventArgs e)
        {
            if (txbNome.Text.Equals(string.Empty))
                IdentificadorErro.SetError(txbNome, "Por favor, digite o nome do cliente");
            else
                IdentificadorErro.SetError(txbNome, "");
        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txbEmail.Text.Equals(string.Empty))
                IdentificadorErro.SetError(txbEmail, "Por favor digite o e-Mail do cliente");
            else
                IdentificadorErro.SetError(txbEmail, "");
        }

        private void txbEndereco_Validating(object sender, CancelEventArgs e)
        {
            if (txbEndereco.Text.Equals(string.Empty))
                IdentificadorErro.SetError(txbEndereco, "Por favor digite o endereço do cliente");
            else
                IdentificadorErro.SetError(txbEndereco, "");
        }

        private void txbCity_Validating(object sender, CancelEventArgs e)
        {
            if (txbCity.Text.Equals(string.Empty))
                IdentificadorErro.SetError(txbCity, "Por favor digite a cidade do cliente");
            else
                IdentificadorErro.SetError(txbCity, "");
        }

        private void txbTelefone_Validating(object sender, CancelEventArgs e)
        {
            if (txbTelefone.Text.Equals(string.Empty))
                IdentificadorErro.SetError(txbTelefone, "Por favor digite o telefone do cliente");
            else
                IdentificadorErro.SetError(txbTelefone, "");
        }

        private void maskTxbRg_Validating(object sender, CancelEventArgs e)
        {
            if (maskTxbRg.Text.Equals(string.Empty))
                IdentificadorErro.SetError(maskTxbRg, "Por favor digite o Documento de Identificação do cliente");
            else
                IdentificadorErro.SetError(maskTxbRg, "");
        }

        private void maskTxbCpf_Validating(object sender, CancelEventArgs e)
        {
            if (maskTxbCpf.Text.Equals(string.Empty))
                IdentificadorErro.SetError(maskTxbCpf, "Por favor digite o CPF do cliente");
            else
                IdentificadorErro.SetError(maskTxbCpf, "");
        }

        private void maskTxbNasc_Validating(object sender, CancelEventArgs e)
        {
            if (maskTxbNasc.Text.Equals("  /  /"))
                IdentificadorErro.SetError(maskTxbNasc, "Por favor digite a data de nascimento do cliente");
            else
                IdentificadorErro.SetError(maskTxbNasc, "");
        }

        private void txbNacionalidade_Validating(object sender, CancelEventArgs e)
        {
            if (txbNacionalidade.Text.Equals(string.Empty))
                IdentificadorErro.SetError(txbNacionalidade, "Por favor digite a nacionalidade do cliente");
            else
                IdentificadorErro.SetError(txbNacionalidade, "");
        }
    }
}
