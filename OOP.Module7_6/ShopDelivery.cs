namespace OOP.Module7_6.Models
{
    public class ShopDelivery : Delivery
    {
        public override string Adress { get; set; }
        public override uint Coast { get; set; }
        public ShopDelivery(Basket basket) : base(basket)
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
