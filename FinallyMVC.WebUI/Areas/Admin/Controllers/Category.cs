using Microsoft.AspNetCore.Mvc;

namespace FinallyMVC.WebUI.Areas.Admin.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
