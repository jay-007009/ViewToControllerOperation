using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewToControllerOperation.Models;

namespace ViewToControllerOperation.Services
{
    public class ProductService :IProductService
    {
        public List<Product> products { get; set; } = new List<Product>();
        public void CreateProductList(Product product)
        {
            products.Add(product);
        }
        public List<Product> GetProducts() => products;
    }
}
