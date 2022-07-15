using System.Text;

namespace OOP.Module7_6.Models
{
    public abstract class Product
    {
        public abstract int Id { get; set; }
        public abstract string ProductName { get; set; }
        public abstract decimal Price { get; set; }
        public abstract Category Category { get; set; }
        public abstract int Stock { get; set; }

    }

}
