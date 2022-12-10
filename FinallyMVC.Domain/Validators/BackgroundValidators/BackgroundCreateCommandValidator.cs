using FinallyMVC.Domain.Business.BackgroundModule;
using FluentValidation;

namespace FinallyMVC.Domain.Validators.BackgroundValidator
{
    public class BackgroundCreateCommandValidator : AbstractValidator<BackgroundCreateCommand>
    {
        public BackgroundCreateCommandValidator()
        {
            RuleFor(c => c.Body)
                .NotEmpty()
                .WithMessage("Ad bosh buraxila bilmez");

            RuleFor(c => c.Profession)
                .NotEmpty()
                .WithMessage("ShortDescription bosh buraxila bilmez")
                .MaximumLength(250)
                .WithMessage("250 simvoldan cox ola bilmez");

            RuleFor(c => c.Date)
                .NotNull()
                .WithMessage("Marka secilmeyib");

            RuleFor(c => c.Place)
                .NotNull()
                .WithMessage("Kategoriya secilmeyib");
        }
    }
}
