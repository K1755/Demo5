using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä4
{
    class CoffeeMaker
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public List<Ingredients> Brewingredient { get; }

        public CoffeeMaker()
        {
            Brewingredient = new List<Ingredients>();
        }

        public void AddIngredient(Ingredients ingredient)
        {
            Brewingredient.Add(ingredient);
        }

        public override string ToString()
        {
            string cMaker = "Coffee Maker: " + Name + " Model: " + Model + "\n";
            foreach (Ingredients ingredient in Brewingredient)
            {
                cMaker += ingredient.ToString() + "\n";
            }
            return cMaker;
        }
    }
}
