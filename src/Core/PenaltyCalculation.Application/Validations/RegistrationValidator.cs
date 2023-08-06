using FluentValidation;
using PenaltyCalculation.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Application.Validations
{
    public class RegistrationValidator : AbstractValidator<CalculateViewModel>
    {
        public RegistrationValidator()
        {
            RuleFor(x => x.CheckedOut).NotEmpty().NotNull().LessThan(x => x.Returned).WithMessage("wrong DateTime entry");
        }
    }
}
