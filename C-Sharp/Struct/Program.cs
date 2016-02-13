using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { ID = 1, Name = "John Smith" };
            Employee emp2 = emp1;
            Console.WriteLine("ID {0}: {1}", emp1.ID, emp1.Name);
            Console.WriteLine("ID {0}: {1}", emp2.ID, emp2.Name);
            Console.WriteLine();

            emp2.ID = 2;
            emp2.Name = "John Smythe";

            Console.WriteLine("ID {0}: {1}", emp1.ID, emp1.Name);
            Console.WriteLine("ID {0}: {1}", emp2.ID, emp2.Name);
        }
    }

    public struct Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
