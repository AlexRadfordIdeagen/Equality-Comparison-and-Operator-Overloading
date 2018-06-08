using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            var quack = new Duck("Sir Quackalot", "Mallard", 100, 17);
            var quackers = new Duck("Miss Quack", "Marbled Duck", 38, 11);
            var quacked = new Duck("Sir Quackalot", "Mallard", 100, 14);

            Console.WriteLine($"{quack.Name} has the hash code of {quack.GetHashCode()}");
            Console.WriteLine($"{quackers.Name} has the hash code of {quackers.GetHashCode()}");
            Console.WriteLine($"{quacked.Name} has the hash code of {quacked.GetHashCode()}");

            Dictionary<Duck, int> ducks = new Dictionary<Duck, int>();

            ducks.Add(quack, quack.GetHashCode());
            ducks.Add(quackers, quackers.GetHashCode());
            ducks.Add(quacked, quacked.GetHashCode());


 
            Console.ReadLine();
        }
    }
}
