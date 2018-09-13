using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Eblcu.Bi.EntityFrameworkCore.SecondDbContext
{
    public class SecondDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SecondDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }
        public static void Configure(DbContextOptionsBuilder<SecondDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
