using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Eblcu.Bi.Authorization.Users;
using Eblcu.Bi.MultiTenancy;

namespace Eblcu.Bi.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
