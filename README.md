# PERSONEL YÖNETİM SİSTEMİ
Bu proje, bir Personel Yönetim Sistemi masaüstü uygulamasıdır. Uygulama, kurumlarda çalışan personelin bilgilerini, departmanlarını, izin süreçlerini, maaş ve performans değerlendirmelerini kolay ve düzenli bir şekilde yönetmek amacıyla tasarlanmıştır.
## Proje Özellikleri
**- Giriş Sistemi:** Kullanıcı adı ve şifre doğrulaması ile Role Dayalı yetkilendirme. <br/>
**- Personel İşlemleri** Personel ekleme, güncelleme, silme ve listeleme işlemleri.  <br/>
**- Departman Yönetimi:** Departman tanımlama ve yeni birim ekleme.  <br/>
**- İzin Yönetimi:** Personel izin talebi oluşturma, yönetici tarafınan izin onaylama/reddetme.  <br/>
**- Maaş İşlemleri:** Brüt maaş, prim vekesinti bilgileriyle net maaş hesaplama.  <br/>
**- Performan Değerlendirme:** Personellere puan ve yorum verilerek performans takibi. <br/>
**- Raporlama:** İzin, maaş, performans ve departman bazlı raporlar.
## Kullanılan Teknolojiler
**- C# (.NET Framework):** Uygulamanın işlevsel yapısını oluşturan ana programlama dili ve geliştirme altyapısıdır. <br/>
**- Windows Forms:** Masaüstü uygulamasının kullanıcı arayüzü tasarımında kullanılmıştır. <br/>
**- MySQL:** Uygulamada kullanılan verilerin saklandığı ilişkisel veritabanı sistemidir. <br/>
**- ADO.NET:** Uygulama ile MySQL veritabanı arasındaki bağlantıyı sağlamak için kullanılmıştır. <br/>
**- Katmanlı Mimari (DAL – BLL – UI):** Projenin daha düzenli, sürdürülebilir ve yönetilebilir olması amacıyla kullanılmıştır.
## Diyagramlar
**Use-Case Diyagramı** <br/>
**Class Diyagramı** <br/>
**Er Diyagramı** <br/>
## Ekran Görüntüleri
**Giriş Sayfası**  <br/>
Kullanıcı adı ve şifre ile sisteme giriş yapılır. Kullanıcının rolüne göre yetkili olduğu ekranlara yönlendirme yapılır. <br/>
**Ana Ekran** <br/>
Personel, departman, izin, maaş ve rapor işlemlerinin yönetildiği ana ekrandır. bu işlemlerin butonlarına basılarak asıl ekranlara gidilir. Rol bazlı buton görünürlüğü uygulanmıştır. <br/>
**İzin Talep Ekranı** <br/
Personellerin yıllık, sağlık ve mazeret izinleri için başvuru yaptığı ekrandır. Başlangıç ve bitiş taihleri seçildiğinde, hafta sonları ve resmi tatiller hariç tutularak net izin günü hesaplanır. <br/>
**İzin Onaylama Ekranı** <br/>
Yöneticilerin bekleyen izin taleplerini görüntülediği  ve onaylama/reddetme işlemlerini yaptığı ekrandır. Onaylanan izinler personelin 14 gün izin hakkından otamatik düşülür. <br/>
**Maaş Hesaplama Ekranı** <br/>
Personel seçimi yapıldıktan sonra girilen brüt maaş, prim ve kesinti bilgileri ile net maaş hesaplanır ve personelin maaş bilgisi güncellenir. <br/>
**Departman Ekranı** <br/>
Şirketin organizasyon yapısını düzenler. Yeni departman ekler ve mevcut departmanları anlık olarak listeler. Projeyi bilgisayarınıza indirin. <br/>
**Personel Performans Ölçme Ekranı** <br/>
Yöneticilerin personellere puan verdiği ve yorum yaptığı ekrandır. Bu puanlar daha sonra maaş primi ve terfi süreçleri için raporlanabilir. <br/>
**Raporlama Ekranı** <br/>
Sistemdeki tüm verilerin (maaş ödemeleri, izin dökümleri, performans puanları, departman dağılımı) toplu olarak incelenebildiği ekrandır. Bu verilerin raporları çıkartılır. <br/>
## Kullanım
1. Projeyi bilgisayarınıza indirin. <br/>
2. Visual Studio ile projeyi açın. <br/>
3. MySQL veritabanı bağlantı ayarlarını VeriTabani.cs dosyasından düzenleyin. <br/>
4. Uygulamayı çalıştırın. <br/>
5. Giriş ekranından kullanıcı bilgileriyle sisteme giriş yapın.
## Proje Yapısı 
**- DAL (Data Access Layer):** Veritabanı işlemleri. <br/>
**- BLL (Business Logic Layer):** İş kuralları ve hesaplamalar. <br/>
**- UI (User Interface):** Windows Forms arayüzleri. <br/>
**- MySQL:** Veritabanı yönetimi. <br/>
## Proje Hedefleri 
**-** Personel yönetim süreçlerini dijitalleştirmek. <br/>
**-** Rol bazlı güvenli erişim sağlamak. <br/>
**-** Kullanıcı dostu ve sade bir arayüz sunmak. <br/>
**-** İş süreçlerini daha hızlı ve düzenli hale getirme
## İletişim
Herhangi bir sorunuz veya öneriniz varsa lütfen benimle iletişime geçin: <br/>
**- Ad:** Meryem <br/>
**- Soyad:** Çelik <br/>
**- Tel no:** +90 1111111111 <br/>
**- E-posta:** meryemcelik@gmail.com
## Youtube Video
Youtube proje tanıtım videosu izlemek için (https://youtu.be/NRq-6DgitbM?si=k978JUulhNZEe8CX)









