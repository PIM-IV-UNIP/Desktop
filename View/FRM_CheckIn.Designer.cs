
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
            "2"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Deluxe",
            "2 - 4"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Família",
            "2 - 4"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Standard",
            "2"}, -1);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAddMaisHosp = new System.Windows.Forms.Button();
            this.maskTxbRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMaisHospedes = new System.Windows.Forms.Label();
            this.lviewSubTotal = new System.Windows.Forms.ListView();
            this.colunaSubTotalQuartos = new System.Windows.Forms.ColumnHeader();
            this.colunaSubTotalHospedes = new System.Windows.Forms.ColumnHeader();
            this.colunaSubTotalValor = new System.Windows.Forms.ColumnHeader();
            this.btnEscolherQuartos = new System.Windows.Forms.Button();
            this.radBtnStand = new System.Windows.Forms.RadioButton();
            this.radBtnFam = new System.Windows.Forms.RadioButton();
            this.radBtnDelux = new System.Windows.Forms.RadioButton();
            this.radBtnDeuses = new System.Windows.Forms.RadioButton();
            this.lviewQuartos = new System.Windows.Forms.ListView();
            this.colunaQuartos = new System.Windows.Forms.ColumnHeader();
            this.colunaMaxPessoas = new System.Windows.Forms.ColumnHeader();
            this.dgvMapaQuartos = new System.Windows.Forms.DataGridView();
            this.btnFinalizarCheckIn = new System.Windows.Forms.Button();
            this.btnCarregarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 521);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 36);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Location = new System.Drawing.Point(959, 104);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // btnAddMaisHosp
            // 
            this.btnAddMaisHosp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMaisHosp.Enabled = false;
            this.btnAddMaisHosp.Location = new System.Drawing.Point(960, 235);
            this.btnAddMaisHosp.Name = "btnAddMaisHosp";
            this.btnAddMaisHosp.Size = new System.Drawing.Size(96, 29);
            this.btnAddMaisHosp.TabIndex = 20;
            this.btnAddMaisHosp.Text = "Adicionar";
            this.btnAddMaisHosp.UseVisualStyleBackColor = true;
            this.btnAddMaisHosp.Visible = false;
            this.btnAddMaisHosp.Click += new System.EventHandler(this.btnAddMaisHosp_Click);
            // 
            // maskTxbRg
            // 
            this.maskTxbRg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxbRg.Enabled = false;
            this.maskTxbRg.Location = new System.Drawing.Point(753, 106);
            this.maskTxbRg.Mask = "00,000,000-0";
            this.maskTxbRg.Name = "maskTxbRg";
            this.maskTxbRg.Size = new System.Drawing.Size(200, 27);
            this.maskTxbRg.TabIndex = 15;
            this.maskTxbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskTxbRg.Visible = false;
            this.maskTxbRg.Click += new System.EventHandler(this.maskTxbRg_Click);
            // 
            // lblRG
            // 
            this.lblRG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRG.Location = new System.Drawing.Point(581, 106);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(163, 25);
            this.lblRG.TabIndex = 18;
            this.lblRG.Text = "Documento de ID:";
            this.lblRG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRG.Visible = false;
            // 
            // txbNome
            // 
            this.txbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNome.Enabled = false;
            this.txbNome.Location = new System.Drawing.Point(753, 139);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(200, 27);
            this.txbNome.TabIndex = 11;
            this.txbNome.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(677, 141);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 25);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNome.Visible = false;
            // 
            // lblMaisHospedes
            // 
            this.lblMaisHospedes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaisHospedes.AutoSize = true;
            this.lblMaisHospedes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaisHospedes.Location = new System.Drawing.Point(556, 27);
            this.lblMaisHospedes.Name = "lblMaisHospedes";
            this.lblMaisHospedes.Size = new System.Drawing.Size(198, 23);
            this.lblMaisHospedes.TabIndex = 0;
            this.lblMaisHospedes.Text = "Cadastre mais hóspedes:";
            this.lblMaisHospedes.Visible = false;
            // 
            // lviewSubTotal
            // 
            this.lviewSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lviewSubTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaSubTotalQuartos,
            this.colunaSubTotalHospedes,
            this.colunaSubTotalValor});
            this.lviewSubTotal.Enabled = false;
            this.lviewSubTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lviewSubTotal.GridLines = true;
            this.lviewSubTotal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lviewSubTotal.HideSelection = false;
            this.lviewSubTotal.Location = new System.Drawing.Point(550, 334);
            this.lviewSubTotal.Name = "lviewSubTotal";
            this.lviewSubTotal.Size = new System.Drawing.Size(504, 88);
            this.lviewSubTotal.TabIndex = 4;
            this.lviewSubTotal.UseCompatibleStateImageBehavior = false;
            this.lviewSubTotal.View = System.Windows.Forms.View.Details;
            this.lviewSubTotal.Visible = false;
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
            // colunaSubTotalValor
            // 
            this.colunaSubTotalValor.Text = "Valor";
            this.colunaSubTotalValor.Width = 100;
            // 
            // btnEscolherQuartos
            // 
            this.btnEscolherQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEscolherQuartos.Enabled = false;
            this.btnEscolherQuartos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEscolherQuartos.Location = new System.Drawing.Point(59, 303);
            this.btnEscolherQuartos.Name = "btnEscolherQuartos";
            this.btnEscolherQuartos.Size = new System.Drawing.Size(153, 37);
            this.btnEscolherQuartos.TabIndex = 13;
            this.btnEscolherQuartos.Text = "Escolher quarto";
            this.btnEscolherQuartos.UseVisualStyleBackColor = true;
            this.btnEscolherQuartos.Visible = false;
            this.btnEscolherQuartos.Click += new System.EventHandler(this.btnEscolherQuartos_Click);
            // 
            // radBtnStand
            // 
            this.radBtnStand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnStand.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnStand.Location = new System.Drawing.Point(11, 203);
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
            this.radBtnFam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnFam.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnFam.Location = new System.Drawing.Point(11, 161);
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
            this.radBtnDelux.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnDelux.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDelux.Location = new System.Drawing.Point(11, 119);
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
            this.radBtnDeuses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnDeuses.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDeuses.Location = new System.Drawing.Point(11, 77);
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
            this.lviewQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lviewQuartos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaQuartos,
            this.colunaMaxPessoas});
            this.lviewQuartos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lviewQuartos.GridLines = true;
            this.lviewQuartos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lviewQuartos.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lviewQuartos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lviewQuartos.LabelWrap = false;
            this.lviewQuartos.Location = new System.Drawing.Point(59, 12);
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
            // dgvMapaQuartos
            // 
            this.dgvMapaQuartos.AllowUserToAddRows = false;
            this.dgvMapaQuartos.AllowUserToDeleteRows = false;
            this.dgvMapaQuartos.AllowUserToResizeColumns = false;
            this.dgvMapaQuartos.AllowUserToResizeRows = false;
            this.dgvMapaQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMapaQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapaQuartos.Enabled = false;
            this.dgvMapaQuartos.Location = new System.Drawing.Point(218, 260);
            this.dgvMapaQuartos.MultiSelect = false;
            this.dgvMapaQuartos.Name = "dgvMapaQuartos";
            this.dgvMapaQuartos.ReadOnly = true;
            this.dgvMapaQuartos.RowHeadersVisible = false;
            this.dgvMapaQuartos.RowHeadersWidth = 51;
            this.dgvMapaQuartos.RowTemplate.Height = 29;
            this.dgvMapaQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMapaQuartos.Size = new System.Drawing.Size(235, 276);
            this.dgvMapaQuartos.TabIndex = 24;
            this.dgvMapaQuartos.Visible = false;
            this.dgvMapaQuartos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMapaQuartos_CellClick);
            // 
            // btnFinalizarCheckIn
            // 
            this.btnFinalizarCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarCheckIn.Enabled = false;
            this.btnFinalizarCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarCheckIn.Location = new System.Drawing.Point(883, 489);
            this.btnFinalizarCheckIn.Name = "btnFinalizarCheckIn";
            this.btnFinalizarCheckIn.Size = new System.Drawing.Size(171, 58);
            this.btnFinalizarCheckIn.TabIndex = 25;
            this.btnFinalizarCheckIn.Text = "Finalizar CheckIn";
            this.btnFinalizarCheckIn.UseVisualStyleBackColor = true;
            this.btnFinalizarCheckIn.Visible = false;
            this.btnFinalizarCheckIn.Click += new System.EventHandler(this.btnFinalizarCheckIn_Click);
            // 
            // btnCarregarLista
            // 
            this.btnCarregarLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarregarLista.Enabled = false;
            this.btnCarregarLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarregarLista.Location = new System.Drawing.Point(59, 260);
            this.btnCarregarLista.Name = "btnCarregarLista";
            this.btnCarregarLista.Size = new System.Drawing.Size(153, 37);
            this.btnCarregarLista.TabIndex = 26;
            this.btnCarregarLista.Text = "Carregar Lista";
            this.btnCarregarLista.UseVisualStyleBackColor = true;
            this.btnCarregarLista.Visible = false;
            this.btnCarregarLista.Click += new System.EventHandler(this.btnCarregarLista_Click);
            // 
            // FRM_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 569);
            this.Controls.Add(this.btnCarregarLista);
            this.Controls.Add(this.btnFinalizarCheckIn);
            this.Controls.Add(this.dgvMapaQuartos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEscolherQuartos);
            this.Controls.Add(this.radBtnStand);
            this.Controls.Add(this.btnAddMaisHosp);
            this.Controls.Add(this.radBtnFam);
            this.Controls.Add(this.maskTxbRg);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lviewSubTotal);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.radBtnDelux);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblMaisHospedes);
            this.Controls.Add(this.radBtnDeuses);
            this.Controls.Add(this.lviewQuartos);
            this.Name = "FRM_CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.FRM_CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblMaisHospedes;
        private System.Windows.Forms.MaskedTextBox maskTxbRg;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAddMaisHosp;
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
        private System.Windows.Forms.DataGridView dgvMapaQuartos;
        private System.Windows.Forms.Button btnFinalizarCheckIn;
        private System.Windows.Forms.Button btnCarregarLista;
        private System.Windows.Forms.ColumnHeader colunaSubTotalValor;
    }
}