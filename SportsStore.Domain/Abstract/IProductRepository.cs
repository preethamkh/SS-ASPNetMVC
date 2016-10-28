using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    // REPOSITORY PATTERN
    // A class that depends on this IProductsRepository interface can obtain Product objects without needing to know anything about where they are coming from or how the implementation class will deliver them
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productId);
    }
}
