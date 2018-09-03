using Microsoft.Extensions.Configuration;

namespace Eblcu.Bi.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
