using System;
using System.Collections.Generic;
using System.Text;

namespace HW4EX1PT2
{
    public class OrderBurger: IOrderBurger
    {
        public void orderBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
        }

    }
}
