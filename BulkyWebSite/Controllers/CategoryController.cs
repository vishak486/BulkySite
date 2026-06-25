using Microsoft.AspNetCore.Mvc;

namespace BulkyWebSite.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
