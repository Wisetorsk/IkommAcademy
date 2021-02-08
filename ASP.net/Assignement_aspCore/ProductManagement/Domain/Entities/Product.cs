using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public int NumberInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
