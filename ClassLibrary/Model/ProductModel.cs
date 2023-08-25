using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Model;

namespace ClassLibrary.Model

{
   public  class ProductModel
    {
        public ProductModel()
        {
           Type = new List<DropDownModel>();
        }
        public int Productid { get; set; }
          [Required(ErrorMessage = "Name is required.")]
        [StringLength(7, ErrorMessage = "Name can't be longer than 7 characters.")]
        public string ProductName { get; set; }
        [Required]
        
        public string ProductType { get; set; }
        [Range(1, 100)]
        public string Quantity { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
       
        public string ProductCode { get; set; }

        public List<DropDownModel> Type { get; set; }


    }
}
