using Microsoft.AspNetCore.Mvc;
using Uygulama_1.BusinessLayer;

namespace Uygulama_1.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _manager = new CategoryManager();

        [HttpGet]
        public IActionResult Index()
        {
            //Category Listele
            return View(_manager.GetAll());
        }
        [HttpPost]
        public IActionResult DeleteCategory(int id)
        {
            _manager.Delete(id);
            return RedirectToAction("index");
        }


    }
}
