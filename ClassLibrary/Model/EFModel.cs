using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public  class EFModel
    {
        
            [Key]
            public int Empid { get; set; }
            [Required]
            public string FirstName { get; set; }
            [Required]
            public int Age { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string Gender { get; set; }

            public string Location { get; set; }
        }
    }

