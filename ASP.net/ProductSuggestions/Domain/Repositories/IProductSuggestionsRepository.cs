using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Domain.Entities;

namespace Domain.Repositories
{
    public interface IProductSuggestionsRepository
    {
        // Query methods.
        IEnumerable<ProductSuggestion> GetAll();
        IEnumerable<ProductSuggestion> GetLike(string partialDescription);
        ProductSuggestion GetById(int id);
        
        // Modification methods.
        ProductSuggestion Insert(ProductSuggestion item);
        bool Update(ProductSuggestion item);
        bool Delete(int id);
    }
}
