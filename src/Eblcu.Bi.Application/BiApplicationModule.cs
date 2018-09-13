using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Eblcu.Bi.Authorization;
using Eblcu.Bi.Student.Dtos.CustomMapper;
using Eblcu.Bi.StudentPermissions;
using Eblcu.Bi.Test.Authorization;
using Eblcu.Bi.Test.Mapper;

namespace Eblcu.Bi
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(BiCoreModule)
        )]
    public class BiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();
            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);



            Configuration.Authorization.Providers.Add<EnrollRecruitAppAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<StudentManageAppAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<StudentPayAppAuthorizationProvider>();



            Configuration.Authorization.Providers.Add<ProductAuthorizationProvider>();


            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                CustomDtoMapper.CreateMappings(configuration);

                Customercharge_studentsdataMapper.CreateMappings(configuration);
                Customerdrop_out_studentsdataMapper.CreateMappings(configuration);
                Customerentry_recruit_studentsdataMapper.CreateMappings(configuration);
                Customergraduate_studentsdataMapper.CreateMappings(configuration);
                Customernograduate_studentsdataMapper.CreateMappings(configuration);
                Customerzhx_student_inreadingMapper.CreateMappings(configuration);


                ProductMapper.CreateMappings(configuration);
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BiApplicationModule).GetAssembly());
        }
    }
}