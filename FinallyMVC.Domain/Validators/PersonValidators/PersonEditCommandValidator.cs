using FinallyMVC.Domain.Business.PersonModule;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Validators.PersonValidators
{
    public class PersonEditCommandValidator :AbstractValidator<PersonEditCommand>
    {
        public PersonEditCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Bosh buraxila bilmez");
        }
    }
}
