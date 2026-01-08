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
    public partial class DepartmentForm : Form
    {
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public DepartmentForm()
        {
            InitializeComponent();
        }
        private void btnDepEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYeniDep.Text))
            {
                personelBll.DepartmanEkle(txtYeniDep.Text);
                dgvDepartmanlar.DataSource = personelBll.DepartmanlariGetir();
                txtYeniDep.Clear();
                MessageBox.Show("Yeni departman eklendi.");
            }
        }
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            dgvDepartmanlar.DataSource = personelBll.DepartmanlariGetir();
            cmbDepSec.DataSource = personelBll.DepartmanlariGetir();
            cmbDepSec.DisplayMember = "name";
            cmbDepSec.ValueMember = "departmanId";
        }
    }
}
