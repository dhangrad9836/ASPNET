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

        //this is void b/c it's doing an action by updating the product and we pass in the product that we want to update
        public void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
    }


}
