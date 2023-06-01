using Data_Binding_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data_Binding_6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {

            // Update için: veritabanından ilgili product verisi alınıyr.
            // view: e güncellenemsi için gönderiliyor.
            Product product = new Product()
            {
                Id = 1,
                Name = "kırmızı kalem",
                Description = "asdasdasd",
                Quantity = 1,
                Price = 1,
            };



            return View(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            // kullanıcıdan alınan Product bilgileri ile ilgili yapılacak olan işler burada yönetilir.
            
            return View();

        }
    }
}
