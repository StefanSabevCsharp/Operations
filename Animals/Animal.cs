using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public Animal(string name,string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }
        string Name { get; set; }
        string FavouriteFood { get; set; }
        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavouriteFood}";
        }
    }
}
