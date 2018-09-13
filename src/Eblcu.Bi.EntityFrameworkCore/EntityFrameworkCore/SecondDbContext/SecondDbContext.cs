using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.IdentityServer4;
using Abp.Zero.EntityFrameworkCore;
using Eblcu.Bi.Authorization.Roles;
using Eblcu.Bi.Authorization.Users;
using Eblcu.Bi.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Eblcu.Bi.EntityFrameworkCore.SecondDbContext
{
    //public class SecondDbContext : AbpZeroDbContext<Tenant, Role, User, SecondDbContext>, IAbpPersistedGrantDbContext
    public class SecondDbContext : DbContext, IAbpPersistedGrantDbContext
    {
        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        // public DbSet<Courses> Coursess { get; set; }


        public SecondDbContext(DbContextOptions<SecondDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new CoursesCfg());
        }

    }
}
