using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Mwt.Vinki.Product.EntityFrameworkCore
{
    [DependsOn(
        typeof(ProductEntityFrameworkCoreModule)
        )]
    public class ProductEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ProductMigrationsDbContext>();
        }
    }
}
