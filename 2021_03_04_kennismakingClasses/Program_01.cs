using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_03_04_kennismakingClasses
{
    class Program_01
    {
        static void Main(string[] args)
        {
            Nummers paar = new Nummers();

            paar.Getal1 = 50;
            paar.Getal2 = 2;

            Console.WriteLine("paar: " + paar.Getal1 + ", " + paar.Getal2);
            Console.WriteLine("som: " + paar.Som());
            Console.WriteLine("verschil: " + paar.Verschil());
            Console.WriteLine("produkt: " + paar.Product());
            try
            {
                Console.WriteLine("deling: " + paar.Deling());
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
