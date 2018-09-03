using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Eblcu.Bi.Web.Views
{
    public abstract class BiRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BiRazorPage()
        {
            LocalizationSourceName = BiConsts.LocalizationSourceName;
        }
    }
}
