using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Mwt.Vinki.Product.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ProductMigrationsDbContextFactory : IDesignTimeDbContextFactory<ProductMigrationsDbContext>
    {
        public ProductMigrationsDbContext CreateDbContext(string[] args)
        {
            ProductEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ProductMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"), new MySqlServerVersion(new Version("8.0.25")));

            return new ProductMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Mwt.Vinki.Product.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
