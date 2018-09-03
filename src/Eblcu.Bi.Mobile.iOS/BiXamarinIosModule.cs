using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Eblcu.Bi
{
    [DependsOn(typeof(BiXamarinSharedModule))]
    public class BiXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BiXamarinIosModule).GetAssembly());
        }
    }
}