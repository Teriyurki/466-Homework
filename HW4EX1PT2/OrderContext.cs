using System;
using System.Collections.Generic;
using System.Text;

namespace HW4EX1PT2
{
    public class OrderContext
    {
        IOrderBurger _burger;
        IOrderFries _fries;
        IOrderCombo _combo;

        public OrderContext(IOrderBurger burger, IOrderFries fries, IOrderCombo combo)
        {
            this._burger = burger;
            this._fries = fries;
            this._combo = combo;
        }

        
        public void OrderBurgerStrategy()
        {
            this._burger.orderBurger(2);
        }

        public void OrderFriesStrategy()
        {
            this._fries.orderFries(0);
        }

    }
}
