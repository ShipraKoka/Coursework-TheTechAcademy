using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{

    public delegate void PersonDelegate(List<string> info);

    class Program
    {
        static void Main(string[] args)
        {
            List<string> personInfo = new List<string>() { "John", "Los Angeles", "Writer" };

            PersonDelegate del = new PersonDelegate(getName);
            del += getCity;
            del += getJob;

            del(personInfo);
        }

        public static void getName(List<string> name)
        {
            Console.WriteLine("Name: {0}", name[0]);
        } 

        public static void getCity(List<string> city)
        {
            Console.WriteLine("City: {0}", city[1]);
        }

        public static void getJob(List<string> job)
        {
            Console.WriteLine("Occupation: {0}", job[2]);
        }
    }
}
