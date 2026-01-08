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
    public partial class SalaryForm : Form
    {
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public SalaryForm()
        {
            InitializeComponent();
        }
        private decimal sonHesaplananNetMaas = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtBrutMaas.Text, out decimal brut) &&
                    decimal.TryParse(txtPrim.Text, out decimal prim) &&
                    decimal.TryParse(txtKesinti.Text, out decimal kesinti))
                {                   
                    sonHesaplananNetMaas = personelBll.NetMaasHesapla(brut, prim, kesinti);
                    lblNetMaas.Text = "Net Maaş: " + sonHesaplananNetMaas.ToString("N2") + " TL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama Hatası: " + ex.Message);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPersoneller.SelectedValue != null)
                {
                    int pId = Convert.ToInt32(cmbPersoneller.SelectedValue);                   
                    if (sonHesaplananNetMaas > 0)
                    {
                        personelBll.MaasKaydet(pId, sonHesaplananNetMaas);
                        MessageBox.Show("Maaş bilgisi başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen önce maaş hesaplaması yapın!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message);
            }
        }
        private void SalaryForm_Load(object sender, EventArgs e)
        {
            cmbPersoneller.DataSource = personelBll.PersonelleriGetir();
            cmbPersoneller.DisplayMember = "name"; 
            cmbPersoneller.ValueMember = "personelID"; 
        }
    }
}
