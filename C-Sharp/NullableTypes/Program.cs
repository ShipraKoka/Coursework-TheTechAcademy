using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int? NoOfDaysYouWantWork = null;
            int NoOfDaysYouWillWork = NoOfDaysYouWantWork ?? 5;
            Console.WriteLine("You will work {0} days a week.", NoOfDaysYouWillWork);

        }
    }
}
