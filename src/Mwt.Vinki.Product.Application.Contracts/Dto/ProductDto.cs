using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Mwt.Vinki.Product.Dto
{
    public class ProductDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public decimal Price { set; get; }
        public string Desc { get; set; }
        public CategoryDto Category { set; get; }
        public List<MediaDto> Medias { get; set; }
    }
}
