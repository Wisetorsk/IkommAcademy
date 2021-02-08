using System;
using System.Collections.Generic;
using Domain.Entities;
using System.Text;

namespace Domain.Repositories
{
    public interface IProductsRepository
    {
        public IEnumerable<Product> Products { get; }
    }
}
