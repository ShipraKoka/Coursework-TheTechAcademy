using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{

    class Program
    {
        static void Main(string[] args)
        {
            StreamToFile();
            
        }
        
        static void StreamToFile()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Employee employee = new Employee(lastName, firstName);

            BinaryFormatter bf = new BinaryFormatter();
            using(FileStream fs = File.OpenWrite("employee.txt"))
            {
                bf.Serialize(fs, employee);
            }
            using(FileStream fs = File.OpenRead("employee.txt"))
            {
                Employee obj = (Employee)bf.Deserialize(fs);
                Console.WriteLine(obj);
            }
        }
    }

    [Serializable]
    public class Employee
    {
        private string firstName;
        private string lastName;
        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }
        
        public override string ToString()
        {
            return this.lastName + ", " + this.firstName;
        }
    }
}
       
