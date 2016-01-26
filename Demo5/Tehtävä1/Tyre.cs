using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Tyre
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string TyreSize { get; set; }



        public override string ToString()
        {
            return "Tyre Name: " + Name + " Tyre Model: " + Model + " Tyre Size: " + TyreSize;
        }


    }
}
