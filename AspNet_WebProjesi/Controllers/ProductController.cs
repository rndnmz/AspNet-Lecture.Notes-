using Microsoft.AspNetCore.Mvc;

namespace AspNet_WebProjesi.Controllers
{
    public class ProductController : Controller
    {
        public string Urunler()
        {
            return "bütün ürünler listelendi.... Product/Urunler";
        }
        public string Index()
        {
            return "Ürünler anasayfası... Product/Index";
        }

        // tarayıcadki linke verdiğimiz parametre/ veri'yi alabilmek için oradaki değişken ile buradaki action'daki parametre adının aynı olması gerekir
        // pattern:"{controller=Home}/{action=Index}/{id?}"
        //public string UrunGetir(int id)
        //https//localhost:7126/product/urungetir/2 şeklinde parametreyi ilgili actiona gönderebildiğim gibi
        //https://localhost:7126/product/urungetir/2 şeklide bir link kullanarak da parametreyi ilgili action'a gönderebilirim.
        //domain/controller/action/parametre
        //domain/controller/action?id=2



        public string UrunGetir(int id)
        {
            return $"{id} no'lu ürün listelendi...";
        }
        // domain/product/deneme?isim=Eren
        public string Deneme(string isim)
        {
            return $"Benim adım {isim}.";
        }
        public string Test(string isim, int yas)
        {
            return $"Benim adım {isim}, yaşım {yas}.";
        }
    }
}
