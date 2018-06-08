using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class DuckComparer : IComparer<Duck>
    {
        public  int Compare(Duck x, Duck y)
        {
            Console.WriteLine($"{x.Name} is being compared to {y.Name}");
            if (String.Compare(x.Name, y.Name, true) == 0)
            {
                Console.WriteLine($"{x.Name} and {y.Name} are the same so we are ordering them now by weight");
                if (x.WeightInGrams > y.WeightInGrams)
                {
                    Console.WriteLine($"{x.Name} is above in weight by {x.WeightInGrams} to {y.Name}'s {y.WeightInGrams}");

                    return 1;
                }

                else
                {
                    Console.WriteLine($"{y.Name} is above in weight by {y.WeightInGrams} to {x.Name}'s {x.WeightInGrams}");

                    return -1;
                }
            }
            else
            {
                if (String.Compare(x.Name, y.Name, true) == 1)
                {
                    Console.WriteLine($"{x.Name} is higher in the alphabet compared to {y.Name}");

                }
                if (String.Compare(x.Name, y.Name, true) == -1)
                {
                    Console.WriteLine($"{y.Name} is higher in the alphabet compared to {x.Name}");

                }
                return String.Compare(x.Name, y.Name, true);
            }
        }
    }
}
