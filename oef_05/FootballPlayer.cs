using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_05
{
    //==================================================================
    public enum FieldPosition
    {
        Unknow,Spits, Middle, Back, Casino,
    }

    //==================================================================
    class FootballPlayer
    {
        private string _name = "Unknow";

        public string Name
        {
            get { return _name; }
            set {
                if(value.Length >=2 && value.Length<=18)
                _name = value; 
            }
        } 

        //--------------------------------------------------
        private double _speed = 20.0f;
        public double Speed
        {
            get { return _speed; }
            set { 
                if (value >3 && value <45)
                    _speed = value; 
            }
        }
        //--------------------------------------------------
        private int _age = 18;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 2 && value < 80)
                    _age = value;
            }
        }
        //--------------------------------------------------
        private FieldPosition _positionOnField = FieldPosition.Unknow;
        public  FieldPosition PositionOnField
        {
            get { return _positionOnField; }
            set
            {
                if (value != FieldPosition.Casino)
                    _positionOnField = value;
            }
        }

        //===========================================================================

        public void FootballPlayerConstructor(string aName, double aSpeed, int aAge, FieldPosition aFieldPositon)
        {
            Name = aName;
            Speed = aSpeed;
            Age = aAge;
            PositionOnField = aFieldPositon;
        }

        //============================================================================

        public string TakeTheBallInTheHand()
        {
            return $"{Name} take the ball in the hand ";
        }
        public string ShootOnGoal()
        {
            return $"{Name} shoots the ball to goal from {PositionOnField} ";
        }
        public string Run()
        {
            return $"{Name} runs with a speed of {Speed} on the {PositionOnField} position";
        }
    }
}
