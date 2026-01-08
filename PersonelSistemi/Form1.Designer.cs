namespace PersonelSistemi
{
    partial class Form1
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
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.numMaas = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIzinGit = new System.Windows.Forms.Button();
            this.btnIzinOnaylama = new System.Windows.Forms.Button();
            this.btnPerformans = new System.Windows.Forms.Button();
            this.cmbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMaasForm = new System.Windows.Forms.Button();
            this.btnDepForm = new System.Windows.Forms.Button();
            this.lblSeciliId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.RowHeadersWidth = 51;
            this.dgvPersonel.RowTemplate.Height = 24;
            this.dgvPersonel.Size = new System.Drawing.Size(339, 289);
            this.dgvPersonel.TabIndex = 0;
            this.dgvPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnListele.Location = new System.Drawing.Point(140, 307);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(84, 44);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Personel Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(501, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(134, 22);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(501, 51);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(134, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(501, 80);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(134, 22);
            this.txtTc.TabIndex = 4;
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(501, 109);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(134, 22);
            this.txtGorev.TabIndex = 5;
            // 
            // numMaas
            // 
            this.numMaas.DecimalPlaces = 2;
            this.numMaas.Location = new System.Drawing.Point(501, 168);
            this.numMaas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMaas.Name = "numMaas";
            this.numMaas.Size = new System.Drawing.Size(135, 22);
            this.numMaas.TabIndex = 6;
            this.numMaas.ThousandsSeparator = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKaydet.Location = new System.Drawing.Point(501, 205);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSil.Location = new System.Drawing.Point(592, 205);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(501, 234);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(176, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIzinGit
            // 
            this.btnIzinGit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzinGit.Location = new System.Drawing.Point(722, 22);
            this.btnIzinGit.Name = "btnIzinGit";
            this.btnIzinGit.Size = new System.Drawing.Size(164, 23);
            this.btnIzinGit.TabIndex = 12;
            this.btnIzinGit.Text = "Seçili Kişiye İzin Yaz";
            this.btnIzinGit.UseVisualStyleBackColor = false;
            this.btnIzinGit.Click += new System.EventHandler(this.btnIzinGit_Click);
            // 
            // btnIzinOnaylama
            // 
            this.btnIzinOnaylama.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzinOnaylama.Location = new System.Drawing.Point(722, 51);
            this.btnIzinOnaylama.Name = "btnIzinOnaylama";
            this.btnIzinOnaylama.Size = new System.Drawing.Size(164, 23);
            this.btnIzinOnaylama.TabIndex = 13;
            this.btnIzinOnaylama.Text = "İzin Onayları";
            this.btnIzinOnaylama.UseVisualStyleBackColor = false;
            this.btnIzinOnaylama.Click += new System.EventHandler(this.btnIzinYönetim_Click);
            // 
            // btnPerformans
            // 
            this.btnPerformans.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPerformans.Location = new System.Drawing.Point(722, 80);
            this.btnPerformans.Name = "btnPerformans";
            this.btnPerformans.Size = new System.Drawing.Size(164, 23);
            this.btnPerformans.TabIndex = 14;
            this.btnPerformans.Text = "Performans Ölçme";
            this.btnPerformans.UseVisualStyleBackColor = false;
            this.btnPerformans.Click += new System.EventHandler(this.btnPerformansGit_Click);
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(501, 138);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(134, 24);
            this.cmbDepartmanlar.TabIndex = 15;
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRaporlar.Location = new System.Drawing.Point(722, 109);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(164, 23);
            this.btnRaporlar.TabIndex = 16;
            this.btnRaporlar.Text = "İşletme Raporları";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporGit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(444, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "İSİM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(410, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "SOYİSİM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(456, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(418, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "GÖREV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(371, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "DEPARTMAN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(431, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "MAAŞ:";
            // 
            // btnMaasForm
            // 
            this.btnMaasForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMaasForm.Location = new System.Drawing.Point(722, 141);
            this.btnMaasForm.Name = "btnMaasForm";
            this.btnMaasForm.Size = new System.Drawing.Size(164, 23);
            this.btnMaasForm.TabIndex = 23;
            this.btnMaasForm.Text = "Maaş Yönetimi";
            this.btnMaasForm.UseVisualStyleBackColor = false;
            this.btnMaasForm.Click += new System.EventHandler(this.btnMaasForm_Click);
            // 
            // btnDepForm
            // 
            this.btnDepForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDepForm.Location = new System.Drawing.Point(722, 170);
            this.btnDepForm.Name = "btnDepForm";
            this.btnDepForm.Size = new System.Drawing.Size(166, 23);
            this.btnDepForm.TabIndex = 24;
            this.btnDepForm.Text = "Departman Yönetimi";
            this.btnDepForm.UseVisualStyleBackColor = false;
            this.btnDepForm.Click += new System.EventHandler(this.btnDepForm_Click);
            // 
            // lblSeciliId
            // 
            this.lblSeciliId.AutoSize = true;
            this.lblSeciliId.Location = new System.Drawing.Point(887, -2);
            this.lblSeciliId.Name = "lblSeciliId";
            this.lblSeciliId.Size = new System.Drawing.Size(11, 16);
            this.lblSeciliId.TabIndex = 25;
            this.lblSeciliId.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 368);
            this.Controls.Add(this.lblSeciliId);
            this.Controls.Add(this.btnDepForm);
            this.Controls.Add(this.btnMaasForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.cmbDepartmanlar);
            this.Controls.Add(this.btnPerformans);
            this.Controls.Add(this.btnIzinOnaylama);
            this.Controls.Add(this.btnIzinGit);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.numMaas);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvPersonel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "PERSONEL YÖNETİMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.NumericUpDown numMaas;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnIzinGit;
        private System.Windows.Forms.Button btnIzinOnaylama;
        private System.Windows.Forms.Button btnPerformans;
        private System.Windows.Forms.ComboBox cmbDepartmanlar;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMaasForm;
        private System.Windows.Forms.Button btnDepForm;
        private System.Windows.Forms.Label lblSeciliId;
    }
}

