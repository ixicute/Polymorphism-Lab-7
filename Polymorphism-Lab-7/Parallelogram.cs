using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Lab_7
{
    internal class Parallelogram : Rectangle
    {
        //Constructor
        public Parallelogram(double rBase = 2, double rHeight = 1)
        {
            this.Base = rBase;
            this.Height = rHeight;
        }

        //Methods
        /// <summary>
        /// Calculates the area of a parallelogram. Returns a number with a max of 3 decimals.
        /// </summary>
        public new double Area()
        {
            double math = Base * Height;

            math = Math.Round(math, 3);

            return math;
        }

        //ToString
        public override string ToString()
        {
            string ParaInfo = $"Parallelogramen har basen: {Base} och höjden: {Height}. Arean är {Area()}.";
            return ParaInfo;
        }
    }
}
