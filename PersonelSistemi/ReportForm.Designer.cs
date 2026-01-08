namespace PersonelSistemi
{
    partial class ReportForm
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
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnRaporuGetir = new System.Windows.Forms.Button();
            this.dgvRaporSonuclari = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporSonuclari)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.FormattingEnabled = true;
            this.cmbRaporTuru.Items.AddRange(new object[] {
            "Maaş Özeti",
            "İzin Hakediş",
            "Performans Analizi",
            "Departman Dağılımı"});
            this.cmbRaporTuru.Location = new System.Drawing.Point(624, 87);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(224, 24);
            this.cmbRaporTuru.TabIndex = 0;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(624, 131);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(224, 22);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(624, 169);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(224, 22);
            this.dtpBitis.TabIndex = 2;
            // 
            // btnRaporuGetir
            // 
            this.btnRaporuGetir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRaporuGetir.Location = new System.Drawing.Point(670, 210);
            this.btnRaporuGetir.Name = "btnRaporuGetir";
            this.btnRaporuGetir.Size = new System.Drawing.Size(112, 53);
            this.btnRaporuGetir.TabIndex = 3;
            this.btnRaporuGetir.Text = "RAPOR GETİR";
            this.btnRaporuGetir.UseVisualStyleBackColor = false;
            this.btnRaporuGetir.Click += new System.EventHandler(this.btnRaporuGetir_Click);
            // 
            // dgvRaporSonuclari
            // 
            this.dgvRaporSonuclari.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRaporSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporSonuclari.Location = new System.Drawing.Point(34, 30);
            this.dgvRaporSonuclari.Name = "dgvRaporSonuclari";
            this.dgvRaporSonuclari.RowHeadersWidth = 51;
            this.dgvRaporSonuclari.RowTemplate.Height = 24;
            this.dgvRaporSonuclari.Size = new System.Drawing.Size(419, 364);
            this.dgvRaporSonuclari.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "RAPOR TÜRÜ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAŞLANGIÇ TARİHİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "BİTİŞ TARİHİ:";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRaporSonuclari);
            this.Controls.Add(this.btnRaporuGetir);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.cmbRaporTuru);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ReportForm";
            this.Text = "YÖNETİM VE RAPORLAMA PANELİ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporSonuclari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRaporTuru;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Button btnRaporuGetir;
        private System.Windows.Forms.DataGridView dgvRaporSonuclari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}