
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumeroQuarto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(12, 435);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 36);
            this.btnVoltar.TabIndex = 99;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblGerenciar
            // 
            this.lblGerenciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGerenciar.AutoSize = true;
            this.lblGerenciar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGerenciar.Location = new System.Drawing.Point(298, 9);
            this.lblGerenciar.Name = "lblGerenciar";
            this.lblGerenciar.Size = new System.Drawing.Size(349, 37);
            this.lblGerenciar.TabIndex = 17;
            this.lblGerenciar.Text = "Gerenciamento dos Quartos";
            this.lblGerenciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTiposQuartos
            // 
            this.cmbTiposQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTiposQuartos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTiposQuartos.FormattingEnabled = true;
            this.cmbTiposQuartos.Items.AddRange(new object[] {
            "Quarto Deluxe",
            "Quarto Familia",
            "Quarto Standard",
            "Suite dos Deuses"});
            this.cmbTiposQuartos.Location = new System.Drawing.Point(464, 175);
            this.cmbTiposQuartos.Name = "cmbTiposQuartos";
            this.cmbTiposQuartos.Size = new System.Drawing.Size(235, 31);
            this.cmbTiposQuartos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 100;
            this.label1.Text = "Selecione o tipo do quarto:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "Digite o número do quarto:";
            // 
            // txbNumeroQuarto
            // 
            this.txbNumeroQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNumeroQuarto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumeroQuarto.Location = new System.Drawing.Point(464, 244);
            this.txbNumeroQuarto.Name = "txbNumeroQuarto";
            this.txbNumeroQuarto.Size = new System.Drawing.Size(235, 30);
            this.txbNumeroQuarto.TabIndex = 102;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(742, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 36);
            this.button1.TabIndex = 103;
            this.button1.Text = "Adicionar Quarto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FRM_GerenciarQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbNumeroQuarto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTiposQuartos);
            this.Controls.Add(this.lblGerenciar);
            this.Controls.Add(this.btnVoltar);
            this.Name = "FRM_GerenciarQuartos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Quartos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblGerenciar;
        private System.Windows.Forms.ComboBox cmbTiposQuartos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNumeroQuarto;
        private System.Windows.Forms.Button button1;
    }
}