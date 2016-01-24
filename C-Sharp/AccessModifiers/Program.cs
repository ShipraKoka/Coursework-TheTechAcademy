using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer();

            // Public Customer class members "ID", "firstName" and "lastName" can be accessed by any class
            cust1.ID = 001;
            cust1.firstName = "Bob";
            cust1.lastName = "Smith";
 
        }
    }

    public class Customer
    {
        private int SSN;
        protected decimal balance;
        public int ID;
        public string firstName;
        public string lastName;
        protected internal string item;


        public static void getSSN()
        {
            Customer cust2 = new Customer();
            
            // Private class member "SSN" can only be accessed within this class (Customer)
            cust2.SSN = 123456789;
        } 
    }

    public class MemberCustomer : Customer
    {
        public static void ShowBalance()
        {
            MemberCustomer memberCust1 = new MemberCustomer();

            // Protected Customer class member "balance" can be accessed from this class because it is
            // derived from the Customer class.
            memberCust1.balance = 235.05m;
        }
    }

}
