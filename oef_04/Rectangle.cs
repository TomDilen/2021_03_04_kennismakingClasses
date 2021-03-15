using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_04
{
    class Rectangle
    {
        //==================================================================== public props
        private int _length;
        public int Length
        {
            get { return _length; }
            set { 
                if(value>0)
                    _length = value; 
            }
        }
        //-------------------------------------------
        private int _width;
        public int Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                    _width = value;
            }
        }
        //==================================================================public methods
        public double GetArea()
        {
            return Length * Width;
        }

    }


}
