using FinallyMVC.Domain.Models.ViewModel;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.LoginValidation
{
    public class LoginEditCommand : AbstractValidator<LoginViewModel>
    {
        public LoginEditCommand()
        {
            RuleFor(l => l.UserName)
                .NotEmpty()
                .WithMessage("Username yanlishdir");

            RuleFor(l => l.Password)
                .NotEmpty()
                .WithMessage("password ve ya email sehvdi");
        }
    }
}
