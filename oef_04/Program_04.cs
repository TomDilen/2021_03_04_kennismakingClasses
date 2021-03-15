using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_04
{
    class Program_04
    {
        static void Main(string[] args)
        {
            Triangle tri1 = new Triangle();
            tri1.Base = 5;
            tri1.Height = 2;
            Console.WriteLine("driehoek 1 heeft een oppervlakte van " + tri1.GetArea().ToString("#.0"));

            Triangle tri2 = new Triangle();
            tri2.Base = 9;
            tri2.Height = 3;
            Console.WriteLine("driehoek 2 heeft een oppervlakte van " + tri2.GetArea().ToString("#.0"));

            Rectangle rect1 = new Rectangle();
            rect1.Width = 2;
            rect1.Length = 15;
            Console.WriteLine("vierkant2 heeft een oppervlakte van " + rect1.GetArea().ToString("#.0"));

            Rectangle rect2 = new Rectangle();
            rect2.Width = 4;
            rect2.Length = 5;
            Console.WriteLine("vierkant2 heeft een oppervlakte van " + rect2.GetArea().ToString("#.0"));


            Console.ReadKey();
        }
    }
}
