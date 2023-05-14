using FluentValidation;
using Simpra_Homework_Core.RequestResponseModel.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Service.Validation
{
    internal class StaffUpdateRequestValidator:AbstractValidator<StaffUpdateRequest>
    {
        public StaffUpdateRequestValidator()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("{FirstName} is required").NotEmpty().WithMessage("{FirstName} is required");
            RuleFor(x => x.LastName).NotNull().WithMessage("{LastName} is required").NotEmpty().WithMessage("{LastName} is required");
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("{StaffId} must be greater than 0");
        }
    }
}
