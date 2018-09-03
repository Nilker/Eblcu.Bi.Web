using Microsoft.AspNetCore.Mvc;
using Eblcu.Bi.Web.Controllers;

namespace Eblcu.Bi.Web.Public.Controllers
{
    public class HomeController : BiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}