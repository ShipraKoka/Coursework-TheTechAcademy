using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition sum = new Addition();
            sum.Add();

            Multiplication product = new Multiplication();
            product.Add();

            //Subtraction sub = new Subtraction();
            //sub.Add();
        }
    }

    public class Addition
    {
        protected int x = 3;
        protected int y = 4;
        public virtual void Add()
        {
            Console.WriteLine("Result is {0}.", (x + y));
        }
    }

    public class Multiplication : Addition
    {
        public sealed override void Add()
        {
            Console.WriteLine("Product is {0}.", (x * y));
        }
    }


// Add method in the Multiplication class is sealed, so it cannot be inherited by the Subtraction class.
/*
    public class Subtraction : Multiplication
    {
        public override void Add()
        {
            Console.WriteLine("Result is {0}.", (x - y);
        }
    }
 */
}
