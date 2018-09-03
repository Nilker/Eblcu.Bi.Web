using Abp.IdentityServer4;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Eblcu.Bi.Authorization.Roles;
using Eblcu.Bi.Authorization.Users;
using Eblcu.Bi.Chat;
using Eblcu.Bi.Editions;
using Eblcu.Bi.EntityMapper.charge_studentsdatas;
using Eblcu.Bi.EntityMapper.drop_out_studentsdatas;
using Eblcu.Bi.EntityMapper.entry_recruit_studentsdatas;
using Eblcu.Bi.EntityMapper.graduate_studentsdatas;
using Eblcu.Bi.EntityMapper.nograduate_studentsdatas;
using Eblcu.Bi.EntityMapper.zhx_student_inreadings;
using Eblcu.Bi.Friendships;
using Eblcu.Bi.MultiTenancy;
using Eblcu.Bi.MultiTenancy.Accounting;
using Eblcu.Bi.MultiTenancy.Payments;
using Eblcu.Bi.Storage;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.EntityFrameworkCore
{
    public class BiDbContext : AbpZeroDbContext<Tenant, Role, User, BiDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }


        public DbSet<charge_studentsdata> charge_studentsdata { get; set; }
        public DbSet<drop_out_studentsdata> drop_out_studentsdata { get; set; }
        public DbSet<entry_recruit_studentsdata> entry_recruit_studentsdata { get; set; }
        public DbSet<graduate_studentsdata> graduate_studentsdata { get; set; }
        public DbSet<nograduate_studentsdata> nograduate_studentsdata { get; set; }
        public DbSet<zhx_student_inreading> zhx_student_inreading { get; set; }


        public BiDbContext(DbContextOptions<BiDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { e.PaymentId, e.Gateway });
            });

            modelBuilder.ConfigurePersistedGrantEntity();


            modelBuilder.ApplyConfiguration(new charge_studentsdataCfg());
            modelBuilder.ApplyConfiguration(new drop_out_studentsdataCfg());
            modelBuilder.ApplyConfiguration(new entry_recruit_studentsdataCfg());
            modelBuilder.ApplyConfiguration(new graduate_studentsdataCfg());
            modelBuilder.ApplyConfiguration(new nograduate_studentsdataCfg());
            modelBuilder.ApplyConfiguration(new zhx_student_inreadingCfg());


        }
    }
}
