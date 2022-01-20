using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApplication.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required, StringLength(30, MinimumLength = 5)]
        public string ProductName { get; set; }

        public string Description { get; set; }
        [Range(1, 300)]
        [Column(TypeName = "decimal(6, 2)")]
        public int Price { get; set; }

    }
}
