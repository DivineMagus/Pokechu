using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Auth.Command.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().MaximumLength(50).MinimumLength(5).WithName("Name Surname");

            RuleFor(x => x.Email).NotEmpty().MaximumLength(60).MinimumLength(8).EmailAddress().WithName("E-mail address");

            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).WithName("Password");

            RuleFor(x => x.ConfirmPassword).NotEmpty().MinimumLength(8).Equal(x => x.Password).WithName("Password Again");
        }
    }
}
