using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Eblcu.Bi.Web.Controllers
{
    public class HomeController : BiControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
