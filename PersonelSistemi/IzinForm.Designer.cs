namespace PersonelSistemi
{
    partial class IzinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIzinPersonelId = new System.Windows.Forms.TextBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.btnIzinKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEÇİLİ PERSONEL ID:";
            // 
            // txtIzinPersonelId
            // 
            this.txtIzinPersonelId.Location = new System.Drawing.Point(218, 33);
            this.txtIzinPersonelId.Name = "txtIzinPersonelId";
            this.txtIzinPersonelId.ReadOnly = true;
            this.txtIzinPersonelId.Size = new System.Drawing.Size(224, 22);
            this.txtIzinPersonelId.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(218, 66);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(224, 22);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(218, 99);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(224, 22);
            this.dtpBitis.TabIndex = 3;
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Items.AddRange(new object[] {
            "Yıllık İzin",
            "Sağlık İzni",
            "Mazeret İzni"});
            this.cmbIzinTuru.Location = new System.Drawing.Point(218, 134);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(224, 24);
            this.cmbIzinTuru.TabIndex = 4;
            // 
            // btnIzinKaydet
            // 
            this.btnIzinKaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzinKaydet.Location = new System.Drawing.Point(278, 174);
            this.btnIzinKaydet.Name = "btnIzinKaydet";
            this.btnIzinKaydet.Size = new System.Drawing.Size(84, 23);
            this.btnIzinKaydet.TabIndex = 5;
            this.btnIzinKaydet.Text = "İZİN AL";
            this.btnIzinKaydet.UseVisualStyleBackColor = false;
            this.btnIzinKaydet.Click += new System.EventHandler(this.btnIzinKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "İZİN BAŞLANGIÇ TARİHİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "İZİN BİTİŞ TARİHİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "İZİN TÜRÜ:";
            // 
            // IzinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzinKaydet);
            this.Controls.Add(this.cmbIzinTuru);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.txtIzinPersonelId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "IzinForm";
            this.Text = "İZİN TALEP FORMU";
            this.Load += new System.EventHandler(this.IzinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Button btnIzinKaydet;
        public System.Windows.Forms.TextBox txtIzinPersonelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}