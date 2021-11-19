
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
            "Quarto Quádruplo",
            "4"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Triplo",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Duplo",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarto Individual",
            "1"}, -1);
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
            this.colunaSubTotalEstadia = new System.Windows.Forms.ColumnHeader();
            this.colunaSubTotalValor = new System.Windows.Forms.ColumnHeader();
            this.btnEscolherQuartos = new System.Windows.Forms.Button();
            this.radBtnIndividual = new System.Windows.Forms.RadioButton();
            this.radBtnDuplo = new System.Windows.Forms.RadioButton();
            this.radBtnTriplo = new System.Windows.Forms.RadioButton();
            this.radBtnQuadruplo = new System.Windows.Forms.RadioButton();
            this.lviewQuartos = new System.Windows.Forms.ListView();
            this.colunaQuartos = new System.Windows.Forms.ColumnHeader();
            this.colunaMaxPessoas = new System.Windows.Forms.ColumnHeader();
            this.dgvMapaQuartos = new System.Windows.Forms.DataGridView();
            this.btnFinalizarCheckIn = new System.Windows.Forms.Button();
            this.btnCarregarLista = new System.Windows.Forms.Button();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmarData = new System.Windows.Forms.Button();
            this.lblPeriodo = new System.Windows.Forms.Label();
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
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Location = new System.Drawing.Point(961, 30);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // btnAddMaisHosp
            // 
            this.btnAddMaisHosp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMaisHosp.Location = new System.Drawing.Point(959, 98);
            this.btnAddMaisHosp.Name = "btnAddMaisHosp";
            this.btnAddMaisHosp.Size = new System.Drawing.Size(96, 29);
            this.btnAddMaisHosp.TabIndex = 10;
            this.btnAddMaisHosp.Text = "Adicionar";
            this.btnAddMaisHosp.UseVisualStyleBackColor = true;
            this.btnAddMaisHosp.Visible = false;
            this.btnAddMaisHosp.Click += new System.EventHandler(this.btnAddMaisHosp_Click);
            // 
            // maskTxbRg
            // 
            this.maskTxbRg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskTxbRg.Location = new System.Drawing.Point(755, 32);
            this.maskTxbRg.Mask = "00,000,000-0";
            this.maskTxbRg.Name = "maskTxbRg";
            this.maskTxbRg.Size = new System.Drawing.Size(200, 27);
            this.maskTxbRg.TabIndex = 7;
            this.maskTxbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskTxbRg.Visible = false;
            this.maskTxbRg.Click += new System.EventHandler(this.maskTxbRg_Click);
            // 
            // lblRG
            // 
            this.lblRG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRG.Location = new System.Drawing.Point(583, 32);
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
            this.txbNome.Location = new System.Drawing.Point(755, 65);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(200, 27);
            this.txbNome.TabIndex = 9;
            this.txbNome.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(679, 67);
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
            this.lblMaisHospedes.Location = new System.Drawing.Point(693, 101);
            this.lblMaisHospedes.Name = "lblMaisHospedes";
            this.lblMaisHospedes.Size = new System.Drawing.Size(260, 23);
            this.lblMaisHospedes.TabIndex = 0;
            this.lblMaisHospedes.Text = "Cadastre hóspedes neste quarto:";
            this.lblMaisHospedes.Visible = false;
            // 
            // lviewSubTotal
            // 
            this.lviewSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lviewSubTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaSubTotalQuartos,
            this.colunaSubTotalHospedes,
            this.colunaSubTotalEstadia,
            this.colunaSubTotalValor});
            this.lviewSubTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lviewSubTotal.GridLines = true;
            this.lviewSubTotal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lviewSubTotal.HideSelection = false;
            this.lviewSubTotal.Location = new System.Drawing.Point(459, 383);
            this.lviewSubTotal.Name = "lviewSubTotal";
            this.lviewSubTotal.Size = new System.Drawing.Size(619, 88);
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
            // colunaSubTotalEstadia
            // 
            this.colunaSubTotalEstadia.Text = "Estadia";
            this.colunaSubTotalEstadia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaSubTotalEstadia.Width = 90;
            // 
            // colunaSubTotalValor
            // 
            this.colunaSubTotalValor.Text = "Valor";
            this.colunaSubTotalValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaSubTotalValor.Width = 120;
            // 
            // btnEscolherQuartos
            // 
            this.btnEscolherQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEscolherQuartos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEscolherQuartos.Location = new System.Drawing.Point(118, 303);
            this.btnEscolherQuartos.Name = "btnEscolherQuartos";
            this.btnEscolherQuartos.Size = new System.Drawing.Size(153, 37);
            this.btnEscolherQuartos.TabIndex = 6;
            this.btnEscolherQuartos.Text = "Escolher quarto";
            this.btnEscolherQuartos.UseVisualStyleBackColor = true;
            this.btnEscolherQuartos.Visible = false;
            this.btnEscolherQuartos.Click += new System.EventHandler(this.btnEscolherQuartos_Click);
            // 
            // radBtnIndividual
            // 
            this.radBtnIndividual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnIndividual.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnIndividual.Location = new System.Drawing.Point(11, 203);
            this.radBtnIndividual.Name = "radBtnIndividual";
            this.radBtnIndividual.Size = new System.Drawing.Size(42, 31);
            this.radBtnIndividual.TabIndex = 4;
            this.radBtnIndividual.TabStop = true;
            this.radBtnIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnIndividual.UseVisualStyleBackColor = true;
            this.radBtnIndividual.CheckedChanged += new System.EventHandler(this.radBtnStand_CheckedChanged);
            // 
            // radBtnDuplo
            // 
            this.radBtnDuplo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnDuplo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDuplo.Location = new System.Drawing.Point(11, 161);
            this.radBtnDuplo.Name = "radBtnDuplo";
            this.radBtnDuplo.Size = new System.Drawing.Size(42, 31);
            this.radBtnDuplo.TabIndex = 3;
            this.radBtnDuplo.TabStop = true;
            this.radBtnDuplo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDuplo.UseVisualStyleBackColor = true;
            this.radBtnDuplo.CheckedChanged += new System.EventHandler(this.radBtnFam_CheckedChanged);
            // 
            // radBtnTriplo
            // 
            this.radBtnTriplo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnTriplo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnTriplo.Location = new System.Drawing.Point(11, 119);
            this.radBtnTriplo.Name = "radBtnTriplo";
            this.radBtnTriplo.Size = new System.Drawing.Size(42, 31);
            this.radBtnTriplo.TabIndex = 2;
            this.radBtnTriplo.TabStop = true;
            this.radBtnTriplo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnTriplo.UseVisualStyleBackColor = true;
            this.radBtnTriplo.CheckedChanged += new System.EventHandler(this.radBtnDelux_CheckedChanged);
            // 
            // radBtnQuadruplo
            // 
            this.radBtnQuadruplo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnQuadruplo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnQuadruplo.Location = new System.Drawing.Point(11, 77);
            this.radBtnQuadruplo.Name = "radBtnQuadruplo";
            this.radBtnQuadruplo.Size = new System.Drawing.Size(42, 31);
            this.radBtnQuadruplo.TabIndex = 1;
            this.radBtnQuadruplo.TabStop = true;
            this.radBtnQuadruplo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnQuadruplo.UseVisualStyleBackColor = true;
            this.radBtnQuadruplo.CheckedChanged += new System.EventHandler(this.radBtnDeuses_CheckedChanged);
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
            listViewItem1.StateImageIndex = 0;
            this.lviewQuartos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lviewQuartos.LabelWrap = false;
            this.lviewQuartos.Location = new System.Drawing.Point(59, 12);
            this.lviewQuartos.MinimumSize = new System.Drawing.Size(417, 242);
            this.lviewQuartos.MultiSelect = false;
            this.lviewQuartos.Name = "lviewQuartos";
            this.lviewQuartos.Size = new System.Drawing.Size(417, 242);
            this.lviewQuartos.TabIndex = 0;
            this.lviewQuartos.TileSize = new System.Drawing.Size(120, 120);
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
            this.dgvMapaQuartos.ColumnHeadersVisible = false;
            this.dgvMapaQuartos.Location = new System.Drawing.Point(288, 260);
            this.dgvMapaQuartos.MultiSelect = false;
            this.dgvMapaQuartos.Name = "dgvMapaQuartos";
            this.dgvMapaQuartos.ReadOnly = true;
            this.dgvMapaQuartos.RowHeadersVisible = false;
            this.dgvMapaQuartos.RowHeadersWidth = 51;
            this.dgvMapaQuartos.RowTemplate.Height = 29;
            this.dgvMapaQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMapaQuartos.Size = new System.Drawing.Size(165, 276);
            this.dgvMapaQuartos.TabIndex = 24;
            this.dgvMapaQuartos.Visible = false;
            this.dgvMapaQuartos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMapaQuartos_CellClick);
            // 
            // btnFinalizarCheckIn
            // 
            this.btnFinalizarCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarCheckIn.Location = new System.Drawing.Point(907, 499);
            this.btnFinalizarCheckIn.Name = "btnFinalizarCheckIn";
            this.btnFinalizarCheckIn.Size = new System.Drawing.Size(171, 58);
            this.btnFinalizarCheckIn.TabIndex = 14;
            this.btnFinalizarCheckIn.Text = "Finalizar CheckIn";
            this.btnFinalizarCheckIn.UseVisualStyleBackColor = true;
            this.btnFinalizarCheckIn.Visible = false;
            this.btnFinalizarCheckIn.Click += new System.EventHandler(this.btnFinalizarCheckIn_Click);
            // 
            // btnCarregarLista
            // 
            this.btnCarregarLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarregarLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarregarLista.Location = new System.Drawing.Point(118, 260);
            this.btnCarregarLista.Name = "btnCarregarLista";
            this.btnCarregarLista.Size = new System.Drawing.Size(153, 37);
            this.btnCarregarLista.TabIndex = 5;
            this.btnCarregarLista.Text = "Carregar Lista";
            this.btnCarregarLista.UseVisualStyleBackColor = true;
            this.btnCarregarLista.Visible = false;
            this.btnCarregarLista.Click += new System.EventHandler(this.btnCarregarLista_Click);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeInicio.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeInicio.Location = new System.Drawing.Point(720, 221);
            this.dateTimeInicio.MinDate = new System.DateTime(2021, 11, 19, 0, 0, 0, 0);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(335, 30);
            this.dateTimeInicio.TabIndex = 11;
            this.dateTimeInicio.Visible = false;
            // 
            // lblDe
            // 
            this.lblDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDe.Location = new System.Drawing.Point(675, 225);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(39, 25);
            this.lblDe.TabIndex = 28;
            this.lblDe.Text = "De:";
            this.lblDe.Visible = false;
            // 
            // lblAte
            // 
            this.lblAte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAte.Location = new System.Drawing.Point(670, 284);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(44, 25);
            this.lblAte.TabIndex = 30;
            this.lblAte.Text = "Até:";
            this.lblAte.Visible = false;
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeFinal.Location = new System.Drawing.Point(720, 280);
            this.dateTimeFinal.MinDate = new System.DateTime(2021, 11, 19, 0, 0, 0, 0);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(335, 30);
            this.dateTimeFinal.TabIndex = 12;
            this.dateTimeFinal.Visible = false;
            // 
            // btnConfirmarData
            // 
            this.btnConfirmarData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmarData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarData.Location = new System.Drawing.Point(998, 327);
            this.btnConfirmarData.Name = "btnConfirmarData";
            this.btnConfirmarData.Size = new System.Drawing.Size(57, 34);
            this.btnConfirmarData.TabIndex = 13;
            this.btnConfirmarData.Text = "Ok";
            this.btnConfirmarData.UseVisualStyleBackColor = true;
            this.btnConfirmarData.Visible = false;
            this.btnConfirmarData.Click += new System.EventHandler(this.btnConfirmarData_Click);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeriodo.Location = new System.Drawing.Point(594, 200);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(77, 25);
            this.lblPeriodo.TabIndex = 32;
            this.lblPeriodo.Text = "Período";
            this.lblPeriodo.Visible = false;
            // 
            // FRM_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 569);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.btnConfirmarData);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.btnCarregarLista);
            this.Controls.Add(this.btnFinalizarCheckIn);
            this.Controls.Add(this.dgvMapaQuartos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEscolherQuartos);
            this.Controls.Add(this.radBtnIndividual);
            this.Controls.Add(this.btnAddMaisHosp);
            this.Controls.Add(this.radBtnDuplo);
            this.Controls.Add(this.maskTxbRg);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lviewSubTotal);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.radBtnTriplo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblMaisHospedes);
            this.Controls.Add(this.radBtnQuadruplo);
            this.Controls.Add(this.lviewQuartos);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.RadioButton radBtnDuplo;
        private System.Windows.Forms.RadioButton radBtnTriplo;
        private System.Windows.Forms.RadioButton radBtnQuadruplo;
        private System.Windows.Forms.ListView lviewQuartos;
        private System.Windows.Forms.ColumnHeader colunaQuartos;
        private System.Windows.Forms.ColumnHeader colunaMaxPessoas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListView lviewSubTotal;
        private System.Windows.Forms.ColumnHeader colunaSubTotalQuartos;
        private System.Windows.Forms.ColumnHeader colunaSubTotalHospedes;
        private System.Windows.Forms.Button btnEscolherQuartos;
        private System.Windows.Forms.RadioButton radBtnIndividual;
        private System.Windows.Forms.DataGridView dgvMapaQuartos;
        private System.Windows.Forms.Button btnFinalizarCheckIn;
        private System.Windows.Forms.Button btnCarregarLista;
        private System.Windows.Forms.ColumnHeader colunaSubTotalEstadia;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.Button btnConfirmarData;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ColumnHeader colunaSubTotalValor;
    }
}