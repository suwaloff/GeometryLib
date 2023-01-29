using GeometryLib.FigureArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GeometryLib.Test
{
    public class TriangleTest
    {
        private const double eps = 1e-7;

        /// <summary>
        /// One or more sides of Triangle is zero
        /// Should throw away ArgumentException!
        /// </summary>
        [Fact]
        public void SideIsZero()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => { var triangl = new Triangl(0.0, 2.0, 8.0); });
        }

        /// <summary>
        /// One or more sides of Triangle is less than zero
        /// Should throw away ArgumentException!
        /// </summary>
        [Fact]
        public void SideIsLessThanZero()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => { var triangl = new Triangl(10.0, 2.0, -8.0); });
        }

        /// <summary>
        /// The triangle does not exist
        /// Should throw away ArgumentException!
        /// </summary>
        [Fact]
        public void TriangleNotExist()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => { var triangl = new Triangl(10.0, 2.0, 2.0); });
        }

        /// <summary>
        /// Checking the calculation of the area of the Triangle with accuracy
        /// </summary>
        [Fact]
        public void TriangleAreaDeltaCompute()
        {
            // Arrange
            Triangl trg = new(40, 35, 25);
            // Assert
            Assert.Equal(433.0127018922, trg.GetSquare(), eps);
        }

        /// <summary>
        /// Checking for the squareness of the triangle
        /// This triangle is rectangular
        /// </summary>
        [Fact]
        public void TriangleIsRight()
        {
            // Arrange
            Triangl trg = new(17, 144, 145);
            // Assert
            Assert.True(trg.GetIsRightTriangle());
        }

        /// <summary>
        /// Checking for the squareness of the triangle
        /// This triangle is not rectangular
        /// </summary>
        [Fact]
        public void TriangleIsNotRight()
        {
            // Arrange
            Triangl trg = new(17, 144, 145.04);
            // Assert
            Assert.False(trg.GetIsRightTriangle());
        }
    }

}

