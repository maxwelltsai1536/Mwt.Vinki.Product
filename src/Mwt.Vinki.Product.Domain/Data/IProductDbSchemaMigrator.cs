using System.Threading.Tasks;

namespace Mwt.Vinki.Product.Data
{
    public interface IProductDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
