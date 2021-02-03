using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public class DummyProductsRepository : IProductsRepository
    {
        public IEnumerable<Product> Products { get {
            return new List<Product>()
                {
                new Product {ProductName="Computer Mouse", NumberInStock=523, UnitPrice=19.99M},
                new Product {ProductName="Computer Keyboard", NumberInStock=452, UnitPrice=29.99M},
                new Product {ProductName="Computer Monitor", NumberInStock=84, UnitPrice=199.99M},
                new Product {ProductName="Speaker set", NumberInStock=125, UnitPrice=49.99M},
                new Product {ProductName="Power supply 850W", NumberInStock=91, UnitPrice=119.99M}
                };
        } }
    }
}
