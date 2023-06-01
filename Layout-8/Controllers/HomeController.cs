using Microsoft.AspNetCore.Mvc;

namespace Layout_8.Controllers
{
    public class HomeController : Controller
    {
        // Layout: her bir sayfada değişkenlik göstermeyen yapıları (örn; navbar, footer, menu gibi) tasarladığımız sayfalardır.
        // Bir websitesinde layout yoksa hher sayfada bazı alanları tekrar tekrar yazmak durumunda kalacağız. Bu da yönetim açısından developer'lara cidi iş yükü getirecektir. Örneğin navbarda kullandığımız şirketn logosu değiştirince her sayfada bunu değiştirmek zorunda kalacağım gibi.. 
        // Layout dediğimiz sayfada özünde bir View'dir ve bir cshtml dosyasıdır.
        // View içerisinde herhangibir yerde oluşturabiliriz Fakat genel olarak Views klasörü altında Shared diye bir klasör oluştururuz ve burada konumlandırırız. 
        // ** Views/Shared/_Layout.cshtml
        // Değişmeyen kodlarımız bu sayfada yazarız. Değişen kodlarımızı da nerede göstermek istiyorsak o bölümde RenderBody dediğimiz metot ile ilgili yere render edilmesini/yerleştirilmesini sağlarız.
        // Değişen sayfalarda da yazmamız gerekn kod ise aşağıdaki gibidir:
        /*
          @{Layout = "~/Views/Shared/_Layout.cshtml";}
         */
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Page1()
        {
            return View();
        }
        public IActionResult Page2()
        {
            return View();
        }
        public IActionResult Page3()
        {
            return View();
        }


    }
}
