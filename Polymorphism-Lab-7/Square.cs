using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lab_7
{
    internal class Square : Geometry
    {
        //Fields
        private double _side;

        //Properties
        public double Side
        {
            get
            {
                return _side;
            }
            private set 
            {
                if(value > 0)
                {
                    _side = value;
                }
                else
                {
                    Console.WriteLine("Fyrkantens sidor måste vara högre än 0.");
                }
            }
        }

        //Constructor
        public Square(double side = 1)
        {
            this.Side = side;
        }

        //Methods
        /// <summary>
        /// Calculates the area of a square. Returns a number with a max of 3 decimals.
        /// </summary>
        public override double Area()
        {
            double math = Side * Side;

            //Rounds up the result of above math and keeps only 3 decimals.
            math = Math.Round(math, 3);

            return math;
        }

        //ToStrings
        public override string ToString()
        {
            string SquareInfo = $"Fyrkantens sidor är {Side} var. Arean är {Area()}.";
            return SquareInfo;
        }
    }
}
