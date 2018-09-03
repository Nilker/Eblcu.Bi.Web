using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Eblcu.Bi
{
    [DependsOn(typeof(BiClientModule), typeof(AbpAutoMapperModule))]
    public class BiXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BiXamarinSharedModule).GetAssembly());
        }
    }
}