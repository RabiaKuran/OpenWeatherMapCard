# OpenWeatherMapCard

![image](https://github.com/RabiaKuran/OpenWeatherMapCard/assets/59939284/16597f80-45a2-470d-8dc9-84e043084448)

Proje Açıklaması
Bu projede, C# kullanarak OpenWeatherMap API'sini entegre ederek hava durumu verilerini çekip görsel bir hava durumu kartı oluşturdum. Kod şu adımları gerçekleştiriyor:

Form Yüklenirken: Form yüklendiğinde mevcut tarihi alıyor (DateTime.Now.ToShortDateString() ile) ve bu tarihi bir etikete yazdırıyor.

API Anahtarını ve Bağlantıyı Oluşturma: OpenWeatherMap API anahtarını (api) ve hava durumu verilerini çekeceğimiz şehri (İstanbul) belirterek bir bağlantı oluşturuyor.

API ile Veri Çekme: Belirtilen bağlantı aracılığıyla XML formatında hava durumu verilerini API'den çekiyor (XDocument.Load(connection) ile).

Gerekli Verileri Alma: XML'den çekilen veriler arasında sıcaklık (temp), rüzgar hızı (wind), nem (humidity) ve hava durumu durumu (weathr) gibi özellikleri alıyor.

Etiketlere Verileri Yazdırma: Bu verileri uygun etiketlere yazdırıyor.

Hava Durumu Durumuna Göre İlgili Görseli Gösterme: Hava durumu durumuna göre (weathr), uygun görseli (pictureBox1) yükleyerek gösteriyor. Örneğin, "açık" durumu için güneşli bir görsel, "bulutlu" için bulutlu bir görsel vb.

Kullanım
Projeyi kullanmak için:

Bu projeyi klonlayın veya indirin.
OpenWeatherMap API anahtarınıza erişin ve Form1.cs dosyasındaki api değişkenine API anahtarınızı ekleyin.
Visual Studio veya benzeri bir C# IDE'sinde proje dosyasını açın.
Projeyi derleyin ve çalıştırın.
Form üzerinde, mevcut tarih, sıcaklık, rüzgar hızı, nem ve hava durumu durumu görüntülenecektir.
Kod İçeriği
Form1.cs dosyasındaki Form1_Load metodunda yapılan adımlar şunlardır:

Tarih etiketine mevcut tarihi yazdırma.
OpenWeatherMap API'sini kullanarak Istanbul'daki hava durumu verilerini çekme.
XML verilerinden sıcaklık, rüzgar hızı, nem ve hava durumu durumunu alıp ilgili etiketlere yazdırma.
Hava durumu durumuna göre uygun görseli gösterme.
Notlar
Projeyi kullanmadan önce API anahtarınızı api değişkenine eklemeyi unutmayın.
Görsellerin dosya yolları yerel bilgisayarınıza göre belirtilmiş, kendi dosya yollarınıza göre güncellemeyi unutmayın.
