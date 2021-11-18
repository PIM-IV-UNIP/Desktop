
namespace Desktop.View
{
    partial class FRM_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnListaHospede = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerenciarQuartos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(360, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 57);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema Hoteleiro";
            this.lblTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.Location = new System.Drawing.Point(153, 288);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(231, 119);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.Location = new System.Drawing.Point(415, 288);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(231, 119);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnListaHospede
            // 
            this.btnListaHospede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListaHospede.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListaHospede.Location = new System.Drawing.Point(678, 288);
            this.btnListaHospede.Name = "btnListaHospede";
            this.btnListaHospede.Size = new System.Drawing.Size(231, 119);
            this.btnListaHospede.TabIndex = 5;
            this.btnListaHospede.Text = "Lista de Hóspedes";
            this.btnListaHospede.UseVisualStyleBackColor = true;
            this.btnListaHospede.Click += new System.EventHandler(this.btnListaHospede_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(459, 120);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(141, 115);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(28, 543);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 38);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerenciarQuartos
            // 
            this.btnGerenciarQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerenciarQuartos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGerenciarQuartos.Location = new System.Drawing.Point(415, 426);
            this.btnGerenciarQuartos.Name = "btnGerenciarQuartos";
            this.btnGerenciarQuartos.Size = new System.Drawing.Size(231, 119);
            this.btnGerenciarQuartos.TabIndex = 9;
            this.btnGerenciarQuartos.Text = "Gerenciar Quartos";
            this.btnGerenciarQuartos.UseVisualStyleBackColor = true;
            this.btnGerenciarQuartos.Click += new System.EventHandler(this.btnGerenciarQuartos_Click);
            // 
            // FRM_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 606);
            this.Controls.Add(this.btnGerenciarQuartos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnListaHospede);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnListaHospede;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerenciarQuartos;
    }
}