using System;

namespace HW4EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            BurgerOrderService order = new BurgerOrderService();
            order.OrderBurger(2);       // only want a burger only order
            //order.OrderFries(0);

            FryOrderService order2 = new FryOrderService();
            order2.OrderFries(0);            // throws an exception
        }
    }


    public interface IOrderFries
    {

        void OrderFries(int fries);

    }

    public interface IOrderBurger
    {
        void OrderBurger(int quantity);
    }

    public interface IOrderCombo
    {
        void OrderCombo(int quantity, int fries);
    }
    public class BurgerOrderService : IOrderBurger
    {
        public void OrderBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
        }

        //public void OrderFries(int fries)
        //{
        //    throw new NotImplementedException("No fries in burger only order");
        //}

        //public void OrderCombo(int quantity, int fries)
        //{
        //    throw new NotImplementedException("No combo in burger only order");
        //}
    }

    public class FryOrderService : IOrderFries
    {

        public void OrderFries(int fries)
    {
        Console.WriteLine($"Received order for {fries} fries");
    }
}

    public class ComboOrderService : IOrderCombo
    {


        public void OrderCombo(int quantity, int fries)
        {
            Console.WriteLine($"Received order for {quantity} burgers and {fries} fries");
        }
    }

}
