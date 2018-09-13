using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.IdentityServer4;
using Abp.Zero.EntityFrameworkCore;
using Eblcu.Bi.Authorization.Roles;
using Eblcu.Bi.Authorization.Users;
using Eblcu.Bi.EntityMapper.Products;
using Eblcu.Bi.MultiTenancy;
using Eblcu.Bi.Test;
using Microsoft.EntityFrameworkCore;

namespace Eblcu.Bi.EntityFrameworkCore.SecondDbContext
{
    //public class SecondDbContext : AbpZeroDbContext<Tenant, Role, User, SecondDbContext>, IAbpPersistedGrantDbContext
    public class SecondDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }




        public SecondDbContext(DbContextOptions<SecondDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new CoursesCfg());
            modelBuilder.ApplyConfiguration(new ProductCfg());
        }

    }
}
