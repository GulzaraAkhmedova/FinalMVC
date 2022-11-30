using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.AppCode.ViewComponents
{
    public class ProfessionalDetailsViewComponent : ViewComponent
    {
        public ProfessionalDetailsViewComponent()
        {

        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View();
        }
        
    }
}
