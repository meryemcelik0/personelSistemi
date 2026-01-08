namespace PersonelSistemi
{
    partial class DepartmentForm
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
            this.txtYeniDep = new System.Windows.Forms.TextBox();
            this.btnDepEkle = new System.Windows.Forms.Button();
            this.dgvDepartmanlar = new System.Windows.Forms.DataGridView();
            this.cmbDepSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYeniDep
            // 
            this.txtYeniDep.Location = new System.Drawing.Point(256, 372);
            this.txtYeniDep.Name = "txtYeniDep";
            this.txtYeniDep.Size = new System.Drawing.Size(160, 22);
            this.txtYeniDep.TabIndex = 0;
            // 
            // btnDepEkle
            // 
            this.btnDepEkle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDepEkle.Location = new System.Drawing.Point(297, 400);
            this.btnDepEkle.Name = "btnDepEkle";
            this.btnDepEkle.Size = new System.Drawing.Size(84, 23);
            this.btnDepEkle.TabIndex = 1;
            this.btnDepEkle.Text = "EKLE";
            this.btnDepEkle.UseVisualStyleBackColor = false;
            this.btnDepEkle.Click += new System.EventHandler(this.btnDepEkle_Click);
            // 
            // dgvDepartmanlar
            // 
            this.dgvDepartmanlar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDepartmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmanlar.Location = new System.Drawing.Point(95, 21);
            this.dgvDepartmanlar.Name = "dgvDepartmanlar";
            this.dgvDepartmanlar.RowHeadersWidth = 51;
            this.dgvDepartmanlar.RowTemplate.Height = 24;
            this.dgvDepartmanlar.Size = new System.Drawing.Size(716, 323);
            this.dgvDepartmanlar.TabIndex = 2;
            // 
            // cmbDepSec
            // 
            this.cmbDepSec.FormattingEnabled = true;
            this.cmbDepSec.Location = new System.Drawing.Point(590, 370);
            this.cmbDepSec.Name = "cmbDepSec";
            this.cmbDepSec.Size = new System.Drawing.Size(160, 24);
            this.cmbDepSec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DEPARTMAN SEÇ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "YENİ DEPARTMAN:";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDepSec);
            this.Controls.Add(this.dgvDepartmanlar);
            this.Controls.Add(this.btnDepEkle);
            this.Controls.Add(this.txtYeniDep);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "DepartmentForm";
            this.Text = "DEPARTMAN VE BİRİM YÖNETİMİ";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniDep;
        private System.Windows.Forms.Button btnDepEkle;
        private System.Windows.Forms.DataGridView dgvDepartmanlar;
        private System.Windows.Forms.ComboBox cmbDepSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}