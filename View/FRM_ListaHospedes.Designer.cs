﻿
namespace Desktop.View
{
    partial class FRM_ListaHospedes
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
            this.dgvListaHospedes = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbPesquise = new System.Windows.Forms.TextBox();
            this.btnPesquise = new System.Windows.Forms.Button();
            this.lblPesquise = new System.Windows.Forms.Label();
            this.btnCarregarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaHospedes
            // 
            this.dgvListaHospedes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaHospedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaHospedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaHospedes.Location = new System.Drawing.Point(191, 56);
            this.dgvListaHospedes.Name = "dgvListaHospedes";
            this.dgvListaHospedes.ReadOnly = true;
            this.dgvListaHospedes.RowHeadersWidth = 51;
            this.dgvListaHospedes.RowTemplate.Height = 29;
            this.dgvListaHospedes.Size = new System.Drawing.Size(1094, 531);
            this.dgvListaHospedes.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 551);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 36);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbPesquise
            // 
            this.txbPesquise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesquise.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPesquise.Location = new System.Drawing.Point(816, 12);
            this.txbPesquise.Name = "txbPesquise";
            this.txbPesquise.PlaceholderText = "Digite o documento de ID";
            this.txbPesquise.Size = new System.Drawing.Size(274, 32);
            this.txbPesquise.TabIndex = 1;
            // 
            // btnPesquise
            // 
            this.btnPesquise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquise.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPesquise.Location = new System.Drawing.Point(1121, 12);
            this.btnPesquise.Name = "btnPesquise";
            this.btnPesquise.Size = new System.Drawing.Size(107, 32);
            this.btnPesquise.TabIndex = 2;
            this.btnPesquise.Text = "Pesquisar";
            this.btnPesquise.UseVisualStyleBackColor = true;
            this.btnPesquise.Click += new System.EventHandler(this.btnPesquise_Click);
            // 
            // lblPesquise
            // 
            this.lblPesquise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesquise.AutoSize = true;
            this.lblPesquise.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesquise.Location = new System.Drawing.Point(597, 16);
            this.lblPesquise.Name = "lblPesquise";
            this.lblPesquise.Size = new System.Drawing.Size(207, 25);
            this.lblPesquise.TabIndex = 5;
            this.lblPesquise.Text = "Pesquisar um Hóspede:";
            // 
            // btnCarregarLista
            // 
            this.btnCarregarLista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarregarLista.Location = new System.Drawing.Point(12, 16);
            this.btnCarregarLista.Name = "btnCarregarLista";
            this.btnCarregarLista.Size = new System.Drawing.Size(145, 67);
            this.btnCarregarLista.TabIndex = 6;
            this.btnCarregarLista.Text = "Carregar Lista";
            this.btnCarregarLista.UseVisualStyleBackColor = true;
            this.btnCarregarLista.Click += new System.EventHandler(this.btnCarregarLista_Click);
            // 
            // FRM_ListaHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 599);
            this.Controls.Add(this.btnCarregarLista);
            this.Controls.Add(this.lblPesquise);
            this.Controls.Add(this.btnPesquise);
            this.Controls.Add(this.txbPesquise);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvListaHospedes);
            this.Name = "FRM_ListaHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ListaHospedes";
            this.Load += new System.EventHandler(this.FRM_ListaHospedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaHospedes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbPesquise;
        private System.Windows.Forms.Button btnPesquise;
        private System.Windows.Forms.Label lblPesquise;
        private System.Windows.Forms.Button btnCarregarLista;
    }
}