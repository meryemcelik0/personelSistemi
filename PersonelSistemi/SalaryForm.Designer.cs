namespace PersonelSistemi
{
    partial class SalaryForm
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
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.txtBrutMaas = new System.Windows.Forms.TextBox();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.txtKesinti = new System.Windows.Forms.TextBox();
            this.lblNetMaas = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(166, 81);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(198, 24);
            this.cmbPersoneller.TabIndex = 0;
            // 
            // txtBrutMaas
            // 
            this.txtBrutMaas.Location = new System.Drawing.Point(166, 123);
            this.txtBrutMaas.Name = "txtBrutMaas";
            this.txtBrutMaas.Size = new System.Drawing.Size(198, 22);
            this.txtBrutMaas.TabIndex = 1;
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(166, 161);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(198, 22);
            this.txtPrim.TabIndex = 2;
            // 
            // txtKesinti
            // 
            this.txtKesinti.Location = new System.Drawing.Point(166, 203);
            this.txtKesinti.Name = "txtKesinti";
            this.txtKesinti.Size = new System.Drawing.Size(198, 22);
            this.txtKesinti.TabIndex = 3;
            // 
            // lblNetMaas
            // 
            this.lblNetMaas.AutoSize = true;
            this.lblNetMaas.Location = new System.Drawing.Point(70, 248);
            this.lblNetMaas.Name = "lblNetMaas";
            this.lblNetMaas.Size = new System.Drawing.Size(88, 16);
            this.lblNetMaas.TabIndex = 4;
            this.lblNetMaas.Text = "NET MAAŞ:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHesapla.Location = new System.Drawing.Point(210, 276);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(102, 23);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKaydet.Location = new System.Drawing.Point(210, 305);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "BRÜT MAAŞ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRİM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "KESİNTİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "PERSONEL:";
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblNetMaas);
            this.Controls.Add(this.txtKesinti);
            this.Controls.Add(this.txtPrim);
            this.Controls.Add(this.txtBrutMaas);
            this.Controls.Add(this.cmbPersoneller);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SalaryForm";
            this.Text = "PERSONEL MAAŞ HESAPLAMA";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.TextBox txtBrutMaas;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.TextBox txtKesinti;
        private System.Windows.Forms.Label lblNetMaas;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}