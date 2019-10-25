using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using vOpenUy.Demo.Configuration;
using vOpenUy.Demo.Web;

namespace vOpenUy.Demo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DemoDbContextFactory : IDesignTimeDbContextFactory<DemoDbContext>
    {
        public DemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DemoConsts.ConnectionStringName));

            return new DemoDbContext(builder.Options);
        }
    }
}
