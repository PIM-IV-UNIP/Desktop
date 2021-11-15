﻿
namespace Desktop.View
{
    partial class FRM_CheckOut
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
            this.btnProcurarQuarto = new System.Windows.Forms.Button();
            this.txbProcurarQuarto = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lviewTotal = new System.Windows.Forms.ListView();
            this.lviewTotalQuarto = new System.Windows.Forms.ColumnHeader();
            this.lviewTotalHospedes = new System.Windows.Forms.ColumnHeader();
            this.lviewTotalEstadia = new System.Windows.Forms.ColumnHeader();
            this.lviewTotalValor = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 407);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 51);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnProcurarQuarto
            // 
            this.btnProcurarQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcurarQuarto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcurarQuarto.Location = new System.Drawing.Point(507, 8);
            this.btnProcurarQuarto.Name = "btnProcurarQuarto";
            this.btnProcurarQuarto.Size = new System.Drawing.Size(78, 38);
            this.btnProcurarQuarto.TabIndex = 18;
            this.btnProcurarQuarto.Text = "Ok";
            this.btnProcurarQuarto.UseVisualStyleBackColor = true;
            this.btnProcurarQuarto.Click += new System.EventHandler(this.btnProcurarQuarto_Click);
            // 
            // txbProcurarQuarto
            // 
            this.txbProcurarQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbProcurarQuarto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbProcurarQuarto.Location = new System.Drawing.Point(264, 12);
            this.txbProcurarQuarto.Name = "txbProcurarQuarto";
            this.txbProcurarQuarto.PlaceholderText = "Digite o número do quarto";
            this.txbProcurarQuarto.Size = new System.Drawing.Size(237, 32);
            this.txbProcurarQuarto.TabIndex = 19;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizar.Location = new System.Drawing.Point(625, 407);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(164, 51);
            this.btnFinalizar.TabIndex = 20;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lviewTotal
            // 
            this.lviewTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lviewTotalQuarto,
            this.lviewTotalHospedes,
            this.lviewTotalEstadia,
            this.lviewTotalValor});
            this.lviewTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lviewTotal.GridLines = true;
            this.lviewTotal.HideSelection = false;
            this.lviewTotal.Location = new System.Drawing.Point(146, 166);
            this.lviewTotal.Name = "lviewTotal";
            this.lviewTotal.Size = new System.Drawing.Size(515, 103);
            this.lviewTotal.TabIndex = 22;
            this.lviewTotal.UseCompatibleStateImageBehavior = false;
            this.lviewTotal.View = System.Windows.Forms.View.Details;
            // 
            // lviewTotalQuarto
            // 
            this.lviewTotalQuarto.Text = "Quarto";
            this.lviewTotalQuarto.Width = 80;
            // 
            // lviewTotalHospedes
            // 
            this.lviewTotalHospedes.Text = "Hospedes";
            this.lviewTotalHospedes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lviewTotalHospedes.Width = 240;
            // 
            // lviewTotalEstadia
            // 
            this.lviewTotalEstadia.Text = "Estadia";
            this.lviewTotalEstadia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lviewTotalEstadia.Width = 90;
            // 
            // lviewTotalValor
            // 
            this.lviewTotalValor.Text = "Valor";
            this.lviewTotalValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lviewTotalValor.Width = 100;
            // 
            // FRM_CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 470);
            this.Controls.Add(this.lviewTotal);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txbProcurarQuarto);
            this.Controls.Add(this.btnProcurarQuarto);
            this.Controls.Add(this.btnVoltar);
            this.Name = "FRM_CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_CheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnProcurarQuarto;
        private System.Windows.Forms.TextBox txbProcurarQuarto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ListView lviewTotal;
        private System.Windows.Forms.ColumnHeader lviewTotalQuarto;
        private System.Windows.Forms.ColumnHeader lviewTotalHospedes;
        private System.Windows.Forms.ColumnHeader lviewTotalEstadia;
        private System.Windows.Forms.ColumnHeader lviewTotalValor;
    }
}