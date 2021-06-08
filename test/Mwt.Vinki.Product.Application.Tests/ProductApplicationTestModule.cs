using Volo.Abp.Modularity;

namespace Mwt.Vinki.Product
{
    [DependsOn(
        typeof(ProductApplicationModule),
        typeof(ProductDomainTestModule)
        )]
    public class ProductApplicationTestModule : AbpModule
    {

    }
}