using Microsoft.AspNetCore.Mvc;
using Session_Kullanimi_11.Models;
using System.Text.Json;

namespace Session_Kullanimi_11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Session= Oturum demek.
            // Session server'da çalışan bir yapı. Bir veriyi Session'da saklamak istediğimizde, Bu veri server tarafında saklanıyor.
            //syntax:
            //HttpContext.Session.SetString(key, veri); Session'a veri ekleme
            //HttpContext.Session.GetString(key); Veri okuma

            //string veriyi sessiona ekleme 
            HttpContext.Session.SetString("user", "Eren Dönmez");
            // Sayısal Veriyi sessiona ekleme
            HttpContext.Session.SetInt32("yas", 58);
            // Nesneleri session'a ekleme Listt<T>, kendi oluşturduğumuz sınıflar olabilir.
            Product product = new Product()
            {
                Id = 1,
                Name = "Kırmızı kalem",
                Description = "çok güzel bir kırmızı kalem",
            };
            //Bir nesneyi Session'a koymal istiyorsak öncellikle Json'a çevirmemiz gerekecek.
            string jsonUrun = JsonSerializer.Serialize(product);
            // Json string türünde olduğu için rahatlıkla Session'a ekleyebiliriz.
            HttpContext.Session.SetString("urun", jsonUrun);
            //product türünde bir listi session'a koyalım.
            List<Product> urunler = new List<Product>()
            {
                new Product(){Id = 1,Name = "Kırmızı kalem",Description = "çok güzel bir kırmızı kalem" },
                new Product(){Id = 1,Name = "Mavi kalem",Description = "çok güzel bir Mavi kalem" },
                new Product(){Id = 1,Name = "Yeşil kalem",Description = "çok güzel bir Yeşil kalem" },
            };
            string jsonUrunler = JsonSerializer.Serialize(urunler);
            HttpContext.Session.SetString("urunler", jsonUrunler);

            return View();
        }

        public string SessionVerisiGor()
        {
            //String veriyi sessiondan okuma
            var sess = HttpContext.Session.GetString("user");
            return sess;
        }

        public int YasBilgisiGor()
        {
            //Sayısal veriyi sessiondan okuma
            int sess = HttpContext.Session.GetInt32("yas").Value;
            return sess*2;
        }
        public string SessiondanUrunAl()
        {
            // Nesne turunde bir veriyi Sessiondan alamk istediğimde.
            string sess = HttpContext.Session.GetString("urun");
            Product product = JsonSerializer.Deserialize<Product>(sess);

            string sonuc = $"Id: {product.Id} - Name : {product.Name} Açıklama : {product.Description}";
            return sonuc;
        }
        public IActionResult UrunleriGetir()
        {
            return View();
        }
    }
}
