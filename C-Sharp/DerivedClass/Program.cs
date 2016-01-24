using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Comedy movieOne = new Comedy();
            movieOne.Title = "The Gold Rush";
            movieOne.Color = false;
            Console.Write("{0} is a {1} ", movieOne.Title, movieOne.Genre);
            movieOne.getColor();

            Film movieTwo = new Film();
            movieTwo.Title = "Taxi Driver";
            Console.Write("{0} is a {1} ", movieTwo.Title, movieTwo.Genre);
            movieTwo.getColor();
        }
    }

    class Film
    {
        public string Title { get; set; }
        public virtual string Genre { get; set; } = "Drama";
        public int Minutes { get; set; }
        public string Rating { get; set; }
        public bool Color = true;

        public void getColor()
        {
            if (Color == true)
            {
                Console.WriteLine("and is in color.\n");
            }
            else
            {
                Console.WriteLine("and is in black and white.\n");
            }
        }
	}

    // Derived from base class "Film"
    class Comedy : Film
    {
        public override string Genre { get; set; } = "Comedy";
    }
}
