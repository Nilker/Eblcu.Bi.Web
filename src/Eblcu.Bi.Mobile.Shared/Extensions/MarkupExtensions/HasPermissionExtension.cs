using System;
using Eblcu.Bi.Core;
using Eblcu.Bi.Core.Dependency;
using Eblcu.Bi.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eblcu.Bi.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}