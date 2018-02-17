using System;
using System.Collections.Generic;

namespace Geometry
{
    class Triangle : GeometricFigure
    {
        /// <summary>
        /// Method used to find area of a triangle.
        /// </summary>
        public override void FindingArea()
        {
            //base.FindingArea();
            Console.WriteLine("Finding area of triangle.");
        }

        /// <summary>
        /// Method used to find perimeter of a triangle.
        /// </summary>
        public void FindingPerimeter()
        {
            Console.WriteLine("Finding perimeter of a triangle.");
        }
    }
}
