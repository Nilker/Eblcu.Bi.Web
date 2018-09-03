using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Eblcu.Bi
{
    [DependsOn(typeof(BiXamarinSharedModule))]
    public class BiXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BiXamarinAndroidModule).GetAssembly());
        }
    }
}