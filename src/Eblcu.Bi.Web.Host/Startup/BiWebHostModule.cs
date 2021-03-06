﻿using ORS.AspNetZeroCore ;
using ORS.AspNetZeroCore .Web.Authentication.External;
//using ORS.AspNetZeroCore .Web.Authentication.External.Facebook;
//using ORS.AspNetZeroCore .Web.Authentication.External.Google;
//using ORS.AspNetZeroCore .Web.Authentication.External.Microsoft;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using Abp.Timing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Eblcu.Bi.Configuration;
using Eblcu.Bi.EntityFrameworkCore;
using Eblcu.Bi.MultiTenancy;

namespace Eblcu.Bi.Web.Startup
{
    [DependsOn(
        typeof(BiWebCoreModule)
    )]
    public class BiWebHostModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BiWebHostModule(
            IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebCommon().MultiTenancy.DomainFormat = _appConfiguration["App:ServerRootAddress"] ?? "http://localhost:22742/";
            //Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];

            //Configuration for all caches
            Configuration.Caching.ConfigureAll(cache =>
                {
                    cache.DefaultSlidingExpireTime = System.TimeSpan.FromSeconds(1);
                });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BiWebHostModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!DatabaseCheckHelper.Exist(_appConfiguration["ConnectionStrings:Default"]))
            {
                return;
            }

            if (IocManager.Resolve<IMultiTenancyConfig>().IsEnabled)
            {
                var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
                workManager.Add(IocManager.Resolve<SubscriptionExpirationCheckWorker>());
                workManager.Add(IocManager.Resolve<SubscriptionExpireEmailNotifierWorker>());
            }
            
            //ConfigureExternalAuthProviders();
        }

        //private void ConfigureExternalAuthProviders()
        //{
        //    var externalAuthConfiguration = IocManager.Resolve<ExternalAuthConfiguration>();

        //    if (bool.Parse(_appConfiguration["Authentication:Facebook:IsEnabled"]))
        //    {
        //        externalAuthConfiguration.Providers.Add(
        //            new ExternalLoginProviderInfo(
        //                FacebookAuthProviderApi.Name,
        //                _appConfiguration["Authentication:Facebook:AppId"],
        //                _appConfiguration["Authentication:Facebook:AppSecret"],
        //                typeof(FacebookAuthProviderApi)
        //            )
        //        );
        //    }

        //    if (bool.Parse(_appConfiguration["Authentication:Google:IsEnabled"]))
        //    {
        //        externalAuthConfiguration.Providers.Add(
        //            new ExternalLoginProviderInfo(
        //                GoogleAuthProviderApi.Name,
        //                _appConfiguration["Authentication:Google:ClientId"],
        //                _appConfiguration["Authentication:Google:ClientSecret"],
        //                typeof(GoogleAuthProviderApi)
        //            )
        //        );
        //    }

        //    //not implemented yet. Will be implemented with https://github.com/aspnetzero/aspnet-zero-angular/issues/5
        //    if (bool.Parse(_appConfiguration["Authentication:Microsoft:IsEnabled"]))
        //    {
        //        externalAuthConfiguration.Providers.Add(
        //            new ExternalLoginProviderInfo(
        //                MicrosoftAuthProviderApi.Name,
        //                _appConfiguration["Authentication:Microsoft:ConsumerKey"],
        //                _appConfiguration["Authentication:Microsoft:ConsumerSecret"],
        //                typeof(MicrosoftAuthProviderApi)
        //            )
        //        );
        //    }
        //}
    }
}
