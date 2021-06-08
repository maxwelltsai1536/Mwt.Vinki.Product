using Mwt.Vinki.Product.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Mwt.Vinki.Product
{
    public class VinkiDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Entity.Product, Guid> _productRepository;

        public VinkiDataSeederContributor(IRepository<Entity.Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _productRepository.GetCountAsync() <= 0)
            {
                await _productRepository.InsertAsync(
                    new Entity.Product
                    {
                        Name = "p1",
                        Price = 10,
                        Desc = "test desc",
                        Category = new Category
                        {
                            Name = "c1",
                        },
                        Medias = new List<Media>
                        {
                            new Media
                    {
                        Src = "baidu.com/xx1.png",
                        Sort = 1,
                    }
                        }
                    },
                    autoSave: true
                );
            }
        }
    }
}
