using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Eblcu.Bi.EntityFrameworkCore
{
    public static class BiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BiDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BiDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}