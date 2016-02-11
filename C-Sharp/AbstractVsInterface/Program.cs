using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Television show1 = new Television()
            {
                title = "Community",
                genre = "Comedy",
                episodes = 110,
                nightOfWeek = "Tuesday",
                networkOrCable = "Network",
                channel = "NBC"
            };

            Console.WriteLine("Title: {0}", show1.GetTitle());
            Console.WriteLine("Channel: {0}", show1.channel);
            Console.WriteLine(show1.GetAirDate());
            Console.WriteLine();

            Netflix show2 = new Netflix()
            {
                title = "Jessica Jones",
                genre = "Drama",
                episodes = 13,
                nightOfWeek = "Friday",
            };

            Console.WriteLine("Title: {0}", show2.GetTitle());
            Console.WriteLine(show2.GetAirDate());
            Console.WriteLine();
        }
    }

    public abstract class Series
    {
        public string title { get; set; }
        public string genre { get; set; }
        public int episodes { get; set; }
        public string nightOfWeek { get; set; }

        // Can implement a method within an abstract class
        public string GetTitle()
        {
            return this.title;
        }

        // abstract method implemented within derived classes
        public abstract string GetAirDate();
    }

    public interface ITelevision
    {
        // Cannot implement any methods within interface
        void NetworkCable();
        void Channel();
    }

    public class Television : Series, ITelevision
    {
        public override string GetAirDate()
        {
            return "Episodes air every " + this.nightOfWeek;
        }

        public string networkOrCable;
        // Implementation of interface members
        public void NetworkCable()
        {
            Console.WriteLine("Network/Cable: {0}", networkOrCable);
        }

        public string channel;
        // Implementation of interface members
        public void Channel()
        {
            Console.WriteLine("Channel: {0}", channel);
        }
    }

    public class Netflix : Series
    {
        public override string GetAirDate()
        {
            return "All episodes will be released on " + this.nightOfWeek;
        }
    }
}
