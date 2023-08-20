using FigureAreaLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary.Tests.Figures
{
    public class TriangleTests
    {
        double eps = Constants.CalcAccuracy;

        [Test]
        public void InitTriangleTest()
        {
            double a = 3d, b = 4d, c = 5d;

            var triangle = new Triangle(a, b, c);

            Assert.IsNotNull(triangle);
            Assert.IsTrue(triangle.IsValid(a, b, c));
        }

        [Test]
        public void GetSquareTest()
        {
            double a = 3d, b = 4d, c = 5d;
            double except = 6d;
            var triangle = new Triangle(a, b, c);
            var area = triangle.GetArea();

            Assert.IsNotNull(triangle);
            Assert.AreEqual(except,area);
        }

        [Test]
        public void NotRightTriangle()
        {
            var triangle = new Triangle(1, 1, 10);

            Assert.Warn("Большая старана должна быть меньше суммы двух других");

        }
    }
}
