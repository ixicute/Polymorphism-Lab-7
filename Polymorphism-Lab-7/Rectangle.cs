using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lab_7
{
    internal class Rectangle : Geometry
    {
        //Fields
        protected double _base;
        protected double _height;

        //Properties
        public double Base
        {
            get
            {
                return _base;
            }

            protected set
            {
                if (value > 0)
                {
                    _base = value;
                }
                else
                {
                    Console.WriteLine("Rektangelns bas måste vara högre än 0.");
                }
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }

            protected set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("Rektangelns sidor måste vara högre än 0.");
                }
            }
        }

        //Constructor
        public Rectangle(double rBase = 2, double rHeight = 1)
        {
            this.Base = rBase;
            this.Height = rHeight;
        }

        //Metods
        /// <summary>
        /// Calculates the area of a rectangle. Returns a number with a max of 3 decimals.
        /// </summary>
        public override double Area()
        {
            double math = Base * Height;

            math = Math.Round(math, 3);

            return math;
        }

        //ToString
        public override string ToString()
        {
            string RectangleInfo = $"Rektangeln har basen: {Base} och höjden: {Height}. Arean är {Area()}.";
            return RectangleInfo;
        }
    }
}
