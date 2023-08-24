﻿using System;
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
            ProductType = new List<DropDownModel>();
        }
        public int Productid { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        
        public string Type { get; set; }
        [Range(1, 100)]
        public string Quantity { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
       
        public string ProductCode { get; set; }

        public List<DropDownModel> ProductType { get; set; }


    }
}
