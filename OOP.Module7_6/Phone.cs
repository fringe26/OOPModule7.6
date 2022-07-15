namespace OOP.Module7_6.Models
{
    public class Phone : Product
    {
        
        public override int Id { get; set ; }
        public override string ProductName { get ; set ; }
        public override Category Category { get; set; }
        public override decimal Price { get ; set; }
        public override int Stock { get; set; }
    }

}
