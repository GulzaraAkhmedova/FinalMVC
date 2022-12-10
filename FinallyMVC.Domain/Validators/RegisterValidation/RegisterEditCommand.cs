using FinallyMVC.Domain.Models.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Validators.RegisterValidation
{
    public class RegisterEditCommand : AbstractValidator<RegisterViewModel>
    {
        public RegisterEditCommand()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("Ad bosh ola bilmez");

            RuleFor(r => r.Surname)
                .NotEmpty()
                .WithMessage("Surname bosh ola bilmez");


            RuleFor(r => r.Email)
                .NotEmpty()
                .WithMessage("Email adi qeyd olunmayib");

            RuleFor(r => r.Password)
                .NotEmpty()
                .WithMessage("Password 8 simvoldan az ola bilmez");

            RuleFor(r => r.ConfirmPassword)
                .NotEmpty()
                .WithMessage("Pasword tesdiqlenmeyib");
        }
    }
}
