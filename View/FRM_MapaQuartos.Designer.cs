
namespace Desktop.View
{
    partial class FRM_MapaQuartos
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
            this.dgvMapaQuartos = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMapaQuartos
            // 
            this.dgvMapaQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMapaQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapaQuartos.Location = new System.Drawing.Point(323, 12);
            this.dgvMapaQuartos.Name = "dgvMapaQuartos";
            this.dgvMapaQuartos.RowHeadersWidth = 51;
            this.dgvMapaQuartos.RowTemplate.Height = 29;
            this.dgvMapaQuartos.Size = new System.Drawing.Size(584, 536);
            this.dgvMapaQuartos.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 519);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 29);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FRM_MapaQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 560);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvMapaQuartos);
            this.Name = "FRM_MapaQuartos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_MapaQuartos";
            this.Load += new System.EventHandler(this.FRM_MapaQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaQuartos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMapaQuartos;
        private System.Windows.Forms.Button btnVoltar;
    }
}