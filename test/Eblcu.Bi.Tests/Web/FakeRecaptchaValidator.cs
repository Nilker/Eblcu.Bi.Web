using System.Threading.Tasks;
using Eblcu.Bi.Security.Recaptcha;

namespace Eblcu.Bi.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
