using Abp.AspNetCore.Mvc.ViewComponents;

namespace Eblcu.Bi.Web.Public.Views
{
    public abstract class BiViewComponent : AbpViewComponent
    {
        protected BiViewComponent()
        {
            LocalizationSourceName = BiConsts.LocalizationSourceName;
        }
    }
}