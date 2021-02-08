using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUserInterFace.Controllers
{
    public class ProductsController : Controller
    {
        IProductsRepository products;

        public ProductsController()
        {
            products = new DummyProductsRepository();
        }
        public IActionResult List()
        {
            return View(products.Products);
        }

        public IActionResult AllProducts()
        {
            return View(products.Products);
        }

        public IActionResult Sorted()
        {
            var sorted = products.Products.OrderByDescending(p => p.NumberInStock * p.UnitPrice).ToList();

            return View("List", sorted);
        }

        public IActionResult ProductsMoreThan100()
        {
            var expensiveProducts = products.Products.Where(p => p.UnitPrice > 30);
            return View("List", expensiveProducts);
        }
    }
}
