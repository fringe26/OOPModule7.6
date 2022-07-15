using System.Collections.Generic;

namespace OOP.Module7_6.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        private List<Product> _products;
        public List<Product> Products => _products;

        public Category()
        {
            _products = new List<Product>();
        }
    }

}
