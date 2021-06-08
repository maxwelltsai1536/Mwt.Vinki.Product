using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Mwt.Vinki.Product.Web
{
    [Dependency(ReplaceServices = true)]
    public class ProductBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Product";
    }
}
