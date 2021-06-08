using Mwt.Vinki.Product.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mwt.Vinki.Product.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ProductPageModel : AbpPageModel
    {
        protected ProductPageModel()
        {
            LocalizationResourceType = typeof(ProductResource);
        }
    }
}