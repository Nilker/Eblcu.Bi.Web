﻿using System.Threading.Tasks;
using Abp.Domain.Services;

namespace Eblcu.Bi.Authorization.Impersonation
{
    public interface IImpersonationManager : IDomainService
    {
        Task<UserAndIdentity> GetImpersonatedUserAndIdentity(string impersonationToken);

        Task<string> GetImpoersonateToken(long userId, int? tenantId);

        Task<string> GetBackToImpersonatorToken();
    }
}