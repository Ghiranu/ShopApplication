using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApplication.Models
{
    public class Customer
    {
        public int ID { get; set; }
        //Change Name into Customer Name
        [Required, StringLength(30, MinimumLength = 3)]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        public string Address { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public int CustomerProductID { get; set; }
        public ICollection<CustomerProduct> CustomerProducts { get; set; }
        
    }
}
