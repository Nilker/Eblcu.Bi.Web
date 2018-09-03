using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Eblcu.Bi.Web.Controllers;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize]
    public class WelcomeController : BiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}