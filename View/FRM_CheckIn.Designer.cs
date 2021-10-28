﻿
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
            "Quarto Standard",
            "2",
            "Praia"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelMaisHospedes = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxSelectQuarto = new System.Windows.Forms.ComboBox();
            this.btnAddMaisHosp = new System.Windows.Forms.Button();
            this.maskTxbRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMaisHospedes = new System.Windows.Forms.Label();
            this.lviewSubTotal = new System.Windows.Forms.ListView();
            this.colunaSubTotalQuartos = new System.Windows.Forms.ColumnHeader();
            this.colunaSubTotalHospedes = new System.Windows.Forms.ColumnHeader();
            this.btnTeste = new System.Windows.Forms.Button();
            this.panelQuartos = new System.Windows.Forms.Panel();
            this.btnEscolherQuartos = new System.Windows.Forms.Button();
            this.radBtnStand = new System.Windows.Forms.RadioButton();
            this.radBtnFam = new System.Windows.Forms.RadioButton();
            this.radBtnDelux = new System.Windows.Forms.RadioButton();
            this.radBtnDeuses = new System.Windows.Forms.RadioButton();
            this.lviewQuartos = new System.Windows.Forms.ListView();
            this.colunaQuartos = new System.Windows.Forms.ColumnHeader();
            this.colunaMaxPessoas = new System.Windows.Forms.ColumnHeader();
            this.panelMaisHospedes.SuspendLayout();
            this.panelQuartos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 489);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 36);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelMaisHospedes
            // 
            this.panelMaisHospedes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMaisHospedes.Controls.Add(this.btnPesquisar);
            this.panelMaisHospedes.Controls.Add(this.label1);
            this.panelMaisHospedes.Controls.Add(this.cBoxSelectQuarto);
            this.panelMaisHospedes.Controls.Add(this.btnAddMaisHosp);
            this.panelMaisHospedes.Controls.Add(this.maskTxbRg);
            this.panelMaisHospedes.Controls.Add(this.lblRG);
            this.panelMaisHospedes.Controls.Add(this.txbNome);
            this.panelMaisHospedes.Controls.Add(this.lblNome);
            this.panelMaisHospedes.Controls.Add(this.lblMaisHospedes);
            this.panelMaisHospedes.Location = new System.Drawing.Point(545, 12);
            this.panelMaisHospedes.Name = "panelMaisHospedes";
            this.panelMaisHospedes.Size = new System.Drawing.Size(519, 297);
            this.panelMaisHospedes.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(408, 62);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Selecione o quarto:";
            // 
            // cBoxSelectQuarto
            // 
            this.cBoxSelectQuarto.FormattingEnabled = true;
            this.cBoxSelectQuarto.Location = new System.Drawing.Point(202, 130);
            this.cBoxSelectQuarto.Name = "cBoxSelectQuarto";
            this.cBoxSelectQuarto.Size = new System.Drawing.Size(200, 28);
            this.cBoxSelectQuarto.TabIndex = 21;
            // 
            // btnAddMaisHosp
            // 
            this.btnAddMaisHosp.Location = new System.Drawing.Point(408, 259);
            this.btnAddMaisHosp.Name = "btnAddMaisHosp";
            this.btnAddMaisHosp.Size = new System.Drawing.Size(94, 29);
            this.btnAddMaisHosp.TabIndex = 20;
            this.btnAddMaisHosp.Text = "Adicionar";
            this.btnAddMaisHosp.UseVisualStyleBackColor = true;
            this.btnAddMaisHosp.Click += new System.EventHandler(this.btnAddMaisHosp_Click);
            // 
            // maskTxbRg
            // 
            this.maskTxbRg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskTxbRg.Location = new System.Drawing.Point(202, 64);
            this.maskTxbRg.Mask = "00,000,000-0";
            this.maskTxbRg.Name = "maskTxbRg";
            this.maskTxbRg.Size = new System.Drawing.Size(200, 27);
            this.maskTxbRg.TabIndex = 15;
            this.maskTxbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblRG
            // 
            this.lblRG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRG.Location = new System.Drawing.Point(30, 64);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(163, 25);
            this.lblRG.TabIndex = 18;
            this.lblRG.Text = "Documento de ID:";
            this.lblRG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbNome
            // 
            this.txbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNome.Location = new System.Drawing.Point(202, 97);
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
            this.lblNome.Location = new System.Drawing.Point(126, 99);
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
            this.lblMaisHospedes.Location = new System.Drawing.Point(4, 10);
            this.lblMaisHospedes.Name = "lblMaisHospedes";
            this.lblMaisHospedes.Size = new System.Drawing.Size(198, 23);
            this.lblMaisHospedes.TabIndex = 0;
            this.lblMaisHospedes.Text = "Cadastre mais hóspedes:";
            // 
            // lviewSubTotal
            // 
            this.lviewSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lviewSubTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaSubTotalQuartos,
            this.colunaSubTotalHospedes});
            this.lviewSubTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lviewSubTotal.GridLines = true;
            this.lviewSubTotal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lviewSubTotal.HideSelection = false;
            this.lviewSubTotal.Location = new System.Drawing.Point(12, 326);
            this.lviewSubTotal.Name = "lviewSubTotal";
            this.lviewSubTotal.Size = new System.Drawing.Size(504, 157);
            this.lviewSubTotal.TabIndex = 4;
            this.lviewSubTotal.UseCompatibleStateImageBehavior = false;
            this.lviewSubTotal.View = System.Windows.Forms.View.Details;
            this.lviewSubTotal.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lviewSubTotal_ItemSelectionChanged);
            // 
            // colunaSubTotalQuartos
            // 
            this.colunaSubTotalQuartos.Text = "Quartos";
            this.colunaSubTotalQuartos.Width = 100;
            // 
            // colunaSubTotalHospedes
            // 
            this.colunaSubTotalHospedes.Text = "Hospedes";
            this.colunaSubTotalHospedes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaSubTotalHospedes.Width = 300;
            // 
            // btnTeste
            // 
            this.btnTeste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeste.Location = new System.Drawing.Point(953, 496);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(94, 29);
            this.btnTeste.TabIndex = 3;
            this.btnTeste.Text = "teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // panelQuartos
            // 
            this.panelQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuartos.Controls.Add(this.btnEscolherQuartos);
            this.panelQuartos.Controls.Add(this.radBtnStand);
            this.panelQuartos.Controls.Add(this.radBtnFam);
            this.panelQuartos.Controls.Add(this.radBtnDelux);
            this.panelQuartos.Controls.Add(this.radBtnDeuses);
            this.panelQuartos.Controls.Add(this.lviewQuartos);
            this.panelQuartos.Location = new System.Drawing.Point(12, 12);
            this.panelQuartos.Name = "panelQuartos";
            this.panelQuartos.Size = new System.Drawing.Size(524, 295);
            this.panelQuartos.TabIndex = 1;
            // 
            // btnEscolherQuartos
            // 
            this.btnEscolherQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEscolherQuartos.Enabled = false;
            this.btnEscolherQuartos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEscolherQuartos.Location = new System.Drawing.Point(361, 251);
            this.btnEscolherQuartos.Name = "btnEscolherQuartos";
            this.btnEscolherQuartos.Size = new System.Drawing.Size(153, 37);
            this.btnEscolherQuartos.TabIndex = 13;
            this.btnEscolherQuartos.Text = "Escolher quartos";
            this.btnEscolherQuartos.UseVisualStyleBackColor = true;
            this.btnEscolherQuartos.Click += new System.EventHandler(this.btnEscolherQuartos_Click);
            // 
            // radBtnStand
            // 
            this.radBtnStand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radBtnStand.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnStand.Location = new System.Drawing.Point(9, 194);
            this.radBtnStand.Name = "radBtnStand";
            this.radBtnStand.Size = new System.Drawing.Size(42, 31);
            this.radBtnStand.TabIndex = 12;
            this.radBtnStand.TabStop = true;
            this.radBtnStand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnStand.UseVisualStyleBackColor = true;
            this.radBtnStand.CheckedChanged += new System.EventHandler(this.radBtnStand_CheckedChanged);
            // 
            // radBtnFam
            // 
            this.radBtnFam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radBtnFam.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnFam.Location = new System.Drawing.Point(9, 152);
            this.radBtnFam.Name = "radBtnFam";
            this.radBtnFam.Size = new System.Drawing.Size(42, 31);
            this.radBtnFam.TabIndex = 11;
            this.radBtnFam.TabStop = true;
            this.radBtnFam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnFam.UseVisualStyleBackColor = true;
            this.radBtnFam.CheckedChanged += new System.EventHandler(this.radBtnFam_CheckedChanged);
            // 
            // radBtnDelux
            // 
            this.radBtnDelux.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radBtnDelux.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDelux.Location = new System.Drawing.Point(9, 110);
            this.radBtnDelux.Name = "radBtnDelux";
            this.radBtnDelux.Size = new System.Drawing.Size(42, 31);
            this.radBtnDelux.TabIndex = 9;
            this.radBtnDelux.TabStop = true;
            this.radBtnDelux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDelux.UseVisualStyleBackColor = true;
            this.radBtnDelux.CheckedChanged += new System.EventHandler(this.radBtnDelux_CheckedChanged);
            // 
            // radBtnDeuses
            // 
            this.radBtnDeuses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radBtnDeuses.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDeuses.Location = new System.Drawing.Point(9, 68);
            this.radBtnDeuses.Name = "radBtnDeuses";
            this.radBtnDeuses.Size = new System.Drawing.Size(42, 31);
            this.radBtnDeuses.TabIndex = 8;
            this.radBtnDeuses.TabStop = true;
            this.radBtnDeuses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDeuses.UseVisualStyleBackColor = true;
            this.radBtnDeuses.CheckedChanged += new System.EventHandler(this.radBtnDeuses_CheckedChanged);
            // 
            // lviewQuartos
            // 
            this.lviewQuartos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lviewQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lviewQuartos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaQuartos,
            this.colunaMaxPessoas});
            this.lviewQuartos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.lviewQuartos.LabelWrap = false;
            this.lviewQuartos.Location = new System.Drawing.Point(61, 3);
            this.lviewQuartos.MultiSelect = false;
            this.lviewQuartos.Name = "lviewQuartos";
            this.lviewQuartos.Size = new System.Drawing.Size(394, 242);
            this.lviewQuartos.TabIndex = 0;
            this.lviewQuartos.TileSize = new System.Drawing.Size(268, 120);
            this.lviewQuartos.UseCompatibleStateImageBehavior = false;
            this.lviewQuartos.View = System.Windows.Forms.View.Details;
            this.lviewQuartos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lviewQuartos_ItemSelectionChanged);
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
            // FRM_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 537);
            this.Controls.Add(this.panelMaisHospedes);
            this.Controls.Add(this.panelQuartos);
            this.Controls.Add(this.lviewSubTotal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnTeste);
            this.Name = "FRM_CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.FRM_CheckIn_Load);
            this.panelMaisHospedes.ResumeLayout(false);
            this.panelMaisHospedes.PerformLayout();
            this.panelQuartos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelMaisHospedes;
        private System.Windows.Forms.Label lblMaisHospedes;
        private System.Windows.Forms.MaskedTextBox maskTxbRg;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAddMaisHosp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxSelectQuarto;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Panel panelQuartos;
        private System.Windows.Forms.RadioButton radBtnFam;
        private System.Windows.Forms.RadioButton radBtnDelux;
        private System.Windows.Forms.RadioButton radBtnDeuses;
        private System.Windows.Forms.ListView lviewQuartos;
        private System.Windows.Forms.ColumnHeader colunaQuartos;
        private System.Windows.Forms.ColumnHeader colunaMaxPessoas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListView lviewSubTotal;
        private System.Windows.Forms.ColumnHeader colunaSubTotalQuartos;
        private System.Windows.Forms.ColumnHeader colunaSubTotalHospedes;
        private System.Windows.Forms.Button btnEscolherQuartos;
        private System.Windows.Forms.RadioButton radBtnStand;
    }
}