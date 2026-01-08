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
    public partial class IzinForm : Form
    {
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public IzinForm()
        {
            InitializeComponent();
        }
        private void btnIzinKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int pId = Convert.ToInt32(txtIzinPersonelId.Text);
                DateTime bas = dtpBaslangic.Value;
                DateTime bit = dtpBitis.Value;
                string tur = cmbIzinTuru.Text;
                personelBll.IzinTalebiOlustur(pId, bas, bit, tur);
                MessageBox.Show("İzin başarıyla kaydedildi!");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void IzinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
