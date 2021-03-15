using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_02
{
    enum KlasType
    {
        EersteLeerjaar,
        TweedeLeerjaar,
        DerdeLeerjaar
    }
    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public KlasType Klas { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrincipes { get; set; }
        public int PuntenWebTech { get; set; }


        public double BerekenGemiddelde()
        {
            return Convert.ToDouble((PuntenCommunicatie + PuntenProgrammingPrincipes + PuntenWebTech) / 3.0f);
        }
        public int BerekenTotaal()
        {
            return  PuntenCommunicatie + PuntenProgrammingPrincipes + PuntenWebTech;
        }

        public string GetOverzicht()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Naam + ", " + Leeftijd + " jaar\n");
            sb.Append("Klas: " + Klas.ToString() +"\n\n");
            sb.Append("cijfer rapport\n");
            sb.Append("**************\n");
            sb.Append("PuntenCommunicatie: " + PuntenCommunicatie + "\n");
            sb.Append("PuntenProgrammingPrincipes: " + PuntenProgrammingPrincipes + "\n");
            sb.Append("PuntenCommunicatie: " + PuntenWebTech + "\n");
            sb.Append("Het gemiddelde: " + BerekenGemiddelde().ToString("#.0"));

            return sb.ToString();

        }
    }
}
