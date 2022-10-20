using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lab_7
{
    internal class Circle : Geometry
    {
        //Fields
        private double _radius;

        //Properties
        public double Radius
        {
            get
            {
                return _radius;
            }

            //Value less than 0 is not allowed.
            private set
            {
                if(value > 0)
                {
                    _radius = value;
                }

                else
                {
                    Console.WriteLine("Cirkelns radie måste vara högre än 0.");
                }                
            }
        }

        //Constructor
        public Circle(double radius = 1)
        {
            this.Radius = radius;
        }

        //Methods
        /// <summary>
        /// Calculates the area of a circle. Returns a number with a max of 3 decimals.
        /// </summary>
        public override double Area()
        {
            double math = Radius * Radius * Math.PI;

            //Rounds up the result of above math and keeps only 3 decimals.
            math = Math.Round(math, 3);

            return math;
        }

        //ToString
        public override string ToString()
        {
            string CircleInfo = $"Cirkeln har radie {Radius} och arean är {Area()}.";
            return CircleInfo;
        }
    }
}
