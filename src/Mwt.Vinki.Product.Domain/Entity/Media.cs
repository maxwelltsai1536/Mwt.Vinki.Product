using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Mwt.Vinki.Product.Entity
{
    public class Media : AuditedAggregateRoot<Guid>
    {
        public string  Src { get; set; }
        public int Sort { set; get; }

    }
}
