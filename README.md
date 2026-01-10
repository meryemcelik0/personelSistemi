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
<img width="737" height="505" alt="USE" src="https://github.com/user-attachments/assets/96ff2736-d179-43ee-aaa3-77a6eb9e3bf7" />

## Ekran Görüntüleri
**- Giriş Sayfası**  <br/>
<img width="376" height="493" alt="giriş" src="https://github.com/user-attachments/assets/ce7d09b7-e9eb-4b12-9c89-368a90aff769" />

Kullanıcı adı ve şifre ile sisteme giriş yapılır. Kullanıcının rolüne göre yetkili olduğu ekranlara yönlendirme yapılır. <br/>
**- Ana Ekran** <br/>
<img width="910" height="573" alt="ana ekran" src="https://github.com/user-attachments/assets/8048bf26-a15e-495c-b9b8-2b374e62b799" />

Personel, departman, izin, maaş ve rapor işlemlerinin yönetildiği ana ekrandır. bu işlemlerin butonlarına basılarak asıl ekranlara gidilir. Rol bazlı buton görünürlüğü uygulanmıştır. <br/>
**- İzin Talep Ekranı** <br/>
<img width="527" height="308" alt="talep" src="https://github.com/user-attachments/assets/42da5e45-d663-4c1a-a2fa-43c9366c2ba9" />

Personellerin yıllık, sağlık ve mazeret izinleri için başvuru yaptığı ekrandır. Başlangıç ve bitiş taihleri seçildiğinde, hafta sonları ve resmi tatiller hariç tutularak net izin günü hesaplanır. <br/>
**- İzin Onaylama Ekranı** <br/>
<img width="677" height="492" alt="onay" src="https://github.com/user-attachments/assets/7fb5c1c6-62de-41df-b333-4a0d473b1836" />

Yöneticilerin bekleyen izin taleplerini görüntülediği  ve onaylama/reddetme işlemlerini yaptığı ekrandır. Onaylanan izinler personelin 14 gün izin hakkından otamatik düşülür. <br/>
**- Maaş Hesaplama Ekranı** <br/>
<img width="473" height="489" alt="maaş" src="https://github.com/user-attachments/assets/c332ec6f-4c6f-4b43-85f4-69cec2736c6c" />

Personel seçimi yapıldıktan sonra girilen brüt maaş, prim ve kesinti bilgileri ile net maaş hesaplanır ve personelin maaş bilgisi güncellenir. <br/>
**- Departman Ekranı** <br/>
<img width="912" height="491" alt="departman" src="https://github.com/user-attachments/assets/610acb45-3b74-4820-814b-491d8c5baeb8" />

Şirketin organizasyon yapısını düzenler. Yeni departman ekler ve mevcut departmanları anlık olarak listeler. Projeyi bilgisayarınıza indirin. <br/>
**- Personel Performans Ölçme Ekranı** <br/>
<img width="794" height="426" alt="performans" src="https://github.com/user-attachments/assets/20d262a3-ac27-4f04-af8d-cb68e5435038" />

Yöneticilerin personellere puan verdiği ve yorum yaptığı ekrandır. Bu puanlar daha sonra maaş primi ve terfi süreçleri için raporlanabilir. <br/>
**- Raporlama Ekranı** <br/>
<img width="914" height="486" alt="rapor" src="https://github.com/user-attachments/assets/c339f7b2-2bb5-4417-b545-e3b623a8949a" />

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









