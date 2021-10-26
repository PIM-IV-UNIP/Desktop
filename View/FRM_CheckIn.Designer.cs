
namespace Desktop.View
{
    partial class FRM_CheckIn
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Suite dos Deuses",
            "2",
            "Vista dos Deuses"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Deluxe",
            "8",
            "Praia"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Família",
            "5",
            "Praia"}, "(nenhum)", System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Casal",
            "2",
            "Praia"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lviewQuartos = new System.Windows.Forms.ListView();
            this.colunaQuartos = new System.Windows.Forms.ColumnHeader();
            this.colunaMaxPessoas = new System.Windows.Forms.ColumnHeader();
            this.panelMaisHospedes = new System.Windows.Forms.Panel();
            this.btnAddMaisHosp = new System.Windows.Forms.Button();
            this.maskTxbRg = new System.Windows.Forms.MaskedTextBox();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskTxbNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMaisHospedes = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colunaFinalQuarto = new System.Windows.Forms.ColumnHeader();
            this.colunaHospedes = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMaisHospedes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 442);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 36);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 417);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lviewQuartos);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 251);
            this.panel2.TabIndex = 1;
            // 
            // lviewQuartos
            // 
            this.lviewQuartos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lviewQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lviewQuartos.CheckBoxes = true;
            this.lviewQuartos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaQuartos,
            this.colunaMaxPessoas});
            this.lviewQuartos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviewQuartos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lviewQuartos.FullRowSelect = true;
            this.lviewQuartos.GridLines = true;
            this.lviewQuartos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lviewQuartos.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.lviewQuartos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lviewQuartos.Location = new System.Drawing.Point(0, 0);
            this.lviewQuartos.Name = "lviewQuartos";
            this.lviewQuartos.Size = new System.Drawing.Size(389, 251);
            this.lviewQuartos.TabIndex = 0;
            this.lviewQuartos.TileSize = new System.Drawing.Size(268, 120);
            this.lviewQuartos.UseCompatibleStateImageBehavior = false;
            this.lviewQuartos.View = System.Windows.Forms.View.Details;
            this.lviewQuartos.SelectedIndexChanged += new System.EventHandler(this.lviewQuartos_SelectedIndexChanged);
            // 
            // colunaQuartos
            // 
            this.colunaQuartos.Text = "Quartos";
            this.colunaQuartos.Width = 260;
            // 
            // colunaMaxPessoas
            // 
            this.colunaMaxPessoas.Text = "Pessoas";
            this.colunaMaxPessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaMaxPessoas.Width = 120;
            // 
            // panelMaisHospedes
            // 
            this.panelMaisHospedes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMaisHospedes.Controls.Add(this.btnAddMaisHosp);
            this.panelMaisHospedes.Controls.Add(this.maskTxbRg);
            this.panelMaisHospedes.Controls.Add(this.txbTelefone);
            this.panelMaisHospedes.Controls.Add(this.maskTxbNasc);
            this.panelMaisHospedes.Controls.Add(this.lblNascimento);
            this.panelMaisHospedes.Controls.Add(this.lblRG);
            this.panelMaisHospedes.Controls.Add(this.lblTelefone);
            this.panelMaisHospedes.Controls.Add(this.txbEmail);
            this.panelMaisHospedes.Controls.Add(this.lblEmail);
            this.panelMaisHospedes.Controls.Add(this.txbNome);
            this.panelMaisHospedes.Controls.Add(this.lblNome);
            this.panelMaisHospedes.Controls.Add(this.lblMaisHospedes);
            this.panelMaisHospedes.Location = new System.Drawing.Point(545, 19);
            this.panelMaisHospedes.Name = "panelMaisHospedes";
            this.panelMaisHospedes.Size = new System.Drawing.Size(519, 290);
            this.panelMaisHospedes.TabIndex = 3;
            // 
            // btnAddMaisHosp
            // 
            this.btnAddMaisHosp.Location = new System.Drawing.Point(422, 258);
            this.btnAddMaisHosp.Name = "btnAddMaisHosp";
            this.btnAddMaisHosp.Size = new System.Drawing.Size(94, 29);
            this.btnAddMaisHosp.TabIndex = 20;
            this.btnAddMaisHosp.Text = "Adicionar";
            this.btnAddMaisHosp.UseVisualStyleBackColor = true;
            // 
            // maskTxbRg
            // 
            this.maskTxbRg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskTxbRg.Location = new System.Drawing.Point(202, 67);
            this.maskTxbRg.Mask = "00,000,000-0";
            this.maskTxbRg.Name = "maskTxbRg";
            this.maskTxbRg.Size = new System.Drawing.Size(200, 27);
            this.maskTxbRg.TabIndex = 15;
            this.maskTxbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTelefone.Location = new System.Drawing.Point(202, 199);
            this.txbTelefone.Mask = "+000 (000) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(200, 27);
            this.txbTelefone.TabIndex = 14;
            this.txbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskTxbNasc
            // 
            this.maskTxbNasc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskTxbNasc.Location = new System.Drawing.Point(202, 133);
            this.maskTxbNasc.Mask = "00/00/0000";
            this.maskTxbNasc.Name = "maskTxbNasc";
            this.maskTxbNasc.Size = new System.Drawing.Size(200, 27);
            this.maskTxbNasc.TabIndex = 17;
            this.maskTxbNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblNascimento
            // 
            this.lblNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNascimento.Location = new System.Drawing.Point(7, 134);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(186, 25);
            this.lblNascimento.TabIndex = 19;
            this.lblNascimento.Text = "Data de Nascimento:";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRG
            // 
            this.lblRG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRG.Location = new System.Drawing.Point(153, 69);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(40, 25);
            this.lblRG.TabIndex = 18;
            this.lblRG.Text = "RG:";
            this.lblRG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(106, 199);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(87, 25);
            this.lblTelefone.TabIndex = 16;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmail.Location = new System.Drawing.Point(202, 166);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(200, 27);
            this.txbEmail.TabIndex = 12;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(122, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "e-Mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbNome
            // 
            this.txbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNome.Location = new System.Drawing.Point(202, 100);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(200, 27);
            this.txbNome.TabIndex = 11;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(126, 102);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 25);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaisHospedes
            // 
            this.lblMaisHospedes.AutoSize = true;
            this.lblMaisHospedes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaisHospedes.Location = new System.Drawing.Point(0, 0);
            this.lblMaisHospedes.Name = "lblMaisHospedes";
            this.lblMaisHospedes.Size = new System.Drawing.Size(300, 23);
            this.lblMaisHospedes.TabIndex = 0;
            this.lblMaisHospedes.Text = "Cadastre mais hóspedes neste quarto:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(5, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 157);
            this.panel3.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaFinalQuarto,
            this.colunaHospedes});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "seila";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(516, 154);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colunaFinalQuarto
            // 
            this.colunaFinalQuarto.Text = "Quarto";
            this.colunaFinalQuarto.Width = 200;
            // 
            // colunaHospedes
            // 
            this.colunaHospedes.Text = "Hospedes";
            this.colunaHospedes.Width = 250;
            // 
            // FRM_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 490);
            this.Controls.Add(this.panelMaisHospedes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Name = "FRM_CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_CheckIn";
            this.Load += new System.EventHandler(this.FRM_CheckIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelMaisHospedes.ResumeLayout(false);
            this.panelMaisHospedes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lviewQuartos;
        private System.Windows.Forms.ColumnHeader colunaQuartos;
        private System.Windows.Forms.ColumnHeader colunaMaxPessoas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMaisHospedes;
        private System.Windows.Forms.Label lblMaisHospedes;
        private System.Windows.Forms.MaskedTextBox maskTxbRg;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.MaskedTextBox maskTxbNasc;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAddMaisHosp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colunaFinalQuarto;
        private System.Windows.Forms.ColumnHeader colunaHospedes;
    }
}