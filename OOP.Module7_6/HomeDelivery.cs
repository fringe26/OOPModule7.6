namespace OOP.Module7_6.Models
{
    public class HomeDelivery : Delivery
    {
      

        /* ... */
        public override string Adress { get; set; }
        public override uint Coast { get; set; }
        public HomeDelivery(Basket basket) : base(basket)
        {
            if (basket.Products.Count != 0)
            {
                Basket = basket;
                Adress = "Baku Azadlig";
                Coast = 250;
            }
        }
    }

}
