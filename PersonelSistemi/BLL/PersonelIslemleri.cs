using System;
using System.Data;
using MySql.Data.MySqlClient;
using PersonelSistemi.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSistemi.BLL
{
    public class PersonelIslemleri
    {
        VeriTabani vt = new VeriTabani();
        public DataTable PersonelleriGetir()
        {
            string sql = "SELECT * FROM personel";
            return vt.VeriGetir(sql);
        }
        public void PersonelEkle(string ad, string soyad, string tc, decimal maas, int depId)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
                throw new Exception("Ad ve Soyad boş geçilemez!");
            string sql = "INSERT INTO personel (name, lastName, TcNo, MaasMiktar, departmanId) " +
                         "VALUES (@ad, @soyad, @tc, @maas, @depId)";
            MySqlParameter[] p = {
            new MySqlParameter("@ad", ad),
            new MySqlParameter("@soyad", soyad),
            new MySqlParameter("@tc", tc),
            new MySqlParameter("@maas", maas),
            new MySqlParameter("@depId", depId)
            };
            vt.SorguCalistir(sql, p);
        }

        public void PersonelSil(int id)
        {
            string sql = "DELETE FROM personel WHERE personelID = @id";
            MySqlParameter[] p = { new MySqlParameter("@id", id) };
            vt.SorguCalistir(sql, p);
        }
        public void PersonelKaydet(string ad, string soyad, string tc, string gorev, decimal maas, int depId)
        {
            string sql = "INSERT INTO personel (name, lastName, TcNo, Gorev, MaasMiktar, departmanId, kayıtTarihi, IseGirisTarihi) " +
                         "VALUES (@ad, @soyad, @tc, @gorev, @maas, @depId, @kayit, @iseGiris)";
            MySqlParameter[] p ={
            new MySqlParameter("@ad", ad),
            new MySqlParameter("@soyad", soyad),
            new MySqlParameter("@tc", tc),
            new MySqlParameter("@gorev", gorev),
            new MySqlParameter("@maas", maas),
            new MySqlParameter("@depId", depId),
            new MySqlParameter("@kayit", DateTime.Now),
            new MySqlParameter("@iseGiris", DateTime.Now) 
            };

            vt.SorguCalistir(sql, p);
        }
        public string GirisKontrol(string kAdi, string sifre)
        {
            string sql = "SELECT rol FROM kullanıcı WHERE kullaniciAdi = @user AND parolaHash = @pass";
            MySqlParameter[] p = {
            new MySqlParameter("@user", kAdi),
            new MySqlParameter("@pass", sifre)
            };

            DataTable dt = vt.VeriGetir(sql, p);
            if (dt.Rows.Count > 0)
            {               
                return dt.Rows[0]["rol"].ToString();
            }
            return null; 
        }
        public void PersonelGuncelle(int id, string ad, string soyad, string tc, string gorev, decimal maas, int depId)
        {
            string sql = "UPDATE personel SET name=@ad, lastName=@soyad, TcNo=@tc, Gorev=@gorev, " +
                         "MaasMiktar=@maas, departmanId=@depId WHERE personelID=@id";
            MySqlParameter[] p = {
            new MySqlParameter("@ad", ad),
            new MySqlParameter("@soyad", soyad),
            new MySqlParameter("@tc", tc),
            new MySqlParameter("@gorev", gorev),
            new MySqlParameter("@maas", maas),
            new MySqlParameter("@depId", depId),
            new MySqlParameter("@id", id)
           };

            vt.SorguCalistir(sql, p);
        }
        public void IzinTalebiOlustur(int pId, DateTime baslangic, DateTime bitis, string tur)
        {
            int gunSayisi = (bitis - baslangic).Days + 1;
            if (gunSayisi <= 0)
                throw new Exception("Bitiş tarihi başlangıçtan sonra olmalıdır!");
            if (gunSayisi > 14)
                throw new Exception("Bir personel tek seferde 14 günden fazla izin alamaz!");
            string sql = @"INSERT INTO personelİzin 
                   (PersonelID, baslangicTarihi, bitisTarihi, izinTuru, onayDurumu)
                   VALUES (@pId, @bas, @bit, @tur, 'BEKLEMEDE')";
            MySqlParameter[] p = {
            new MySqlParameter("@pId", pId),
            new MySqlParameter("@bas", baslangic),
            new MySqlParameter("@bit", bitis),
            new MySqlParameter("@tur", tur)
            };
            vt.SorguCalistir(sql, p);           
        }
        public DataTable BekleyenIzinleriGetir()
        {
            string sql = "SELECT * FROM personelİzin WHERE onayDurumu = 'Beklemede'";
            return vt.VeriGetir(sql);
        }
        public void IzinDurumGuncelle(int IzinId, string yeniDurum)
        {
            string sql = "UPDATE personelİzin SET onayDurumu = @durum WHERE IzinID = @id";
            MySqlParameter[] p = {
            new MySqlParameter("@durum", yeniDurum.ToUpper()),
            new MySqlParameter("@id", IzinId)
            };

            vt.SorguCalistir(sql, p);
        }
        public DataTable RaporPersonelIzinOzeti()
        {
            string sql = @"SELECT p.name, p.lastName, SUM(DATEDIFF(i.izinBitis, i.izinBaslangic)) as ToplamGun 
                   FROM personel p 
                   JOIN izinler i ON p.personelID = i.personelID 
                   WHERE i.onayDurumu = 'Onaylandı' 
                   GROUP BY p.personelID";
            return vt.VeriGetir(sql);
        }
        public DataTable RaporDepartmanMaasYuku()
        {
            string sql = "SELECT departmanId, SUM(MaasMiktar) as ToplamOdeme, AVG(MaasMiktar) as OrtalamaMaas FROM personel GROUP BY departmanId";
            return vt.VeriGetir(sql);
        }
        public DataTable DepartmanlariGetir()
        {
            string sql = "SELECT * FROM Departman"; 
            return vt.VeriGetir(sql);
        }
        public void DepartmanEkle(string depAd)
        {
            string sql = "INSERT INTO Departman (name) VALUES (@p1)";
            MySqlParameter[] parametreler = { new MySqlParameter("@p1", depAd) };
            vt.SorguCalistir(sql, parametreler);
        }
        public decimal NetMaasHesapla(decimal brut, decimal prim, decimal kesinti)
        {         
            if (brut < 0)
                throw new Exception("Brüt maaş 0'dan küçük olamaz!");
            decimal sonuc = brut + prim - kesinti;
            if (sonuc < 0) sonuc = 0; 
            return sonuc;
        }
        public void MaasKaydet(int pId, decimal netMaas)
        {
            string sql = "UPDATE personel SET MaasMiktar = @maas WHERE personelID = @id";
            MySqlParameter[] p = {
            new MySqlParameter("@maas", netMaas),
            new MySqlParameter("@id", pId)
            };
            vt.SorguCalistir(sql, p);
        }
        public void PerformansKaydet(int pId, int puan, string yorum)
        {         
            if (puan < 0 || puan > 100)
                throw new Exception("İş Kuralı: Performans puanı 0-100 aralığında olmalıdır!");
            string sql = "INSERT INTO performans (PersonelID, Puan, Yorum, DegerlendirmeTarihi) VALUES (@pId, @puan, @yorum, @tarih)";
            MySqlParameter[] p = {
            new MySqlParameter("@pId", pId),
            new MySqlParameter("@puan", puan),
            new MySqlParameter("@yorum", yorum),
            new MySqlParameter("@tarih", DateTime.Now)
            };
            vt.SorguCalistir(sql, p);
        } 
        public DataTable PerformansRaporuGetir(bool enYuksekMi)
        {
            string siralama = enYuksekMi ? "DESC" : "ASC";
            string sql = $@"SELECT p.name, p.lastName, per.Puan, per.Yorum 
                    FROM personel p 
                    JOIN performans per ON p.personelID = per.PersonelID 
                    ORDER BY per.Puan {siralama} LIMIT 5";

            return vt.VeriGetir(sql);
        }
        public DataTable RaporDepartmanDagilimi()
        {
            string sql = @"SELECT d.name as 'Departman Adı', COUNT(p.personelID) as 'Personel Sayısı' 
                   FROM Departman d 
                   LEFT JOIN personel p ON d.departmanId = p.departmanId 
                   GROUP BY d.name";

            return vt.VeriGetir(sql);
        }
        public DataTable RaporMaasOzeti()
        {
            string sql = "SELECT SUM(MaasMiktar) as 'Toplam Maliyet', AVG(MaasMiktar) as 'Ortalama Maas' FROM personel";
            return vt.VeriGetir(sql);
        }
        public DataTable RaporIzinHakedis()
        {
            string sql = @"SELECT p.name, p.lastName, 
                   (14 - IFNULL(SUM(DATEDIFF(i.bitisTarihi, i.baslangicTarihi)), 0)) as 'Kalan İzin'
                   FROM personel p
                   LEFT JOIN personelİzin i ON p.personelID = i.PersonelID AND i.onayDurumu = 'ONAYLANDI'
                   GROUP BY p.personelID";
            return vt.VeriGetir(sql);
        }
        public DataTable TumPerformanslariGetir()
        {
            string sql = @"SELECT p.name, p.lastName, per.Puan, per.Yorum, per.DegerlendirmeTarihi 
                    FROM performans per 
                    JOIN personel p ON per.PersonelID = p.personelID";
            return vt.VeriGetir(sql);
        }
        public DataTable RaporTarihliIzinler(DateTime baslangic, DateTime bitis)
        {
            string sql = @"SELECT p.name, p.lastName, i.baslangicTarihi, i.bitisTarihi, i.izinTürü 
                   FROM personel p 
                   JOIN personelİzin i ON p.personelID = i.PersonelID 
                   WHERE i.onayDurumu = 'ONAYLANDI' 
                   AND i.baslangicTarihi >= @bas AND i.bitisTarihi <= @bit";
            MySqlParameter[] p = {
            new MySqlParameter("@bas", baslangic),
            new MySqlParameter("@bit", bitis)
            };
            return vt.VeriGetir(sql, p);
        }
        public DataTable TekPersonelGetir(int id)
        {
            string sql = "SELECT * FROM personel WHERE personelID = @id";
            MySqlParameter[] p = { new MySqlParameter("@id", id) };
            return vt.VeriGetir(sql, p);
        }
        public DataTable DepartmanBazliPersonelGetir(int depId)
        {
            string sql = "SELECT * FROM personel WHERE departmanId = @id";
            MySqlParameter[] p = { new MySqlParameter("@id", depId) };
            return vt.VeriGetir(sql, p);
        }
    }
}
