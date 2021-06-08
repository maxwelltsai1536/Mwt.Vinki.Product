using Mwt.Vinki.Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mwt.Vinki.Product.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ProductController : AbpController
    {
        protected ProductController()
        {
            LocalizationResource = typeof(ProductResource);
        }
    }
}