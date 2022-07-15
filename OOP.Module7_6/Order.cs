using System;

namespace OOP.Module7_6.Models
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Adress);
        }

        // ... Другие поля
    }

}
