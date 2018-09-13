using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Eblcu.Bi.Configuration;
using Eblcu.Bi.Web;

namespace Eblcu.Bi.EntityFrameworkCore.SecondDbContext
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SecondDbContextFactory : IDesignTimeDbContextFactory<SecondDbContext>
    {
        public SecondDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SecondDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            SecondDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MultipleDbContextEfCoreDemoConsts.SecondDbConnectionStringName));

            return new SecondDbContext(builder.Options);
        }
    }
}