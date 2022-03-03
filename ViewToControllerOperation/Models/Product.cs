using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewToControllerOperation.Models
{
    public class Product
    {
        [Display(Name ="Product Name")]
        public string name { get; set; }
    }
}
