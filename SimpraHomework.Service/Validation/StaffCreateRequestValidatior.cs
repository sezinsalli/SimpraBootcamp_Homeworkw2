using FluentValidation;
using Simpra_Homework_Core.RequestResponseModel.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Service.Validation
{
    public class StaffCreateRequestValidatior : AbstractValidator<StaffCreateRequest>
    {
        public StaffCreateRequestValidatior()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("{FirstName} is required").NotEmpty().WithMessage("{FirstName} is required");
            RuleFor(x => x.LastName).NotNull().WithMessage("{LastName} is required").NotEmpty().WithMessage("{LastName} is required");

        }
    }
}
