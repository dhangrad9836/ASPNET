using System.Collections.Generic;

namespace Testing.Models
{
    public class Product
    {
        //constructor
        public Product() { }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }

        //this will include the list of categories
        public IEnumerable<Category> Categories { get; set; }
    }
}
