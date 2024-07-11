using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PdksApp.DAL
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            string connectionString = @"User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=DemoPdks;Pooling=true;";
            optionsBuilder.UseNpgsql(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
