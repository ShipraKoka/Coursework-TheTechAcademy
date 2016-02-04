using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------Value Types--------------------------------

            Console.WriteLine("Value Types\n");
            // Struct
            ValNumbers value1 = new ValNumbers { num1 = 5 };
            Console.WriteLine("Value 1 is: {0}", value1.num1);

            ValNumbers value2 = value1;
            Console.WriteLine("Value 2 is: {0}", value2.num1);
            value2.num1 = 7;
            Console.WriteLine("Value 2 is now: {0}", value2.num1);
            Console.WriteLine("But Value 1 is still: {0}\n", value1.num1);

            // Bool
            bool truth = true;
            bool lie = false;
            Console.WriteLine("This is {0}", truth);
            Console.WriteLine("That is {0}", lie);
            truth = lie;
            Console.WriteLine("This is actually {0}", truth);
            Console.WriteLine("That is still {0}\n\n", lie);

            // --------------------------Reference Types--------------------------------------

            Console.WriteLine("Reference Types\n");
            // Class
            RefNumbers loc1 = new RefNumbers { num1 = 5};
            Console.WriteLine("Location 1 holds: {0}", loc1.num1);

            RefNumbers loc2 = loc1;
            Console.WriteLine("Location 2 holds: {0}", loc2.num1);
            loc2.num1 = 7;
            Console.WriteLine("Location 2 now holds: {0}", loc2.num1);
            Console.WriteLine("So now Location 1 also holds: {0}\n", loc1.num1);
        }
    }

    class RefNumbers
    {
        public int num1;
    }

    struct ValNumbers
    {
        public int num1;
    }
}
