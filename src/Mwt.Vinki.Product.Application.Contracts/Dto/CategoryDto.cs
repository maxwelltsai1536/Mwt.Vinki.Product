using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Mwt.Vinki.Product.Dto
{
    public class CategoryDto : AuditedEntityDto<int>
    {
        public string Name { get; set; }
    }
}
