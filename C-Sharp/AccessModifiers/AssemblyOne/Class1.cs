using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AssemblyOne
{
    public class YearsMember
    {
        internal int years;
    }

    public class Class2
    {
        public void Sample()
        {
            YearsMember exampleClass = new YearsMember();

            // Internal YearsMember class member "years" can only be accessed within this assembly (AssemblyOne)
            exampleClass.years = 5;
        }
    }

    public class OneTimeCustomer : Customer
    {
        public void itemBought()
        {
            OneTimeCustomer oneTimeCust = new OneTimeCustomer();

            //Protected internal Customer class member "item" can be accessed from this assembly (AssemblyOne)
            //because this class is derived from the Customer class in the AccessModifiers assembly.
            oneTimeCust.item = "Microwave";
        }
        
    }
}
