using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_03
{
    class Program_03
    {
        static void Main(string[] args)
        {

            Pizza baconPizza = new Pizza();
            baconPizza.Diameter = 150; //wordt niet aangepast, maar er is ook nog geen melding over

            Console.WriteLine(baconPizza.Diameter);


            Console.ReadKey();
        }
    }
}
