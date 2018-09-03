using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Eblcu.Bi
{
    public class BiClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BiClientModule).GetAssembly());
        }
    }
}
