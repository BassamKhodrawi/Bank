namespace BankV1
{
    partial class FrmNeuesKonto
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
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblKontoNr = new System.Windows.Forms.Label();
            this.tbxKontoNr = new System.Windows.Forms.TextBox();
            this.lblInhaber = new System.Windows.Forms.Label();
            this.tbxInhaber = new System.Windows.Forms.TextBox();
            this.lblStartbetrag = new System.Windows.Forms.Label();
            this.tbxBetrag = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.rbtnGirokonto = new System.Windows.Forms.RadioButton();
            this.rbtnSparkonto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Location = new System.Drawing.Point(4, 75);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(1);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(74, 26);
            this.btnAbbrechen.TabIndex = 0;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // btnOkay
            // 
            this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkay.Location = new System.Drawing.Point(92, 75);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(1);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(74, 26);
            this.btnOkay.TabIndex = 2;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            // 
            // lblKontoNr
            // 
            this.lblKontoNr.AutoSize = true;
            this.lblKontoNr.Location = new System.Drawing.Point(5, 5);
            this.lblKontoNr.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKontoNr.Name = "lblKontoNr";
            this.lblKontoNr.Size = new System.Drawing.Size(55, 13);
            this.lblKontoNr.TabIndex = 1;
            this.lblKontoNr.Text = "Konto-Nr: ";
            // 
            // tbxKontoNr
            // 
            this.tbxKontoNr.Enabled = false;
            this.tbxKontoNr.Location = new System.Drawing.Point(64, 3);
            this.tbxKontoNr.Margin = new System.Windows.Forms.Padding(1);
            this.tbxKontoNr.Name = "tbxKontoNr";
            this.tbxKontoNr.Size = new System.Drawing.Size(103, 20);
            this.tbxKontoNr.TabIndex = 2;
            this.tbxKontoNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInhaber
            // 
            this.lblInhaber.AutoSize = true;
            this.lblInhaber.Location = new System.Drawing.Point(7, 27);
            this.lblInhaber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblInhaber.Name = "lblInhaber";
            this.lblInhaber.Size = new System.Drawing.Size(46, 13);
            this.lblInhaber.TabIndex = 3;
            this.lblInhaber.Text = "Inhaber:";
            // 
            // tbxInhaber
            // 
            this.tbxInhaber.Location = new System.Drawing.Point(64, 26);
            this.tbxInhaber.Margin = new System.Windows.Forms.Padding(1);
            this.tbxInhaber.Name = "tbxInhaber";
            this.tbxInhaber.Size = new System.Drawing.Size(103, 20);
            this.tbxInhaber.TabIndex = 1;
            // 
            // lblStartbetrag
            // 
            this.lblStartbetrag.AutoSize = true;
            this.lblStartbetrag.Location = new System.Drawing.Point(7, 47);
            this.lblStartbetrag.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStartbetrag.Name = "lblStartbetrag";
            this.lblStartbetrag.Size = new System.Drawing.Size(65, 13);
            this.lblStartbetrag.TabIndex = 4;
            this.lblStartbetrag.Text = "Startbetrag: ";
            // 
            // tbxBetrag
            // 
            this.tbxBetrag.Location = new System.Drawing.Point(64, 47);
            this.tbxBetrag.Margin = new System.Windows.Forms.Padding(1);
            this.tbxBetrag.Name = "tbxBetrag";
            this.tbxBetrag.Size = new System.Drawing.Size(93, 20);
            this.tbxBetrag.TabIndex = 3;
            this.tbxBetrag.Text = "0,00";
            this.tbxBetrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(157, 48);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 4;
            this.lblEuro.Text = "€";
            // 
            // rbtnGirokonto
            // 
            this.rbtnGirokonto.AutoSize = true;
            this.rbtnGirokonto.Location = new System.Drawing.Point(219, 31);
            this.rbtnGirokonto.Name = "rbtnGirokonto";
            this.rbtnGirokonto.Size = new System.Drawing.Size(71, 17);
            this.rbtnGirokonto.TabIndex = 5;
            this.rbtnGirokonto.TabStop = true;
            this.rbtnGirokonto.Text = "Girokonto";
            this.rbtnGirokonto.UseVisualStyleBackColor = true;
            // 
            // rbtnSparkonto
            // 
            this.rbtnSparkonto.AutoSize = true;
            this.rbtnSparkonto.Location = new System.Drawing.Point(219, 54);
            this.rbtnSparkonto.Name = "rbtnSparkonto";
            this.rbtnSparkonto.Size = new System.Drawing.Size(74, 17);
            this.rbtnSparkonto.TabIndex = 6;
            this.rbtnSparkonto.TabStop = true;
            this.rbtnSparkonto.Text = "Sparkonto";
            this.rbtnSparkonto.UseVisualStyleBackColor = true;
            // 
            // FrmNeuesKonto
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbrechen;
            this.ClientSize = new System.Drawing.Size(309, 125);
            this.Controls.Add(this.rbtnSparkonto);
            this.Controls.Add(this.rbtnGirokonto);
            this.Controls.Add(this.tbxBetrag);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblStartbetrag);
            this.Controls.Add(this.lblInhaber);
            this.Controls.Add(this.tbxInhaber);
            this.Controls.Add(this.tbxKontoNr);
            this.Controls.Add(this.lblKontoNr);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnAbbrechen);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmNeuesKonto";
            this.Text = "NeuesKonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label lblKontoNr;
        private System.Windows.Forms.TextBox tbxKontoNr;
        private System.Windows.Forms.Label lblInhaber;
        private System.Windows.Forms.TextBox tbxInhaber;
        private System.Windows.Forms.Label lblStartbetrag;
        private System.Windows.Forms.TextBox tbxBetrag;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.RadioButton rbtnGirokonto;
        private System.Windows.Forms.RadioButton rbtnSparkonto;
    }
}