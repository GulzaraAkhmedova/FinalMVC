using Microsoft.AspNetCore.Mvc;

namespace FinallyMVC.WebUI.Areas.Admin.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
