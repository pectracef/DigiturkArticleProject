# DigiturkArticleProject

## Bağımlılıklar
* .net Core 3.1
## Kurulum
* Projeyi indirip **Visual Studio** içinde açın (*Ben Visual Studio 2019 kullandım*).
* **DigiturkArticleProject.API** projesi içinde appsettings.json içinden connection stringinizi kendinize göre değiştirebilirsiniz. Varsayılan olarak localhost ve windows authentication olarak ayarlı.
* **Package Manager Console** konsolunu açın varsayılan proje olarak **DigiturkArticleProject.Data.Context** projesini seçin veya projeye sağ tıklayıp *Set as StartUp Project* seçeneğine tıklayın. 
* Konsolu açtıktan sonra, *update-database* komutunu çalıştırın.
* Proje dosyaları içinde **installition.sql** dosyasını, SSMS içinde açarak veritabanınızın oluşturulduğu sunucu içinde bu kodları çalıştırın.
* Visual Studio ya geri dönüp projeyi başlatabilirsiniz.
## Sorular
* ### Projede kullanıdığınız tasarım desenleri hangileridir? Bu desenleri neden kullandınız?
  * Repository
  * Dependency Injection
  
  Tasarım desenleri bizlere daha yönetilebilir ve okunabilir kod yazmak konusunda avantajlar sağlar. Bunun yanında performans ve geliştirilebilirlik konusunda da katkıları vardır. Repository, veritabanı sorumluluğunu üstlenen sınıfı tasarlarken bir standart üzerine oturtmayı hedefleyen ve ORM araçlarıyla birlikte sorgusal anlamda az sayıda metotla yüksek seviyede veri erişim imkanı sağlayan bir tasarım desenidir. Ben de uygulama içerisinde EntityFrameworkCore ORM aracını kullandığım için böyle bir yapıya ihtiyaç duydum.
  Dependency Injection da aslında, bağımlılık yaratacak parçaları ayrıştırıp, bunların dışarıdan verilip bağımlılığı minimize etme işlemidir. bkz. [Loosely Coupled](https://en.wikipedia.org/wiki/Loose_coupling)
  
* ### Kullandığınız teknoloji ve kütüphaneler hakkında daha önce tecrübeniz oldu mu? Tek tek yazabilir misiniz?
  Evet, daha önce bu teknolojilerle çalıştım.
  * .net Core 2.0 ve üzeri
  * EntityFrameworkCore 2.0 ve üzeri
  * Newtonsoft.JSON
  * MSSQL
  * CodeFirst
  * MVC
  * Daha önceki tecrübelerimde de farklı teknolojiler ve kütüphaneleri kullandım

* ### Daha geniş vaktiniz olsaydı projeye neler eklemek isterdiniz?
  * Makaleler için Etiket ve Kategori yapısının oluşturulması.
  * Kullanıcı bilgilerinin, kullanıcılardan daha detaylı istenmesi. Bu bilgilerin veritabanı içerisine eklenmesi.
  * Makalelere görsel eklenebilme olanağının sağlanması.
  * Kullanıcıdan mail bilgisi istenerek kullanıcıyı mail vasıtasıyla bildirim gönderme örn: "Yeni bir makale yayınlandı bunu okumalısın :)" tarzında yada farklı bildirimler. Akabinde KVKK onayı alarak mail adresinin doğrulanmasını sağlama.
  * Sosyal Ağlar aracılığı ile üyelik işlemlerinin tamamlanması.
  * Yorumlarda recursive yapı oluşturulması. Tabanı hazır fakat sadece 2 kırılıma izin verilebilir ilk aşamada.
  * Makalelerin kaç kişi tarafından okunduğu bilgisinin eklenmesi.
  * Daha ileriki versiyonlarda makaleler için CMS yapısı oluşturulması olabilir. Sağda resim solda yazı, video ekleme, fotoğraf galerisi, hero slider vb. yapılar ile makalelerin oluşturulması.
  
* ### Eklemek istediğiniz bir yorumunuz var mı?
  İşe alım süreçlerinin proje üzerinden değerlendirilmesi, kendimi sizlere daha net ifade etmemi sağladı. Bu olanağı bana sağladığınız için teşekkür ederim.
