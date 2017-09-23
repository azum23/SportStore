using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> _products;

        public FakeProductRepository()
        {
            _products = new List<Product>()
            {
                new Product (){Name = "Football", Price = 25 },
                new Product (){Name = "Surf Board", Price = 179 },
                new Product (){Name = "Running shoes", Price = 95 }
            };
        }

        public IEnumerable<Product> Products => _products;
    }
}
