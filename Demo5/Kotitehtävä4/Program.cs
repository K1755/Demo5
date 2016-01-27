using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredients water = new Ingredients { Name = "Water" };
            Ingredients groundcoffee = new Ingredients { Name = "Ground coffee" };

            CoffeeMaker percolator = new CoffeeMaker { Name = "Presto ", Model = "Percolator" };
            percolator.AddIngredient(water);
            percolator.AddIngredient(groundcoffee);

            Console.WriteLine(percolator.ToString());

            CoffeeMaker moccamaster = new CoffeeMaker { Name = "MoccaMaster", Model = "Filter" };
            moccamaster.AddIngredient(water);
            moccamaster.AddIngredient(groundcoffee);

            Console.WriteLine(moccamaster.ToString());

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();


        }
    }
}
