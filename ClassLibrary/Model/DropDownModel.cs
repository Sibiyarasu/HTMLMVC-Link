﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
  public   class DropDownModel
    {[Required]

        public int ProductTypeId { get; set; }

        public string ProductType { get; set; }
    }
}
