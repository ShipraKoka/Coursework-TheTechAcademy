using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate void AddDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            AddDelegate del = new AddDelegate(getSum);
            del(189, 390);
        }

        public static void getSum(int num1, int num2)
        {
            Console.WriteLine("Sum: {0}", (num1 + num2));
        }
    }

}
