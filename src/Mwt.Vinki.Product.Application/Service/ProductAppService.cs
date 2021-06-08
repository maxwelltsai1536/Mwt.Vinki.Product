using Mwt.Vinki.Product.Ato;
using Mwt.Vinki.Product.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Mwt.Vinki.Product.Service
{
    public class ProductAppService :
        CrudAppService<
            Entity.Product, //The Book entity
            ProductDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            ProductAto>, //Used to create/update a book
        IProductAppService //implement the IBookAppService
    {
        public ProductAppService(IRepository<Entity.Product, Guid> repository)
            : base(repository)
        {

        }
    }
}
