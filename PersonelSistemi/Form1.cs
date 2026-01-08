using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PersonelSistemi.BLL;

namespace PersonelSistemi
{
    public partial class Form1 : Form
    {
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public string KullaniciRolu { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable personelTablosu = personelBll.PersonelleriGetir();
                dgvPersonel.DataSource = personelTablosu;
                if (dgvPersonel.Rows.Count > 0)
                {
                    MessageBox.Show("Veriler başarıyla listelendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string tc = txtTc.Text;
                string gorev = txtGorev.Text;
                decimal maas = numMaas.Value;
                int depId = Convert.ToInt32(cmbDepartmanlar.SelectedValue);
                personelBll.PersonelKaydet(ad, soyad, tc, gorev, maas, depId);
                MessageBox.Show("Personel başarıyla eklendi!");
                dgvPersonel.DataSource = personelBll.PersonelleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonel.CurrentRow != null)
                {                   
                    int seciliId = Convert.ToInt32(dgvPersonel.CurrentRow.Cells["personelID"].Value);
                    DialogResult onay = MessageBox.Show("Bu personeli silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                    if (onay == DialogResult.Yes)
                    {                 
                        personelBll.PersonelSil(seciliId);
                        MessageBox.Show("Personel başarıyla silindi.");                       
                        dgvPersonel.DataSource = personelBll.PersonelleriGetir();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DepartmanListesiniDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departman yüklenemedi: " + ex.Message);
            }
            string rol = Program.AktifRol?.Trim().ToLower();
            if (rol == "normal")
            {
                dgvPersonel.Visible = false;
                btnListele.Visible = false;
                btnKaydet.Visible = false;
                btnSil.Visible = false;
                btnRaporlar.Visible = false;
                btnIzinOnaylama.Visible = false;
                btnPerformans.Visible = false;
                btnMaasForm.Visible = false;
                btnDepForm.Visible = false;
                btnGuncelle.Visible = true;
                btnIzinGit.Visible = true;
                btnGuncelle.Text = "Bilgilerimi Güncelle";
                btnIzinGit.Text = "İzin Talebi Oluştur";
                KendiBilgilerimiGetir(); 
            }
            else if (rol == "personel")
            {
                dgvPersonel.Visible = true;
                btnIzinOnaylama.Visible = false; 
                btnMaasForm.Visible = true;
                btnDepForm.Visible = true;
                btnRaporlar.Visible = true;
                VerileriYukle(); 
            }
            else if (rol == "admin") 
            {
                dgvPersonel.Visible = true;
                btnIzinOnaylama.Visible = true;
                btnRaporlar.Visible = true;
                btnMaasForm.Visible = true;
                btnDepForm.Visible = true;
                VerileriYukle();
            }
        }
        private void VerileriYukle()
        {
            try
            {
                dgvPersonel.DataSource = personelBll.PersonelleriGetir(); 
                DepartmanListesiniDoldur(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme hatası: " + ex.Message);
            }
        }
        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow satir = dgvPersonel.Rows[e.RowIndex];               
                txtAd.Text = satir.Cells["name"].Value.ToString();
                txtSoyad.Text = satir.Cells["lastName"].Value.ToString();
                txtTc.Text = satir.Cells["TcNo"].Value.ToString();
                txtGorev.Text = satir.Cells["Gorev"].Value.ToString();
                numMaas.Value = Convert.ToDecimal(satir.Cells["MaasMiktar"].Value);
                cmbDepartmanlar.SelectedValue = satir.Cells["departmanId"].Value;               
                lblSeciliId.Text = satir.Cells["personelID"].Value.ToString();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {               
                if (string.IsNullOrEmpty(lblSeciliId.Text))
                {
                    MessageBox.Show("ID bilgisi bulunamadı!");
                    return;
                }
                int id = Convert.ToInt32(lblSeciliId.Text);
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string tc = txtTc.Text;
                string gorev = txtGorev.Text;
                decimal maas = numMaas.Value;                
                int depId;
                if (cmbDepartmanlar.SelectedValue != null)
                    depId = Convert.ToInt32(cmbDepartmanlar.SelectedValue);
                else
                    depId = 1; 
                personelBll.PersonelGuncelle(id, ad, soyad, tc, gorev, maas, depId);
                MessageBox.Show("Bilgileriniz başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası detay: " + ex.Message);
            }
        }
        private void btnIzinGit_Click(object sender, EventArgs e)
        {
            IzinForm frm = new IzinForm();
            if (Program.AktifRol == "normal")
            {                
                frm.txtIzinPersonelId.Text = Program.AktifPersonelID.ToString();
                frm.txtIzinPersonelId.ReadOnly = true; 
                frm.ShowDialog();
            }
            else 
            {
                if (dgvPersonel.CurrentRow != null)
                {
                    frm.txtIzinPersonelId.Text = dgvPersonel.CurrentRow.Cells["personelID"].Value.ToString();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen listeden bir personel seçin!");
                }
            }
        }
        private void btnIzinYönetim_Click(object sender, EventArgs e)
        {
            if (Program.AktifRol != null && Program.AktifRol.Trim().ToLower() == "admin")
            {
                IzinOnayForm frm = new IzinOnayForm();
                frm.ShowDialog();
            }
            else
            {               
                MessageBox.Show("sistemdeki Rolünüz: '"+Program.AktifRol+"' olarak görünüyor. bu buton sadece 'Admin' rolü için yetkilendirilmiştir");
            }
        }
        private void btnPerformansGit_Click(object sender, EventArgs e)
        {          
            if (Program.AktifRol == "Admin" || Program.AktifRol == "Personel")
            {
                PerformanceForm frm = new PerformanceForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bu ekrana sadece İK personeli ve yöneticiler erişebilir!");
            }
        }
        private void DepartmanListesiniDoldur()
        {
            cmbDepartmanlar.DataSource = personelBll.DepartmanlariGetir();
            cmbDepartmanlar.DisplayMember = "name";
            cmbDepartmanlar.ValueMember = "departmanId";
        }
        private void btnRaporGit_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.GelenRol = Program.AktifRol;
            frm.ShowDialog();
        }
        private void KendiBilgilerimiGetir()
        {
            int id = Program.AktifPersonelID;
            if (id <= 0) return; 
            DataTable dt = personelBll.TekPersonelGetir(id);
            if (dt.Rows.Count > 0)
            {
                txtAd.Text = dt.Rows[0]["name"].ToString();
                txtSoyad.Text = dt.Rows[0]["lastName"].ToString();
                txtTc.Text = dt.Rows[0]["TcNo"].ToString();
                txtGorev.Text = dt.Rows[0]["Gorev"].ToString();
                numMaas.Value = Convert.ToDecimal(dt.Rows[0]["MaasMiktar"]);
                lblSeciliId.Text = id.ToString();
            }
        }
        private void btnMaasForm_Click(object sender, EventArgs e)
        {
            SalaryForm frm = new SalaryForm();
            frm.ShowDialog();
        }
        private void btnDepForm_Click(object sender, EventArgs e)
        {
            DepartmentForm frm = new DepartmentForm();
            frm.ShowDialog();
        }
    }
}
