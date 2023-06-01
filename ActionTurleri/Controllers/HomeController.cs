using ActionTurleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActionTurleri.Controllers
{
    [NonController]
    public class HomeController : Controller
    {




        //Action Türleri
        // ACtion: gelen istekleri controller içinde karşılayan metotlardır.
        // Geri dönüş tipleri Base Class sayesinde bize sunuluyor..
        #region ViewResult
        //response olarak bir view dosyasını render etmemizi sağlayan geri dönüş tipidir(Action tipidir.). View cshtml türünde bir dosyadır.

        //public ViewResult Index()
        //{

        //    return View();
        //}

        #endregion

        #region PartialViewResult

        // bir View doosyasını render etmemizi sağlyan cshtml dosyasıdır.
        // PartiaViewResult View içindeki bir bölümü oluşturmak için kullanılır.
        // ViewResult'tan farkı, client tabanlı ajaxisteklerinde sıkça kullanılmasıdır. Burada sayfanın tamamı değil sadece ilgili partialView yenilenir/güncellenir.,

        //public PartialViewResult Index()
        //{
        //    return PartialView();
        //}
        #endregion

        #region JsonResult
        //üretilen veriyi Json formatına dönüştüren ve client'a gönderen yani response eden action türüdür. Yani elimizdeki veriyi Json formatına döndürür.

        //public JsonResult Index()
        //{
        //    JsonResult result = Json(new Product()
        //    {
        //        Id = 1,
        //        Name = "kirmizi Kalem",
        //        Price = 50,
        //    }) ;
        //    return result;
        //}

        #endregion

        #region EmptyResult



        //public EmptyResult UrunleriGetir()
        //{
        //    // Bazen gelen istekler doğrultusunda geriye birşey döndürmek istemeyebiliriz. Bu gibi durumlarda gelen isteği karşılamak için EmptyResult türünde bir Action kullanırız.
        //    // Gelen Request'e karşılık bir Response var ama Result yok.
        //    // void metotlar ile de aynı işi yapabiliriz.



        //    return new EmptyResult();
        //}
        #endregion

        #region ContentResult
        // Metinsel bir veri döndürmek isteniyorsa ContentResult türünde döndürülebilir.
        // Sonuç HTMl olarak gelmez. bir metinsel veri olarak gelir. Yani text olarak gelir.
        // Metinsel bir veriyi sayfayının bir bölümünde göstermek istersek bunu kullanabiliriz.


        //public ContentResult Index()
        //{
        //    ContentResult result = Content("Bugün Asp.Net Core MVC'de Action Türlerini öğreniyorum");
        //    return result;
        //}
        #endregion
        #region ActionResult
        // Bütün Result türlerinin atasıdır. Yani base Class'ıdır. Gelen bir istek neticesinde geriye döndürülecek action türleri değişkenlik gösterdiğinde kullanılabilir.
        //public ActionResult Index()
        //{
        //    // Gelen istek sonucunda bir takım işlemler yapılır if ile for ile falan sonrasında duruma göre geriye bir reault döndürülür (Json, Content, Empty, Partial vb...)
        //    if (true)
        //    {
        //        ContentResult result = Content("Bugün Asp.Net Core MVC'de Action Türlerini öğreniyorum..");
        //        return result;
        //    }
        //    else if (false)
        //    {
        //        return new EmptyResult();
        //    }
        //    else if (false)
        //    {
        //        JsonResult result = Json(new Product()
        //        {
        //            Id = 1,
        //            Name = "Kırmızı Kalem",
        //            Price = 50
        //        });
        //        return result;
        //    }
        //    return View();
        //}


        #endregion

        #region IActionResult
        // IActionResult ise ActionResult'un interface'idir.

        //public IActionResult Index()
        //{

        //    return View();
        //}
        #endregion

        #region NonAction
        // [NonAction] olarak işaretlenen bir metot artık action gibi istek alamayacaktır.
        // Bu metotları daha çok diğer actionlardan çağırarak bir iş yapması için oluştururuz.
        //[NonAction] olarak işaretlemezsek bu metot da bir action gibi çalışmaya devam edecektir.

        [NonAction]


        public string ActionDegil()
        {
            return "Burası action değil Metodu.";
        }
        #endregion

        #region [NonController]

        //[NonController]

        // Class sınıfında tanımlanır ve eğer kontrollerı devre dışı bırakmak istersek kullanırız


        #endregion
    }


}

