using Mwt.Vinki.Product.Ato;
using Mwt.Vinki.Product.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Mwt.Vinki.Product.Service
{
    public interface IProductAppService : ICrudAppService< //Defines CRUD methods
            ProductDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            ProductAto> //Used to create/update a book
    {
    }
}
