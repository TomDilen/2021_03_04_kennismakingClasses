using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_03
{
    class Pizza
    {
        //-----------------------------------------------------
        public string Topping { get; set; } = "Bacon, Cheese";

        //-----------------------------------------------------
        public double _diameter { get; set; } = 20;  //in cm
        public double Diameter
        {
            get { return _diameter; }
            set
            {
                if (value >= 3 && value < 100)
                    _diameter = value;
            }
        }
        //-----------------------------------------------------
        private int _price;

        public int Price
        {
            get { return _price; }
            set { 
                if(value >= 2 && value <20) 
                    _price = value; 
            }
        }
        //-----------------------------------------------------


    }
}
