namespace PersonelSistemi
{
    partial class PerformanceForm
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
            this.numPuan = new System.Windows.Forms.NumericUpDown();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.btnPuanVer = new System.Windows.Forms.Button();
            this.dgvPerformans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformans)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(181, 70);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(136, 24);
            this.cmbPersoneller.TabIndex = 0;
            // 
            // numPuan
            // 
            this.numPuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPuan.Location = new System.Drawing.Point(181, 114);
            this.numPuan.Name = "numPuan";
            this.numPuan.Size = new System.Drawing.Size(136, 22);
            this.numPuan.TabIndex = 1;
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(181, 157);
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(136, 22);
            this.txtYorum.TabIndex = 2;
            // 
            // btnPuanVer
            // 
            this.btnPuanVer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPuanVer.Location = new System.Drawing.Point(203, 196);
            this.btnPuanVer.Name = "btnPuanVer";
            this.btnPuanVer.Size = new System.Drawing.Size(84, 41);
            this.btnPuanVer.TabIndex = 3;
            this.btnPuanVer.Text = "PUAN VER";
            this.btnPuanVer.UseVisualStyleBackColor = false;
            this.btnPuanVer.Click += new System.EventHandler(this.btnPuanVer_Click);
            // 
            // dgvPerformans
            // 
            this.dgvPerformans.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPerformans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformans.Location = new System.Drawing.Point(370, 35);
            this.dgvPerformans.Name = "dgvPerformans";
            this.dgvPerformans.RowHeadersWidth = 51;
            this.dgvPerformans.RowTemplate.Height = 24;
            this.dgvPerformans.Size = new System.Drawing.Size(352, 292);
            this.dgvPerformans.TabIndex = 4;
            this.dgvPerformans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformans_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "PUAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "YORUM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "PERSONEL ID:";
            // 
            // PerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPerformans);
            this.Controls.Add(this.btnPuanVer);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.numPuan);
            this.Controls.Add(this.cmbPersoneller);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PerformanceForm";
            this.Text = "PERSONEL PERFORMANS GİRİŞ";
            this.Load += new System.EventHandler(this.PerformanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.NumericUpDown numPuan;
        private System.Windows.Forms.TextBox txtYorum;
        private System.Windows.Forms.Button btnPuanVer;
        private System.Windows.Forms.DataGridView dgvPerformans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}