using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MultiLayerApplication.DAL
{
    // Helpful urls
    // https://geeksarray.com/blog/entity-framework-core-code-first-migration-using-separate-assembly
    // https://stackoverflow.com/questions/57158388/configurationbuilder-does-not-contain-a-definition-for-addjsonfile
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<StoreContext>
    {
        public StoreContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<StoreContext>();
            var connectionString = configuration.GetConnectionString("ProductDbConnection");
            builder.UseSqlServer(connectionString);
            return new StoreContext(builder.Options);
        }
    }
}
