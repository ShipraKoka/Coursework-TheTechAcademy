using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Person freshman = new Person("John", "Science");
            freshman.printPerson();
        }
    }

    public class Person
    {
        public string name { get; set; }
        public string subject { get; set; }
        public int yearsLeft = 2;

        public Person(string name, string subject)
        {
            // this keyword used to qualify Person class members, name and subject
            this.name = name;
            this.subject = "Math";
        }
        
        public void printPerson()
        {
            // this keyword used to pass Person object as a parameter to getCourses method
            Console.WriteLine("{0} needs to take {1} more classes and must take one {2} class.", 
                name, NoOfCourses.getCourses(this), subject);
        }
    }

    public class NoOfCourses
    {
        public static int getCourses(Person P)
        {
            return 12 * P.yearsLeft;
        }
    }
}