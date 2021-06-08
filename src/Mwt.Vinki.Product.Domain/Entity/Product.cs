using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Mwt.Vinki.Product.Entity
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public decimal Price { set; get; }
        public string Desc { get; set; }
        public Category Category { set; get; }
        public List<Media> Medias { get; set; }
    }
}
