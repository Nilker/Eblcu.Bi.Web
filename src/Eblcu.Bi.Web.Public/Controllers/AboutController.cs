using Microsoft.AspNetCore.Mvc;
using Eblcu.Bi.Web.Controllers;

namespace Eblcu.Bi.Web.Public.Controllers
{
    public class AboutController : BiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}