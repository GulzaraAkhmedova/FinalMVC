using FinallyMVC.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;

namespace FinallyMVC.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext db;

        public BlogController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
