﻿using Abp;
using Abp.Dependency;
using Abp.Web.Models.AbpUserConfiguration;
using JetBrains.Annotations;
using Eblcu.Bi.Sessions.Dto;

namespace Eblcu.Bi.ApiClient
{
    public class ApplicationContext : IApplicationContext, ISingletonDependency
    {
        public TenantInformation CurrentTenant { get; private set; }

        public AbpUserConfigurationDto Configuration { get; set; }

        public GetCurrentLoginInformationsOutput LoginInfo { get; set; }

        public void SetAsTenant([NotNull] string tenancyName, int tenantId)
        {
            Check.NotNull(tenancyName, nameof(tenancyName));

            CurrentTenant = new TenantInformation(tenancyName, tenantId);
        }

        public void SetAsHost()
        {
            CurrentTenant = null;
        }
    }
}