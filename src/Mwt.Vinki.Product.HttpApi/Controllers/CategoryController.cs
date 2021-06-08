using Mwt.Vinki.Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mwt.Vinki.Product.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CategoryController : AbpController
    {
        protected CategoryController()
        {
            LocalizationResource = typeof(ProductResource);
        }
    }
}