using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Mwt.Vinki.Product.Dto
{
    public class MediaDto : AuditedEntityDto<Guid>
    {
        public string Src { get; set; }
        public int Sort { set; get; }
    }
}
