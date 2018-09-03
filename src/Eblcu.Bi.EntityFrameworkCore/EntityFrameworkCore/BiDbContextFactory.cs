using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Eblcu.Bi.Configuration;
using Eblcu.Bi.Web;

namespace Eblcu.Bi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BiDbContextFactory : IDesignTimeDbContextFactory<BiDbContext>
    {
        public BiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            BiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BiConsts.ConnectionStringName));

            return new BiDbContext(builder.Options);
        }
    }
}