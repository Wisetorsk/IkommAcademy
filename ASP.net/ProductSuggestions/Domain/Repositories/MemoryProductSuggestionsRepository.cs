using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Domain.Entities;

namespace Domain.Repositories
{
    public class MemoryProductSuggestionsRepository : IProductSuggestionsRepository
    {
        // Dummy (hard-coded) list of product suggestions to start with.
        private static IList<ProductSuggestion> items = new List<ProductSuggestion> {
            new ProductSuggestion { Id=1, Description="Swansea City Shirt", MinPrice=45.00m, MaxPrice=55.00m, EstimatedSales=10000 },
            new ProductSuggestion { Id=2, Description="Cardiff City Shirt", MinPrice=0.99m, MaxPrice=1.01m, EstimatedSales=5 },
            new ProductSuggestion { Id=3, Description="FIFA football",      MinPrice=22.50m, MaxPrice=30.00m, EstimatedSales=200  },
            new ProductSuggestion { Id=4, Description="Carving Skis",       MinPrice=495.50m, MaxPrice=550.00m, EstimatedSales=100  },
            new ProductSuggestion { Id=5, Description="OLED TV",            MinPrice=2700.00m, MaxPrice=3000.00m, EstimatedSales=2000  },
            new ProductSuggestion { Id=6, Description="Solid State Laptop", MinPrice=1785.00m, MaxPrice=1995.00m, EstimatedSales=300  },
            new ProductSuggestion { Id=7, Description="Tablet computer",    MinPrice=450.00m, MaxPrice=500.00m, EstimatedSales=400  },
            new ProductSuggestion { Id=8, Description="Bugatti Veyron",     MinPrice=950000.00m, MaxPrice=1050000.00m, EstimatedSales=2  },
        };

        private static int nextId = 9;

        #region Query repository methods

        // Get all items.
        public IEnumerable<ProductSuggestion> GetAll()
        {
            return items;
        }

        // Get items that contain specified text in the description.
        public IEnumerable<ProductSuggestion> GetLike(string partialDescription)
        {
            var matches = from i in items
                          where i.Description.ToLower().Contains(partialDescription.ToLower())
                          select i;

            return matches.ToList();
        }

        // Get the single item with the specified ID, or null if not found.
        public ProductSuggestion GetById(int id)
        {
            var matches = from i in items
                          where i.Id == id
                          select i;

            return matches.Count() > 0 ? matches.First() : null;
        }

        #endregion

        #region Modify repository methods

        // Insert the new item into the collection.
        public ProductSuggestion Insert(ProductSuggestion item)
        {
            item.Id = nextId++;
            items.Add(item);
            return item;
        }

        // Update the existing item in the collection, with the info passed in the parameter object.
        public bool Update(ProductSuggestion item)
        {
            ProductSuggestion existingItem = GetById(item.Id);
            if (existingItem == null)
            {
                return false;
            }
            else
            {
                existingItem.Description = item.Description;
                existingItem.MinPrice = item.MinPrice;
                existingItem.MaxPrice = item.MaxPrice;
                existingItem.EstimatedSales = item.EstimatedSales;
                return true;
            }
        }

        // Delete the existing item in the collection.
        public bool Delete(int id)
        {
            ProductSuggestion existingItem = GetById(id);
            if (existingItem == null)
            {
                return false;
            }
            else
            {
                items.Remove(existingItem);
                return true;
            }
        }

        #endregion
    }
}
