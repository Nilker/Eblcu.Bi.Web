using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eblcu.Bi.Web.Areas.AppAreaName.Models.Layout;
using Eblcu.Bi.Web.Session;
using Eblcu.Bi.Web.Views;

namespace Eblcu.Bi.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameFooter
{
    public class AppAreaNameFooterViewComponent : BiViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
