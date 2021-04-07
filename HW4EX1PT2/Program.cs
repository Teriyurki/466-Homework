using System;

namespace HW4EX1PT2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderContext order = new OrderContext();

            
            order.OrderBurgerStrategy();
            order.OrderFriesStrategy();
           
        }
    }


    interface IOrder
    {
        void orderBurger(int quantity);
        void orderFries(int fries);
        void orderCombo(int quantity, int fries);
    }

    public class BurgerOrderService : IOrder
    {
        public void orderBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
        }

        public void orderFries(int fries)
        {
            throw new NotImplementedException("No fries in burger only order");
        }

        public void orderCombo(int quantity, int fries)
        {
            throw new NotImplementedException("No combo in burger only order");
        }
    }
}
