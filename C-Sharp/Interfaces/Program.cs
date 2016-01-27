using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkOrder order = new DrinkOrder();
            order.Soda("Sprite");
            order.Juice("apple");
            order.Water();
        }
    }

    interface IBeverage
    {
        void Soda(string drink);
        void Juice(string drink);
    }

    interface IWater : IBeverage
    {
        void Water();
    }

    public class DrinkOrder : IWater
    {
        public void Soda(string drink)
        {
            Console.WriteLine("I ordered {0}.", drink);
        }

        public void Juice(string drink)
        {
            Console.WriteLine("I ordered {0} juice.", drink);
        }

        public void Water()
        {
            Console.WriteLine("I ordered water.");
        }
    }
}
