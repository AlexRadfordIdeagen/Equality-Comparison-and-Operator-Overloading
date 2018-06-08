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
            var quacked = new Duck("Sir Quackalot", "Mallard", 99, 14);

            Console.WriteLine($"{quack.Name} has the hash code of {quack.GetHashCode()}");
            Console.WriteLine($"{quackers.Name} has the hash code of {quackers.GetHashCode()}");
            Console.WriteLine($"{quacked.Name} has the hash code of {quacked.GetHashCode()}");

            Dictionary<Duck, int> ducks = new Dictionary<Duck, int>();

            ducks.Add(quack, quack.GetHashCode());
            ducks.Add(quackers, quackers.GetHashCode());
            ducks.Add(quacked, quacked.GetHashCode());


            List<Duck> duckies = new List<Duck>();

            duckies.Add(quack);
            duckies.Add(quackers);
            duckies.Add(quacked);
            Console.WriteLine("The ducks have now been added to a list and sorted in name");
            foreach (var duck in duckies)
            {
                Console.WriteLine(duck.Name);
            }
            duckies.Sort(new DuckComparer());

            foreach (var duck in duckies)
            {
                Console.WriteLine("Name: {0} Type: {1} Weight in grams: {2} Age in months: {3}", duck.Name, duck.Type, duck.WeightInGrams, duck.AgeInMonths);
            }
            Console.ReadLine();
        }
    }
}
