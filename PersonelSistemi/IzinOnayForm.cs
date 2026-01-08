using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelSistemi.BLL;

namespace PersonelSistemi
{
    public partial class IzinOnayForm : Form
    {
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public IzinOnayForm()
        {
            InitializeComponent();
        }
        private void IzinOnayForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            dgvBekleyenIzinler.DataSource = personelBll.BekleyenIzinleriGetir();
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dgvBekleyenIzinler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvBekleyenIzinler.CurrentRow.Cells["IzinID"].Value);
                personelBll.IzinDurumGuncelle(id, "ONAYLANDI");
                MessageBox.Show("İzin başarıyla onaylandı!");
                Listele();
            }
        }
        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dgvBekleyenIzinler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvBekleyenIzinler.CurrentRow.Cells["IzinID"].Value);
                personelBll.IzinDurumGuncelle(id, "REDDEDİLDİ"); 
                MessageBox.Show("İzin reddedildi.");
                Listele();
            }
        }
    }
}
