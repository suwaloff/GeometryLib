namespace GeometryLib.FigureArea
{
    public class Triangl : IFigure
    {
        private double sideA { get; }
        private double sideB { get; }
        private double sideC { get; }

        private const double eps = 1e-7;
       
        public Triangl(double sideA, double sideB, double sideC)
        {
            if (sideA < eps)
                throw new ArgumentException("The side of the triangle is not a positive double", nameof(sideA));

            if (sideB < eps)
                throw new ArgumentException("The side of the triangle is not a positive double", nameof(sideB));

            if (sideC < eps)
                throw new ArgumentException("The side of the triangle is nt a positive double", nameof(sideC));

            double maxEdge = Math.Max(sideA, Math.Max(sideB, sideC));
            double perimeter = sideA + sideB + sideC;

            if ((perimeter - maxEdge) - maxEdge < eps)
                throw new ArgumentException("this figure is not a triangle");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        /// <summary>
        /// Get Triangle Area
        /// </summary>
        ///  <returns>The Area of the triangle is a positive double</returns>
        public double GetSquare()
        {
            double halfPr = (sideA + sideB + sideC) / 2;
            // Heron's formula
            return Math.Sqrt(halfPr * (halfPr - sideA) * (halfPr - sideB) * (halfPr - sideC));
        }

        /// <summary>
        /// Check Triangle is Right
        /// </summary>
        /// <returns>True/False</returns>
        public bool GetIsRightTriangle()
        {
            double[] sides = new double[3] { sideA, sideB, sideC };

            Array.Sort(sides);

            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) <= eps;
        }
    }
}
