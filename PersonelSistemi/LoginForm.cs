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
using PersonelSistemi.DAL;

namespace PersonelSistemi
{
    public partial class LoginForm : Form
    {   
        DAL.VeriTabani vt = new DAL.VeriTabani();
        public LoginForm()
        {
            InitializeComponent();
        }
        PersonelIslemleri islem = new PersonelIslemleri();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {              
                string sql = "SELECT rol, PersonelID FROM kullanıcı WHERE kullaniciAdi = @ad AND parolaHash = @sifre";
                MySqlParameter[] p = {
                new MySqlParameter("@ad", txtKullaniciAd.Text),
                new MySqlParameter("@sifre", txtSifre.Text)
                };
                DataTable dt = vt.VeriGetir(sql, p);
                if (dt.Rows.Count > 0)
                {
                    Program.AktifRol = dt.Rows[0]["rol"].ToString();
                    if (dt.Rows[0]["PersonelID"] != DBNull.Value)
                    {
                        Program.AktifPersonelID = Convert.ToInt32(dt.Rows[0]["PersonelID"]);
                    }
                    else
                    {
                        MessageBox.Show("Uyarı: Bu kullanıcıya atanmış bir Personel ID bulunamadı! Lütfen veritabanından PersonelID kısmını doldurun.");                     
                    }
                    Form1 anaForm = new Form1();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş sırasında teknik bir hata oluştu: " + ex.Message);
            }

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
