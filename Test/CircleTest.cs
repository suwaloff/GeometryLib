using GeometryLib.FigureArea;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;


namespace GeometryLib.Test
{

    public class CircleTest
    {
        private const double eps = 1e-7;
        /// <summary>
        /// Check for ArgumentException (The radius of the circle is zero)
        /// Should throw away ArgumentException!
        /// </summary>
        [Fact]
        public static void CircleRadiusIsZero()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => { var circ = new Circle(0.0); });
        }

        /// <summary>
        /// Check for ArgumentException (The radius of the circle is less than zero)
        /// </summary>
         
        [Fact]
        public static void CircleRadiusIsLessThanZero()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => { var circ = new Circle(-0.3); });
        }

        /// <summary>
        /// Checking the calculation of the area of the circle with accuracy
        /// </summary>
        [Fact]
        public void CircleAreaCompute()
        {
            Circle crc = new(5.0);
            // Assert
            Assert.Equal(78.53981633, crc.GetSquare(),eps);
        }


    }
}
