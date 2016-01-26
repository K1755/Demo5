using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creati tyre
            Tyre tyre = new Tyre { Name = "Nokia", Model = "Hakka", TyreSize = "205R16" };

            //Create a car
            Vehicle car = new Vehicle { Name = "Porche", Model = "911" };
            car.AddTyre(tyre); // car contains tyres
            car.AddTyre(tyre); // car contains tyres
            car.AddTyre(tyre); // car contains tyres
            car.AddTyre(tyre); // car contains tyres

            Console.WriteLine(car.ToString());

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
