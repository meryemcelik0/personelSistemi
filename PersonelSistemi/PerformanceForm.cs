using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelSistemi.BLL;

namespace PersonelSistemi
{
    public partial class PerformanceForm : Form
    {
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public PerformanceForm()
        {
            InitializeComponent();
        }
        private void btnPuanVer_Click(object sender, EventArgs e)
        {
            try
            {            
                int pId = Convert.ToInt32(cmbPersoneller.SelectedValue);
                int puan = (int)numPuan.Value;
                string yorum = txtYorum.Text;
                personelBll.PerformansKaydet(pId, puan, yorum);
                MessageBox.Show("Performans değerlendirmesi başarıyla kaydedildi!");
                dgvPerformans.DataSource = personelBll.TumPerformanslariGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void PerformanceForm_Load(object sender, EventArgs e)
        {
            cmbPersoneller.DataSource = personelBll.PersonelleriGetir();
            cmbPersoneller.DisplayMember = "name"; 
            cmbPersoneller.ValueMember = "personelID"; 
            dgvPerformans.DataSource = personelBll.TumPerformanslariGetir();
        }
        private void dgvPerformans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
