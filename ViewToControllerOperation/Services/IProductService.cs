using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewToControllerOperation.Models;

namespace ViewToControllerOperation.Services
{
   public interface IProductService
    {
        public void CreateProductList(Product product);
        public List<Product> GetProducts();
    }
}
