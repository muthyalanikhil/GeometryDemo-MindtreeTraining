using System;
using System.Collections.Generic;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure area = new Triangle();              //Upcasting 
            area.FindingArea();

            Triangle perimeter = (Triangle)area;               //Downcasting

            perimeter.FindingPerimeter();

            Console.ReadLine();
        }
    }
}
