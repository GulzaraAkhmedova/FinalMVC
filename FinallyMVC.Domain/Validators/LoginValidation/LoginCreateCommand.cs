using FinallyMVC.Domain.Models.ViewModel;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.LoginValidation
{
    public class LoginCreateCommand : AbstractValidator<LoginViewModel>
    {
        public LoginCreateCommand()
        {
            RuleFor(l => l.UserName)
                .NotEmpty()
                .WithMessage("Username bosh buraxila bilmez");

            RuleFor(l => l.Password)
                .NotEmpty()
                .WithMessage("password 8 simvoldan az ola bilmez");

        }
    }
}