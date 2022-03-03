using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ViewToControllerOperation.Models;
using ViewToControllerOperation.Services;

namespace ViewToControllerOperation.Controllers
{
    public class HomeController : Controller
    {
      //  private readonly ILogger<HomeController> _logger;

        private IProductService _productService;
       private Movie _movie = new Movie();
        public HomeController(/*ILogger<HomeController> logger,*/ IProductService productService,Movie movie)
        {
           // _logger = logger;
            _productService = productService;
            _movie = movie;
        }

        [HttpGet]
        public IActionResult Operation()
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.productList = _productService.GetProducts();
            return View(productViewModel);
          
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Operation([FromForm] Product product)
        {
            _productService.CreateProductList(product);

            return Redirect("~/Home/Operation");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
