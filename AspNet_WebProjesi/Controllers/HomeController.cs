using Microsoft.AspNetCore.Mvc;

namespace AspNet_WebProjesi.Controllers
{
    public class HomeController : Controller
    {
        // Bir Class'ın Controller olarak çalışması için yani gelen requestleri karşılayabilmesi için mutlaka Controller sınıfından türemesi gerekir.

        // Action dediğimizde Controller içindeki metotlar olarak bileceğiz.
        //

        public string Index()
        { 
            return "merhaba burası HomeController içindeki Index Metodu.."; 
        }

        //domainAdi/controller/action
        //https//localhost:7126/home/merhaba

        public string Merhaba()
        {
            return "Merhaba Network akademi";
        }
  
    }
}
