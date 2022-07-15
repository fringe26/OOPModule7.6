namespace OOP.Module7_6.Models
{
    public abstract class Delivery
    {
        public Basket Basket { get; set; }
        public abstract string Adress { get; set; }
        public abstract uint Coast { get; set; }

        public Delivery(Basket basket)
        {
            Basket = basket;   //aggregation 
        }




    }

}
