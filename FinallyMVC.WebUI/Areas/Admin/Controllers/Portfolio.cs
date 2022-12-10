using Microsoft.AspNetCore.Mvc;

namespace FinallyMVC.WebUI.Areas.Admin.Controllers
{
    public class Portfolio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
