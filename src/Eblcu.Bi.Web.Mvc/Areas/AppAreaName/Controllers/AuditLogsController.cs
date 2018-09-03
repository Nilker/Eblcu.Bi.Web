using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using Eblcu.Bi.Authorization;
using Eblcu.Bi.Web.Controllers;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : BiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}