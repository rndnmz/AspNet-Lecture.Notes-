using Microsoft.AspNetCore.Mvc;
using Validations_GelenVerilerinDogrulanması_7.Models;

namespace Validations_GelenVerilerinDogrulanması_7.Controllers
{
    public class CustomerController : Controller
    {
        // Validation işlemleri
        // Validation : Veri Doğrulama: Örneğin kullanıcıdan alınan email bilgisinin email formatında olup olmadığını kontrol etmemiz gerekir. Yine kimlik numarası bilgisini aldığımızda bunun 11 karakter olup olmadığını kontrol etmeliyiz. 10 yada 15 krakter olmamalı. Ürün ismi girildiğinde en az 2 enfazla 25 olması gerekiyorsa bunun da kontrolü yapılmalı. Ya da zorunlu bir alana veri girilip girilmediğinin kontrolü yapılmalıdır.
        // 2 türlü Validation yapılır: 1 - server side validation(server tabanlı) , 2 - Client Side Validation(Client tabanlı)

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
            //Controller tarafında validation işlemi yapabilmemiz için ModelState dediğimiz yapıyı kullanıyoruz.
            // ModelState: Veri Tutan bir tippin (product,Customer gibi) property'lerine ait Data Annotation'larının durumunu kontrol eden ve geriye bir sonuç döndüren yapıdır ya da property'dir.
            // Kısacası girilen verilerin Data Annotationlar ile belirlediğimiz kurallar çerçevesinde kontrolünü yapıyor ve sonucu bize döndürüyor. Bunu arka planda otomatik olarak yapıyor.
            // 
            if (ModelState.IsValid) 
            {
                //Girilen veriler validationdan geçmiştir. yapılacak olan işlemler burada yapılır ( kaydetme Güncelleme, vb...). 
                return View("CreatedSuccess");
            }
            else
            {
                //

            }
            return View();
        }
        public IActionResult CreatedSuccess()
        {
            return View();
        }
    }
}
