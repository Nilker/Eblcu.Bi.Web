using System.Threading.Tasks;

namespace Eblcu.Bi.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
