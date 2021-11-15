
namespace Desktop.View
{
    partial class FRM_GerenciarQuartos
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblGerenciar = new System.Windows.Forms.Label();
            this.cmbTiposQuartos = new System.Windows.Forms.ComboBox();
            this.lblTipoQuarto = new System.Windows.Forms.Label();
            this.lblNumeroQuarto = new System.Windows.Forms.Label();
            this.txbNumeroQuarto = new System.Windows.Forms.TextBox();
            this.btnAlterarQuarto = new System.Windows.Forms.Button();
            this.dgvListaHospedes = new System.Windows.Forms.DataGridView();
            this.btnCarregarLista = new System.Windows.Forms.Button();
            this.btnAddQuarto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 533);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(103, 51);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblGerenciar
            // 
            this.lblGerenciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGerenciar.AutoSize = true;
            this.lblGerenciar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGerenciar.Location = new System.Drawing.Point(423, 9);
            this.lblGerenciar.Name = "lblGerenciar";
            this.lblGerenciar.Size = new System.Drawing.Size(349, 37);
            this.lblGerenciar.TabIndex = 17;
            this.lblGerenciar.Text = "Gerenciamento dos Quartos";
            this.lblGerenciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTiposQuartos
            // 
            this.cmbTiposQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTiposQuartos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposQuartos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTiposQuartos.FormattingEnabled = true;
            this.cmbTiposQuartos.Items.AddRange(new object[] {
            "Quarto Quádruplo",
            "Quarto Triplo",
            "Quarto Duplo",
            "Quarto Individual"});
            this.cmbTiposQuartos.Location = new System.Drawing.Point(278, 163);
            this.cmbTiposQuartos.Name = "cmbTiposQuartos";
            this.cmbTiposQuartos.Size = new System.Drawing.Size(235, 31);
            this.cmbTiposQuartos.TabIndex = 1;
            // 
            // lblTipoQuarto
            // 
            this.lblTipoQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoQuarto.AutoSize = true;
            this.lblTipoQuarto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoQuarto.Location = new System.Drawing.Point(55, 166);
            this.lblTipoQuarto.Name = "lblTipoQuarto";
            this.lblTipoQuarto.Size = new System.Drawing.Size(217, 23);
            this.lblTipoQuarto.TabIndex = 100;
            this.lblTipoQuarto.Text = "Selecione o tipo do quarto:";
            // 
            // lblNumeroQuarto
            // 
            this.lblNumeroQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroQuarto.AutoSize = true;
            this.lblNumeroQuarto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroQuarto.Location = new System.Drawing.Point(52, 235);
            this.lblNumeroQuarto.Name = "lblNumeroQuarto";
            this.lblNumeroQuarto.Size = new System.Drawing.Size(220, 23);
            this.lblNumeroQuarto.TabIndex = 101;
            this.lblNumeroQuarto.Text = "Digite o número do quarto:";
            // 
            // txbNumeroQuarto
            // 
            this.txbNumeroQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNumeroQuarto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumeroQuarto.Location = new System.Drawing.Point(278, 232);
            this.txbNumeroQuarto.Name = "txbNumeroQuarto";
            this.txbNumeroQuarto.Size = new System.Drawing.Size(235, 30);
            this.txbNumeroQuarto.TabIndex = 2;
            // 
            // btnAlterarQuarto
            // 
            this.btnAlterarQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarQuarto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarQuarto.Location = new System.Drawing.Point(372, 399);
            this.btnAlterarQuarto.Name = "btnAlterarQuarto";
            this.btnAlterarQuarto.Size = new System.Drawing.Size(189, 66);
            this.btnAlterarQuarto.TabIndex = 3;
            this.btnAlterarQuarto.Text = "Alterar Tipo do Quarto";
            this.btnAlterarQuarto.UseVisualStyleBackColor = true;
            this.btnAlterarQuarto.Click += new System.EventHandler(this.btnAlterarQuarto_Click);
            // 
            // dgvListaHospedes
            // 
            this.dgvListaHospedes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListaHospedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaHospedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaHospedes.Location = new System.Drawing.Point(567, 74);
            this.dgvListaHospedes.MultiSelect = false;
            this.dgvListaHospedes.Name = "dgvListaHospedes";
            this.dgvListaHospedes.ReadOnly = true;
            this.dgvListaHospedes.RowHeadersVisible = false;
            this.dgvListaHospedes.RowHeadersWidth = 51;
            this.dgvListaHospedes.RowTemplate.Height = 29;
            this.dgvListaHospedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListaHospedes.Size = new System.Drawing.Size(612, 453);
            this.dgvListaHospedes.TabIndex = 104;
            this.dgvListaHospedes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaHospedes_CellClick);
            // 
            // btnCarregarLista
            // 
            this.btnCarregarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarLista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarregarLista.Location = new System.Drawing.Point(1035, 533);
            this.btnCarregarLista.Name = "btnCarregarLista";
            this.btnCarregarLista.Size = new System.Drawing.Size(145, 51);
            this.btnCarregarLista.TabIndex = 5;
            this.btnCarregarLista.Text = "Carregar Lista";
            this.btnCarregarLista.UseVisualStyleBackColor = true;
            this.btnCarregarLista.Click += new System.EventHandler(this.btnCarregarLista_Click);
            // 
            // btnAddQuarto
            // 
            this.btnAddQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddQuarto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddQuarto.Location = new System.Drawing.Point(372, 471);
            this.btnAddQuarto.Name = "btnAddQuarto";
            this.btnAddQuarto.Size = new System.Drawing.Size(189, 56);
            this.btnAddQuarto.TabIndex = 4;
            this.btnAddQuarto.Text = "Adicionar Quarto";
            this.btnAddQuarto.UseVisualStyleBackColor = true;
            this.btnAddQuarto.Click += new System.EventHandler(this.btnAddQuarto_Click);
            // 
            // FRM_GerenciarQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 596);
            this.Controls.Add(this.btnAddQuarto);
            this.Controls.Add(this.btnCarregarLista);
            this.Controls.Add(this.dgvListaHospedes);
            this.Controls.Add(this.btnAlterarQuarto);
            this.Controls.Add(this.txbNumeroQuarto);
            this.Controls.Add(this.lblNumeroQuarto);
            this.Controls.Add(this.lblTipoQuarto);
            this.Controls.Add(this.cmbTiposQuartos);
            this.Controls.Add(this.lblGerenciar);
            this.Controls.Add(this.btnVoltar);
            this.Name = "FRM_GerenciarQuartos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Quartos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblGerenciar;
        private System.Windows.Forms.ComboBox cmbTiposQuartos;
        private System.Windows.Forms.Label lblTipoQuarto;
        private System.Windows.Forms.Label lblNumeroQuarto;
        private System.Windows.Forms.TextBox txbNumeroQuarto;
        private System.Windows.Forms.Button btnAlterarQuarto;
        private System.Windows.Forms.DataGridView dgvListaHospedes;
        private System.Windows.Forms.Button btnCarregarLista;
        private System.Windows.Forms.Button btnAddQuarto;
    }
}