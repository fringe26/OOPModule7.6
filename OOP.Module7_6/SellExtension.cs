using OOP.Module7_6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Module7_6
{
    static class SellExtension
    {

        public static void Sell (this Product product)
        {
            if (product?.Stock > 0)
            {
                product.Stock--;
            }else
            {
                Console.WriteLine($"Product {product.ProductName} out of stock!");
            }
            
        }
    }
}
