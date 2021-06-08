using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mwt.Vinki.Product.Ato
{
    public class ProductAto
    {
        [Required]
        public int CategoryId { set; get; }
        [Required]
        public List<Guid> MediaId { set; get; }

        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, 99999)]
        public decimal Price { set; get; }
        public string Desc { get; set; }
    }
}
