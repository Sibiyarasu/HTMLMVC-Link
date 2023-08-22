using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
   public  class ProductModel
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        [Range(1,100)]
        public string Quantity { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
       
        public string ProductCode { get; set; }
       
    }
}
