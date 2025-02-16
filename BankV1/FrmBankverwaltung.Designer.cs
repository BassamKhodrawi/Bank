namespace BankV1
{
    partial class FrmBankverwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxKonten = new System.Windows.Forms.ListBox();
            this.lblKontonummer = new System.Windows.Forms.Label();
            this.tbxKontoNr = new System.Windows.Forms.TextBox();
            this.lblInhaber = new System.Windows.Forms.Label();
            this.tbxInhaber = new System.Windows.Forms.TextBox();
            this.lblKontostand = new System.Windows.Forms.Label();
            this.tbxKontostand = new System.Windows.Forms.TextBox();
            this.btnEinzahlen = new System.Windows.Forms.Button();
            this.btnAuszahlen = new System.Windows.Forms.Button();
            this.btnNeuesKonto = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btnKontoLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxKonten
            // 
            this.lbxKonten.FormattingEnabled = true;
            this.lbxKonten.ItemHeight = 20;
            this.lbxKonten.Location = new System.Drawing.Point(7, 8);
            this.lbxKonten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxKonten.Name = "lbxKonten";
            this.lbxKonten.Size = new System.Drawing.Size(203, 144);
            this.lbxKonten.TabIndex = 0;
            this.lbxKonten.SelectedIndexChanged += new System.EventHandler(this.lbxKonten_SelectedIndexChanged);
            // 
            // lblKontonummer
            // 
            this.lblKontonummer.AutoSize = true;
            this.lblKontonummer.Location = new System.Drawing.Point(221, 10);
            this.lblKontonummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKontonummer.Name = "lblKontonummer";
            this.lblKontonummer.Size = new System.Drawing.Size(76, 20);
            this.lblKontonummer.TabIndex = 2;
            this.lblKontonummer.Text = "Konto-Nr:";
            // 
            // tbxKontoNr
            // 
            this.tbxKontoNr.Enabled = false;
            this.tbxKontoNr.Location = new System.Drawing.Point(315, 8);
            this.tbxKontoNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxKontoNr.Name = "tbxKontoNr";
            this.tbxKontoNr.Size = new System.Drawing.Size(114, 26);
            this.tbxKontoNr.TabIndex = 3;
            this.tbxKontoNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInhaber
            // 
            this.lblInhaber.AutoSize = true;
            this.lblInhaber.Location = new System.Drawing.Point(221, 43);
            this.lblInhaber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInhaber.Name = "lblInhaber";
            this.lblInhaber.Size = new System.Drawing.Size(72, 20);
            this.lblInhaber.TabIndex = 2;
            this.lblInhaber.Text = "Inhaber: ";
            // 
            // tbxInhaber
            // 
            this.tbxInhaber.Enabled = false;
            this.tbxInhaber.Location = new System.Drawing.Point(315, 41);
            this.tbxInhaber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxInhaber.Name = "tbxInhaber";
            this.tbxInhaber.Size = new System.Drawing.Size(114, 26);
            this.tbxInhaber.TabIndex = 3;
            // 
            // lblKontostand
            // 
            this.lblKontostand.AutoSize = true;
            this.lblKontostand.Location = new System.Drawing.Point(220, 78);
            this.lblKontostand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKontostand.Name = "lblKontostand";
            this.lblKontostand.Size = new System.Drawing.Size(95, 20);
            this.lblKontostand.TabIndex = 2;
            this.lblKontostand.Text = "Kontostand:";
            // 
            // tbxKontostand
            // 
            this.tbxKontostand.Enabled = false;
            this.tbxKontostand.Location = new System.Drawing.Point(314, 76);
            this.tbxKontostand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxKontostand.Name = "tbxKontostand";
            this.tbxKontostand.Size = new System.Drawing.Size(100, 26);
            this.tbxKontostand.TabIndex = 3;
            this.tbxKontostand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEinzahlen
            // 
            this.btnEinzahlen.Location = new System.Drawing.Point(315, 119);
            this.btnEinzahlen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEinzahlen.Name = "btnEinzahlen";
            this.btnEinzahlen.Size = new System.Drawing.Size(54, 32);
            this.btnEinzahlen.TabIndex = 1;
            this.btnEinzahlen.Text = "Einz.";
            this.btnEinzahlen.UseVisualStyleBackColor = true;
            this.btnEinzahlen.Click += new System.EventHandler(this.btnEinzahlen_Click);
            // 
            // btnAuszahlen
            // 
            this.btnAuszahlen.Location = new System.Drawing.Point(374, 119);
            this.btnAuszahlen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAuszahlen.Name = "btnAuszahlen";
            this.btnAuszahlen.Size = new System.Drawing.Size(54, 32);
            this.btnAuszahlen.TabIndex = 2;
            this.btnAuszahlen.Text = "Ausz.";
            this.btnAuszahlen.UseVisualStyleBackColor = true;
            this.btnAuszahlen.Click += new System.EventHandler(this.btnAuszahlen_Click);
            // 
            // btnNeuesKonto
            // 
            this.btnNeuesKonto.Location = new System.Drawing.Point(7, 155);
            this.btnNeuesKonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNeuesKonto.Name = "btnNeuesKonto";
            this.btnNeuesKonto.Size = new System.Drawing.Size(76, 35);
            this.btnNeuesKonto.TabIndex = 3;
            this.btnNeuesKonto.Text = "+";
            this.btnNeuesKonto.UseVisualStyleBackColor = true;
            this.btnNeuesKonto.Click += new System.EventHandler(this.btnNeuesKonto_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(416, 78);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(18, 20);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "€";
            // 
            // btnKontoLoeschen
            // 
            this.btnKontoLoeschen.Location = new System.Drawing.Point(132, 155);
            this.btnKontoLoeschen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKontoLoeschen.Name = "btnKontoLoeschen";
            this.btnKontoLoeschen.Size = new System.Drawing.Size(76, 35);
            this.btnKontoLoeschen.TabIndex = 4;
            this.btnKontoLoeschen.Text = "-";
            this.btnKontoLoeschen.UseVisualStyleBackColor = true;
            this.btnKontoLoeschen.Click += new System.EventHandler(this.btnKontoLoeschen_Click);
            // 
            // FrmBankverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 221);
            this.Controls.Add(this.btnKontoLoeschen);
            this.Controls.Add(this.btnNeuesKonto);
            this.Controls.Add(this.btnAuszahlen);
            this.Controls.Add(this.btnEinzahlen);
            this.Controls.Add(this.tbxKontostand);
            this.Controls.Add(this.tbxInhaber);
            this.Controls.Add(this.tbxKontoNr);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblKontostand);
            this.Controls.Add(this.lblInhaber);
            this.Controls.Add(this.lblKontonummer);
            this.Controls.Add(this.lbxKonten);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBankverwaltung";
            this.Text = "Bankverwaltung V1";
            this.Load += new System.EventHandler(this.FrmBankverwaltung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKonten;
        private System.Windows.Forms.Label lblKontonummer;
        private System.Windows.Forms.TextBox tbxKontoNr;
        private System.Windows.Forms.Label lblInhaber;
        private System.Windows.Forms.TextBox tbxInhaber;
        private System.Windows.Forms.Label lblKontostand;
        private System.Windows.Forms.TextBox tbxKontostand;
        private System.Windows.Forms.Button btnEinzahlen;
        private System.Windows.Forms.Button btnAuszahlen;
        private System.Windows.Forms.Button btnNeuesKonto;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnKontoLoeschen;
    }
}