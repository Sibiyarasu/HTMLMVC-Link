using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLMVC_Link.Models
{
    public class ProductViewModel
    {

        public ProductModel  Create { get; set; }

        public List<ProductModel> List { get; set; }
        public DropDownModel Type { get; set; }

    }
}
