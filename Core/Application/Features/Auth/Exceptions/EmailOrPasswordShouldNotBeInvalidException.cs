using Poke.Application.Bases;

namespace Poke.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException : BaseException
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Email or Password is Invalid") { }
    }
}
