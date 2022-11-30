using FinallyMVC.Domain.Business.PersonModule;
using FinallyMVC.Domain.Models.DataContexts;
using FinallyMVC.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        private readonly IMediator mediator;

        public HomeController(AppDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(PersonAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }

        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(model);
                db.SaveChanges();

                var response = new
                {
                    error = false,
                    message = "Muracietiniz qeyde alindi. Tezlikle geri donush edilecek."
                };
                return Json(response);
            }

            var responseError = new
            {
                error = true,
                message = "Melumatlar uygun deyil. Duzelish edib yeniden yoxlayin",
                //state = ModelState.GetError()
            };

            return Json(responseError);
        }

    }

}


