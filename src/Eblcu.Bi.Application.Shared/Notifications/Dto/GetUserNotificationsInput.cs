using Abp.Notifications;
using Eblcu.Bi.Dto;

namespace Eblcu.Bi.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}