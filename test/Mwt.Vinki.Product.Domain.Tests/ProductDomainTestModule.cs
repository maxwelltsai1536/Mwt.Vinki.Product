using Mwt.Vinki.Product.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Mwt.Vinki.Product
{
    [DependsOn(
        typeof(ProductEntityFrameworkCoreTestModule)
        )]
    public class ProductDomainTestModule : AbpModule
    {

    }
}