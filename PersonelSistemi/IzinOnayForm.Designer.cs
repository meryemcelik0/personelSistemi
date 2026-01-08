namespace PersonelSistemi
{
    partial class IzinOnayForm
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
            this.dgvBekleyenIzinler = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenIzinler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBekleyenIzinler
            // 
            this.dgvBekleyenIzinler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBekleyenIzinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBekleyenIzinler.Location = new System.Drawing.Point(61, 33);
            this.dgvBekleyenIzinler.Name = "dgvBekleyenIzinler";
            this.dgvBekleyenIzinler.RowHeadersWidth = 51;
            this.dgvBekleyenIzinler.RowTemplate.Height = 24;
            this.dgvBekleyenIzinler.Size = new System.Drawing.Size(506, 252);
            this.dgvBekleyenIzinler.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOnayla.Location = new System.Drawing.Point(130, 308);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(151, 41);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "İZİN ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReddet.Location = new System.Drawing.Point(350, 308);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(140, 41);
            this.btnReddet.TabIndex = 2;
            this.btnReddet.Text = "İZİN REDDET";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // IzinOnayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvBekleyenIzinler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "IzinOnayForm";
            this.Text = "İZİN ONAYLAMA FORMU";
            this.Load += new System.EventHandler(this.IzinOnayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenIzinler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBekleyenIzinler;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
    }
}