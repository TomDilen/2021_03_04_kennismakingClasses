using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_04
{
    class Triangle
    {
        //==================================================================== public props
        private int _Height;
        public int Height
        {
            get { return _Height; }
            set
            {
                if (value > 0)
                    _Height = value;
            }
        }
        //-------------------------------------------
        private int _base;
        public int Base
        {
            get { return _base; }
            set
            {
                if (value > 0)
                    _base = value;
            }
        }
        //==================================================================public methods
        public double GetArea()
        {
            return (_base * Height) / 2.0f;
        }
    }
}
