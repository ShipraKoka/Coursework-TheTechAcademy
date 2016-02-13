using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek[] workdays = new DaysOfWeek[3] { DaysOfWeek.Monday, DaysOfWeek.Wednesday, DaysOfWeek.Saturday };

            int hours = 0;
            foreach (DaysOfWeek workday in workdays)
            {
                hours = hours + GetHours(workday);

            }

            Console.WriteLine("You work {0} hours a week.", hours);
        }

        public static int GetHours(DaysOfWeek workday)
        {
            switch (workday)
            {
                case DaysOfWeek.Sunday:
                    return 0;
                case DaysOfWeek.Monday:
                    return 8;
                case DaysOfWeek.Tuesday:
                    return 8;
                case DaysOfWeek.Wednesday:
                    return 8;
                case DaysOfWeek.Thursday:
                    return 8;
                case DaysOfWeek.Friday:
                    return 8;
                case DaysOfWeek.Saturday:
                    return 4;
                default:
                    return 0;
            }
        }
    }

    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}