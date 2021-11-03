
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMapaQuartos = new System.Windows.Forms.DataGridView();
            this.btnSelecionarQuarto = new System.Windows.Forms.Button();
            this.txbDigiteQuarto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMapaQuartos
            // 
            this.dgvMapaQuartos.AllowUserToAddRows = false;
            this.dgvMapaQuartos.AllowUserToDeleteRows = false;
            this.dgvMapaQuartos.AllowUserToResizeColumns = false;
            this.dgvMapaQuartos.AllowUserToResizeRows = false;
            this.dgvMapaQuartos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMapaQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMapaQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapaQuartos.Location = new System.Drawing.Point(231, 12);
            this.dgvMapaQuartos.MultiSelect = false;
            this.dgvMapaQuartos.Name = "dgvMapaQuartos";
            this.dgvMapaQuartos.ReadOnly = true;
            this.dgvMapaQuartos.RowHeadersWidth = 51;
            this.dgvMapaQuartos.RowTemplate.Height = 29;
            this.dgvMapaQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMapaQuartos.Size = new System.Drawing.Size(258, 411);
            this.dgvMapaQuartos.TabIndex = 0;
            // 
            // btnSelecionarQuarto
            // 
            this.btnSelecionarQuarto.Location = new System.Drawing.Point(56, 221);
            this.btnSelecionarQuarto.Name = "btnSelecionarQuarto";
            this.btnSelecionarQuarto.Size = new System.Drawing.Size(118, 69);
            this.btnSelecionarQuarto.TabIndex = 2;
            this.btnSelecionarQuarto.Text = "Selecionar Quarto";
            this.btnSelecionarQuarto.UseVisualStyleBackColor = true;
            this.btnSelecionarQuarto.Click += new System.EventHandler(this.btnSelecionarQuartos_Click);
            // 
            // txbDigiteQuarto
            // 
            this.txbDigiteQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbDigiteQuarto.Location = new System.Drawing.Point(51, 164);
            this.txbDigiteQuarto.Name = "txbDigiteQuarto";
            this.txbDigiteQuarto.PlaceholderText = "Digite o quarto";
            this.txbDigiteQuarto.Size = new System.Drawing.Size(123, 27);
            this.txbDigiteQuarto.TabIndex = 3;
            // 
            // FRM_MapaQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 435);
            this.Controls.Add(this.txbDigiteQuarto);
            this.Controls.Add(this.btnSelecionarQuarto);
            this.Controls.Add(this.dgvMapaQuartos);
            this.Name = "FRM_MapaQuartos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione o Quarto";
            this.Load += new System.EventHandler(this.FRM_MapaQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMapaQuartos;
        private System.Windows.Forms.Button btnSelecionarQuarto;
        private System.Windows.Forms.TextBox txbDigiteQuarto;
    }
}