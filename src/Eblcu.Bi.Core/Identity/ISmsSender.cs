using System.Threading.Tasks;

namespace Eblcu.Bi.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}