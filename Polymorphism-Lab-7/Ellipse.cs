using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lab_7
{
    internal class Ellipse : Geometry
    {
        //Fields
        private double _radius1;
        private double _radius2;

        //Properties
        public double Radius2
        {
            get
            {
                return _radius2;
            }

            private set
            {
                if (value > 0)
                {
                    _radius2 = value;
                }
                else
                {
                    Console.WriteLine("Ellipsens radie måste vara högre än 0.");
                }
            }
        }
        public double Radius1
        {
            get 
            {
                return _radius1;
            }

            private set
            {
                if (value > 0)
                {
                    _radius1 = value;
                }
                else
                {
                    Console.WriteLine("Ellipsens radie måste vara högre än 0.");
                }
            }
        }

        //Constructor
        public Ellipse(double r1 = 2, double r2 = 1)
        {
            this.Radius1 = r1;
            this.Radius2 = r2;
        }

        //Methods
        /// <summary>
        /// Calculates the area of an Ellipse. Returns a number with a max of 3 decimals.
        /// </summary>
        public override double Area()
        {
            double math = Radius1 * Radius2 * Math.PI;

            math = Math.Round(math, 3);

            return math;
        }

        //ToString
        public override string ToString()
        {
            string EllipseInfo = $"Ellipsens första radie är: {Radius1} och andra radie är: {Radius2}. Arean är {Area()}.";
            return EllipseInfo;
        }
    }
}
