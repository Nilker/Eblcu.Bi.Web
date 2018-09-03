using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Eblcu.Bi.EntityFrameworkCore
{
    public static class BiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}