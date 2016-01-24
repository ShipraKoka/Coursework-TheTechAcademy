using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Override_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // calls the overloading methods
            Multiplication product = new Multiplication();
            double product1 = product.Multiply(2, 53);
            double product2 = product.Multiply(1.5, 9.34);
            Console.WriteLine("x * y = {0}", product1);
            Console.WriteLine("x * y = {0}", product2);

            // calls the overriding method
            ProductTen productTen = new ProductTen();
            double productTen1 = productTen.Multiply(2, 53);
            Console.WriteLine("x * y * 10 = {0}", productTen1);
        }
    }

    class Multiplication
    {
        //overloading methods
        public virtual double Multiply(int x, int y)
        {
            return x * y;
        }

        public virtual double Multiply(double x, double y)
        {
            return x * y;
        }
    }

    class ProductTen : Multiplication
    {
        //overriding method
        public override double Multiply(int x, int y)
        {
            return x * y * 10;
        }
    }
}