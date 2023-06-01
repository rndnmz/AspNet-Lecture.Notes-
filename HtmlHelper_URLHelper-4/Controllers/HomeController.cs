using Microsoft.AspNetCore.Mvc;

namespace HtmlHelper_URLHelper_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mesaj = "Merhaba NA-203 Sınıfı";
            return View();
        }
    }
}
