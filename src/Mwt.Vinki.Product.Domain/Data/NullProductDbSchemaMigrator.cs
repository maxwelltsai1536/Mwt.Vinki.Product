using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mwt.Vinki.Product.Data
{
    /* This is used if database provider does't define
     * IProductDbSchemaMigrator implementation.
     */
    public class NullProductDbSchemaMigrator : IProductDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}