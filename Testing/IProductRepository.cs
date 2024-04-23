using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        //THIS RETURNS A LIST OF PRODUCTS
        public IEnumerable<Product> GetAllProducts();

        //THIS RETURNS A SINGLE PRODUCT BY ITS ID
        public Product GetProduct(int id);
    }


}
