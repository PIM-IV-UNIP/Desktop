
namespace Desktop.View
{
    partial class FRM_Hospede
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txbNacionalidade = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.maskTxbNasc = new System.Windows.Forms.MaskedTextBox();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.maskTxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskTxbRg = new System.Windows.Forms.MaskedTextBox();
            this.btnProsseguirCheckIn = new System.Windows.Forms.Button();
            this.masktxbPesquisaID = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisaID = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(84, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(308, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(328, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciamento do Hóspede";
            // 
            // txbNome
            // 
            this.txbNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbNome.Location = new System.Drawing.Point(156, 111);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(200, 27);
            this.txbNome.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbEmail.Location = new System.Drawing.Point(156, 143);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(200, 27);
            this.txbEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(76, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "e-Mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbEndereco.Location = new System.Drawing.Point(156, 175);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(200, 27);
            this.txbEndereco.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(52, 175);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(95, 25);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereco:";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(60, 241);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(87, 25);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRG
            // 
            this.lblRG.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRG.Location = new System.Drawing.Point(425, 111);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(163, 25);
            this.lblRG.TabIndex = 7;
            this.lblRG.Text = "Documento de ID:";
            this.lblRG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNascimento
            // 
            this.lblNascimento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNascimento.Location = new System.Drawing.Point(402, 175);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(186, 25);
            this.lblNascimento.TabIndex = 9;
            this.lblNascimento.Text = "Data de Nascimento:";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbNacionalidade
            // 
            this.txbNacionalidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbNacionalidade.Location = new System.Drawing.Point(594, 207);
            this.txbNacionalidade.Name = "txbNacionalidade";
            this.txbNacionalidade.Size = new System.Drawing.Size(200, 27);
            this.txbNacionalidade.TabIndex = 8;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacionalidade.Location = new System.Drawing.Point(450, 207);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(138, 25);
            this.lblNacionalidade.TabIndex = 11;
            this.lblNacionalidade.Text = "Nacionalidade:";
            this.lblNacionalidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdicionar.Location = new System.Drawing.Point(568, 424);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(81, 57);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar Hóspede";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultar.Location = new System.Drawing.Point(656, 335);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(154, 39);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar Hóspede";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtualizar.Location = new System.Drawing.Point(480, 424);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 57);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar Hóspede";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcluir.Location = new System.Drawing.Point(393, 424);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 57);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir Hóspede";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // maskTxbNasc
            // 
            this.maskTxbNasc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskTxbNasc.Location = new System.Drawing.Point(594, 175);
            this.maskTxbNasc.Mask = "00/00/0000";
            this.maskTxbNasc.Name = "maskTxbNasc";
            this.maskTxbNasc.Size = new System.Drawing.Size(200, 27);
            this.maskTxbNasc.TabIndex = 7;
            this.maskTxbNasc.ValidatingType = typeof(System.DateTime);
            this.maskTxbNasc.Click += new System.EventHandler(this.maskTxbNasc_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbTelefone.Location = new System.Drawing.Point(156, 241);
            this.txbTelefone.Mask = "(00) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(200, 27);
            this.txbTelefone.TabIndex = 4;
            this.txbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txbTelefone.Click += new System.EventHandler(this.txbTelefone_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpar.Location = new System.Drawing.Point(306, 424);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 57);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(538, 143);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 25);
            this.lblCPF.TabIndex = 22;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 445);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 36);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // maskTxbCpf
            // 
            this.maskTxbCpf.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskTxbCpf.Location = new System.Drawing.Point(594, 143);
            this.maskTxbCpf.Mask = "000,000,000-00";
            this.maskTxbCpf.Name = "maskTxbCpf";
            this.maskTxbCpf.Size = new System.Drawing.Size(200, 27);
            this.maskTxbCpf.TabIndex = 6;
            this.maskTxbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskTxbCpf.Click += new System.EventHandler(this.maskTxbCpf_Click);
            // 
            // maskTxbRg
            // 
            this.maskTxbRg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maskTxbRg.Location = new System.Drawing.Point(594, 111);
            this.maskTxbRg.Mask = "00,000,000-0";
            this.maskTxbRg.Name = "maskTxbRg";
            this.maskTxbRg.Size = new System.Drawing.Size(200, 27);
            this.maskTxbRg.TabIndex = 5;
            this.maskTxbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskTxbRg.Click += new System.EventHandler(this.maskTxbRg_Click);
            // 
            // btnProsseguirCheckIn
            // 
            this.btnProsseguirCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProsseguirCheckIn.Location = new System.Drawing.Point(766, 424);
            this.btnProsseguirCheckIn.Name = "btnProsseguirCheckIn";
            this.btnProsseguirCheckIn.Size = new System.Drawing.Size(127, 57);
            this.btnProsseguirCheckIn.TabIndex = 16;
            this.btnProsseguirCheckIn.Text = "Prosseguir para o Check In";
            this.btnProsseguirCheckIn.UseVisualStyleBackColor = true;
            this.btnProsseguirCheckIn.Click += new System.EventHandler(this.btnProsseguirCheckIn_Click);
            // 
            // masktxbPesquisaID
            // 
            this.masktxbPesquisaID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.masktxbPesquisaID.Location = new System.Drawing.Point(450, 339);
            this.masktxbPesquisaID.Mask = "00,000,000-0";
            this.masktxbPesquisaID.Name = "masktxbPesquisaID";
            this.masktxbPesquisaID.Size = new System.Drawing.Size(200, 27);
            this.masktxbPesquisaID.TabIndex = 23;
            this.masktxbPesquisaID.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.masktxbPesquisaID.Click += new System.EventHandler(this.masktxbPesquisaID_Click);
            // 
            // lblPesquisaID
            // 
            this.lblPesquisaID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPesquisaID.AutoSize = true;
            this.lblPesquisaID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisaID.Location = new System.Drawing.Point(60, 340);
            this.lblPesquisaID.Name = "lblPesquisaID";
            this.lblPesquisaID.Size = new System.Drawing.Size(388, 25);
            this.lblPesquisaID.TabIndex = 24;
            this.lblPesquisaID.Text = "Pesquisa de Hóspede pelo Documento de ID:";
            this.lblPesquisaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbCity
            // 
            this.txbCity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbCity.Location = new System.Drawing.Point(156, 208);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(200, 27);
            this.txbCity.TabIndex = 25;
            // 
            // txbCidade
            // 
            this.txbCidade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbCidade.AutoSize = true;
            this.txbCidade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCidade.Location = new System.Drawing.Point(72, 210);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(75, 25);
            this.txbCidade.TabIndex = 26;
            this.txbCidade.Text = "Cidade:";
            this.txbCidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FRM_Hospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 493);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.masktxbPesquisaID);
            this.Controls.Add(this.lblPesquisaID);
            this.Controls.Add(this.btnProsseguirCheckIn);
            this.Controls.Add(this.maskTxbRg);
            this.Controls.Add(this.maskTxbCpf);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.maskTxbNasc);
            this.Controls.Add(this.txbNacionalidade);
            this.Controls.Add(this.lblNacionalidade);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FRM_Hospede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento do Hóspede";
            this.Load += new System.EventHandler(this.Frm_Hospede_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox txbNacionalidade;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox maskTxbNasc;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MaskedTextBox maskTxbCpf;
        private System.Windows.Forms.MaskedTextBox maskTxbRg;
        private System.Windows.Forms.Button btnProsseguirCheckIn;
        private System.Windows.Forms.MaskedTextBox masktxbPesquisaID;
        private System.Windows.Forms.Label lblPesquisaID;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Label txbCidade;
    }
}