using AutoMapper;
using Mwt.Vinki.Product.Ato;
using Mwt.Vinki.Product.Dto;
using Mwt.Vinki.Product.Entity;

namespace Mwt.Vinki.Product
{
    public class ProductApplicationAutoMapperProfile : Profile
    {
        public ProductApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Entity.Product, ProductDto>();
            CreateMap<ProductAto, Entity.Product>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Media, MediaDto>();
            CreateMap<MediaDto, Media>();
        }
    }
}
