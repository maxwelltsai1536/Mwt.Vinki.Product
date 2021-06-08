using Mwt.Vinki.Product.Ato;
using Mwt.Vinki.Product.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Mwt.Vinki.Product.Service
{
    public interface ICategoryAppService : ICrudAppService< //Defines CRUD methods
            CategoryDto, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CategoryDto> //Used to create/update a book
    {
    }
}
