using Microsoft.AspNetCore.Mvc;
using Viewe_Veri_Gonderme.Models;

namespace Viewe_Veri_Gonderme.Controllers
{
    public class ProductController : Controller
    {
        // Verileri Controller'dan Viev'e taşımakk için 6yol var.
        // ViewDath, ViewBag, TempData,model,Tuple,modelview

        #region model ile View'e veri taşıma

        public IActionResult VeriTasiModel()
        {
            Product urun = new Product()
            {
                Id = 1,
                UrunAdi = "Kirmizi Kalem",
                Adet = 10,
                Fiyat = 50
            };





            // yukarıda yaratmış olduğum Product türündeki verimi View'e taşımak için burada yapacağım iş aşağıdaki View'e parametre olarak bu nesneyi vermem gerekir.




            return View(urun);
        }



        #endregion


        #region Ornek

        // Product türünde dört beş tane nesnem var bu bilgileri view e taşımak istiyorum...
        // Nasıl Taşırım?


        public IActionResult Ornek()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {  Id= 1,
                UrunAdi= "Kirmizi Kalem",
                Adet = 10,
                Fiyat = 50},
                new Product()
                {  Id= 2,
                UrunAdi= "a Kalem",
                Adet = 10,
                Fiyat = 50},
                new Product()
                {  Id= 3,
                UrunAdi= "b Kalem",
                Adet = 10,
                Fiyat = 50},
                new Product()
                {  Id= 4,
                UrunAdi= "c Kalem",
                Adet = 10,
                Fiyat = 50},
                new Product()
                {  Id= 5,
                UrunAdi= "d Kalem",
                Adet = 10,
                Fiyat = 50}

            };

            return View(products);
        }






        #endregion

        #region ViewData ile View'e veri gönderme
        public IActionResult OrnekViewData()
        {
            string ad = "ahmet";
            ViewData["isim"] = ad;
            ViewData["soyisim"] = "Yıldız";

            

            return View();
        }
        #endregion

        #region ViewBag ile veri taşıma

        public IActionResult OrnekViewBag()
        {
            string ad = "ahmet";
            ViewBag.isim = ad;
            ViewBag.sirket = "ABC Şirketi";



            return View();
        }


        #endregion

        #region TempData Kullanımı
        // TempData[key] = veri

        public IActionResult OrnekTempData()
        {
            string sirket = "Network Akademi";
            TempData["sirket"] = sirket;
            TempData["isim"] = "Mustafa";
            TempData["tur"] = "Veriler TempData ile taşındı";




            return View();
        }


        #endregion


        #region TempData ile ViewData ve ViewBag arasındaki Fark Nedir





        public IActionResult OrnekTempData1()
        {
            /// kodlar yazıldı ve çalıştırıldı..
            /// daha sonra geriye bir View döndürmüyorum.
            /// kısacası bu action'ı kullanan, sonrasında mutlaka detay actionını da kullanacak.
            /// tempdata oluşturdum..
            string sirket = "network akademi";
            TempData["sirket"]=sirket;
            TempData["isim"]="Mustafa";
            TempData["tur"]="Veriler Tempdata ile oluşturuldu";
            ViewBag.yas="12";
            ViewData["sirket"]="İstanbul";

            return RedirectToAction("Detay");

        }

        public IActionResult Detay()
        {
            /// OrnekTempData1 içindeki kodlar çalıştıktan sonra bu action'a yönlendirildiği için,

            return View();
        }




        #endregion
        #region Tuple iile nesne gönderimi


        public IActionResult VeriGonderTuple()
        {
            Product urun = new Product()
            {
                Id = 1,
                UrunAdi = "Kirmizi Kalem",
                Adet = 10,
                Fiyat = 50
            };

            User user = new User() { Id = 2,
            UserName="rndnmz"};
            var urunUser =(urun,user);
            


            return View(urunUser);
        }
        #endregion

        #region ViewModel ile veri taşıma 
        // en az 2 tane nesneyi View'e taşımak istiyorsan viewModel ile verilerimizi taşıyabiliriz.
        // ViewModel aslında bir class..
        // Bu Class'ın içinde taşımak istediğimiz verileri tanımlıyoruz..
        public IActionResult VeriTasiViewModel() 
        {
            Product urun = new Product()
            {
                Id = 1,
                UrunAdi = "Kirmizi Kalem",
                Adet = 10,
                Fiyat = 50
            };

            User user = new User()
            {
                Id = 2,
                UserName = "rndnmz"
            };
            
            UserProductViewModel viewModel = new UserProductViewModel();
            viewModel.Product = urun;
            viewModel.User = user;



            return View(viewModel);
        }
        #endregion

        public IActionResult Index()
        {
            return View("Deneme");
        }


    }

}









