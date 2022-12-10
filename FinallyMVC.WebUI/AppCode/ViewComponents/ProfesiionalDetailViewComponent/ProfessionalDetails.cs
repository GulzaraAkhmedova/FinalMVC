using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.AppCode.ViewComponents
{
    public class ProfessionalDetails : ViewComponent
    {
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View();
        }
        
    }
}
