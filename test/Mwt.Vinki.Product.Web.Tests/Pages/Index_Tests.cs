using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mwt.Vinki.Product.Pages
{
    public class Index_Tests : ProductWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
