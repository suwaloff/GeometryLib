using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.FigureArea
{
    public class Circle : IFigure
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0.0)
                throw new ArgumentException("The supplied radius is not correct");

            Radius = radius;
        }
        /// <summary>
        /// Get Circle Area
        /// </summary>
        /// <returns>The Area of the circle is a positive double </returns>
        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
       
    }
}
