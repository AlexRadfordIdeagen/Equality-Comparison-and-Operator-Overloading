using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Duck : IEquatable<Duck>
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }

        public override int GetHashCode()
        {
            int hash = Name.GetHashCode();
            hash = (hash * 23) + Type.GetHashCode();
            hash = (hash * 23) + WeightInGrams;
            hash = (hash * 23) + AgeInMonths;

            return hash;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Duck);
        }
        public bool Equals(Duck obj)
        {
            return obj != null && obj.Name == Name;
        }


        public override string ToString()
        {
            return $"Name: {Name} Type: {Type} Weight in grams: {WeightInGrams} Age in months: {AgeInMonths}";
        }

        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }
    }

}