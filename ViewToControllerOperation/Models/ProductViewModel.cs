using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewToControllerOperation.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            product = new Product();
            productList = new List<Product>();
        }
        public Product product { get; set; }
        public List<Product> productList { get; set; }
    }
}
