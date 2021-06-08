using Mwt.Vinki.Product.Ato;
using Mwt.Vinki.Product.Dto;
using Mwt.Vinki.Product.Entity;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Mwt.Vinki.Product.Service
{
    public class CategoryAppService :
        CrudAppService<
            Category, //The Book entity
            CategoryDto, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CategoryDto>, //Used to create/update a book
        ICategoryAppService //implement the IBookAppService
    {
        public CategoryAppService(IRepository<Category, int> repository)
            : base(repository)
        {

        }
    }
}
