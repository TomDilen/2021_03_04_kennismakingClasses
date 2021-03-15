using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_02
{
    class Program_02
    {
        static void Main(string[] args)
        {

            Student studnt = new Student();

            studnt.Klas = KlasType.EersteLeerjaar;
            studnt.Naam = "joske vermeulen";
            studnt.Leeftijd = 21;
            studnt.PuntenCommunicatie = 21;
            studnt.PuntenProgrammingPrincipes = 16;
            studnt.PuntenWebTech = 12;

            Console.WriteLine(studnt.GetOverzicht());


            Console.ReadLine();
        }
    }
}
