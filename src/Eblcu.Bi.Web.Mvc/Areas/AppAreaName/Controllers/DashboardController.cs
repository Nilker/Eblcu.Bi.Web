using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Eblcu.Bi.Authorization;
using Eblcu.Bi.Web.Controllers;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : BiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}