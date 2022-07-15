using System.Collections.Generic;

namespace OOP.Module7_6.Models
{
    public class Basket
    {
        private List<Product> _products;
        public uint TotalCoast;
        public List<Product> Products => _products;

        public Product this[int index]
        {
            get { return _products[index]; }
            set { _products[index] = value; }
        }


        public Basket()
        {
            _products = new List<Product>();
            TotalCoast = 0;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Remove(Product product)
        {
            _products.Remove(product);
        }
    }

}
