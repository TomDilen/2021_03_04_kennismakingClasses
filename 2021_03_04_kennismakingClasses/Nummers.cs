using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_03_04_kennismakingClasses
{
    public class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        //------------------------------------------------------------------

        public int Som()
        {
            return Getal1 + Getal2;
        }
        public int Verschil()
        {
            return Getal1 - Getal2;
        }
        public int Product()
        {
            return Getal1 * Getal2;
        }
        public int Deling()
        {
            if(Getal2 != 0)
            {
                return Getal1 + Getal2;
            }
            //het mag nog niet, maar console.writeline mag hier ook niet, dus?
            throw new Exception("je mag niet delen door nul");
        }
    }
}
