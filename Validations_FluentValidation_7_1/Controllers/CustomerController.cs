using Microsoft.AspNetCore.Mvc;
using Validations_FluentValidation_7_1.Models;

namespace Validations_FluentValidation_7_1.Controllers
{
    public class CustomerController : Controller
    {
        //Fluent validation küyüphanesi kullanarak validation işlemlerini yapıyoruz.
        // ManageNuget Package'tan FluentValidation.AspNetCore isimli kütüphaneyi yüklüyoruz.
        // Bu servisi projeme dahil etmem gerekiyor. Bunun için de Program.cs dosyasına gidip ilgili satıra ilgili servisi eklememiz gerekiyor.


        // Eğer Client validation yapcak isek, ilgili paketleri öncelikle yüklememiz gerekiyor.
        // 3tane paketi yüklememiz gerekecek. Fakat bunun için öncelikle wwwroot isimli klasörü eklememiz gerekeccek.
        // wwwroot özel bir klasördür.// css, js, images gibi dosyaları barındırdığımız yer.. Bu klasörü kullanabilmemiz iin app.UseStaticFiles(); middleware'nin ekli olması gerekiyor Program.cs içinde
        // yüklememiz gerekn paketler sırasıyla: , jquery, jquery-validate, j-query-validation-unobtrusive kütüphanelerini yüklememiz gerekiyor.
        // daha sonra bu kütüphaneleri view de kullanacaksak oraya eklememiz gerekiyor.
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateCustomer() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            if (ModelState.IsValid) 
            {
                // Doğrulama sağlandıysa buradaki kodlar çalışacak.
                return View("CreateSuccess");
            }
            else
            {
                // Veriler doğrulanamadıysa buradaki kodlar çalışacak.
                return View(customer);
            }
            
        }
    }
}
