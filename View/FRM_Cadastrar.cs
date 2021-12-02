using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Desktop.Model;
using Desktop.Controller;
using System.Data.SqlClient;

namespace Desktop.View
{
    public partial class FRM_Cadastrar : Form
    {
        Cadastrar Cadastrar;
        Mensagem Mensagem;
        CTR_Cadastrar CTR_Cadastrar;

        public FRM_Cadastrar()
        {
            InitializeComponent();
            Cadastrar = new Cadastrar();
            Mensagem = new Mensagem();
            CTR_Cadastrar = new CTR_Cadastrar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Atribuindo os valores dos TextBox para os devidos atributos
            Cadastrar.User = txbUser.Text;
            Cadastrar.Senha = txbSenha.Text;

            //Verificaão se o campo está vazio
            if (!txbUser.Text.Equals(string.Empty) & !txbSenha.Text.Equals(string.Empty))
            {
                Mensagem = CTR_Cadastrar.CadastrarLogin(Cadastrar);

                //Verificação do sucesso da operação
                if (Mensagem.VerificaReturnFuncao.Equals(true))
                {
                    MessageBox.Show(Mensagem.TMensagem, "Sucesso", MessageBoxButtons.OK);

                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show(Mensagem.TMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Por favor preencha os dois campos");
                
        }

        private void FRM_Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
