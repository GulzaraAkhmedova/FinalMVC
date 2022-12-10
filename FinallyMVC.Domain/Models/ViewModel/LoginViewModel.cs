using System.ComponentModel.DataAnnotations;

namespace FinallyMVC.Domain.Models.ViewModel
{
    public class LoginViewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
