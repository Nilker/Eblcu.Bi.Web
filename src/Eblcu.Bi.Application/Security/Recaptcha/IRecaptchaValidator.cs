using System.Threading.Tasks;

namespace Eblcu.Bi.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}