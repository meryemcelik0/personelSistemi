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
    public partial class ReportForm : Form
    {
        public string GelenRol { get; set; }
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public ReportForm()
        {
            InitializeComponent();
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (GelenRol.Trim().ToLower() != "admin")
            {
                MessageBox.Show("Raporları görüntüleme yetkiniz kısıtlıdır.");
            }
        }
        private void btnRaporuGetir_Click(object sender, EventArgs e)
        {
            dgvRaporSonuclari.DataSource = null;
            if (cmbRaporTuru.SelectedItem == null) return;
            string secilen = cmbRaporTuru.SelectedItem.ToString();
            switch (secilen)
            {
                case "Maaş Özeti":
                    dgvRaporSonuclari.DataSource = personelBll.RaporMaasOzeti();
                    break;
                case "İzin Hakediş":
                    dgvRaporSonuclari.DataSource = personelBll.RaporIzinHakedis();
                    break;
                case "Performans Analizi":
                    dgvRaporSonuclari.DataSource = personelBll.PerformansRaporuGetir(true);
                    break;
                case "Departman Dağılımı":
                    dgvRaporSonuclari.DataSource = personelBll.RaporDepartmanDagilimi();
                    break;
                case "İzin Raporu":
                    dgvRaporSonuclari.DataSource = personelBll.RaporTarihliIzinler(dtpBaslangic.Value, dtpBitis.Value);
                    break;
            }

        }

    }
}
