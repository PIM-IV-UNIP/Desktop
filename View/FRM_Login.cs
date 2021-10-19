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
    public partial class FRM_Login : Form
    {

        public FRM_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //fazer if-else para verificação no BD;
            FRM_Inicio Inicio = new FRM_Inicio(); //Instância da do form Inicio
            Hide(); //Esconde a tela do Login
            Inicio.ShowDialog(); //Exibe a tela de Início
            Show(); //Mostra a tela de Login novamente após o usuário clicar no botão sair
            
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
