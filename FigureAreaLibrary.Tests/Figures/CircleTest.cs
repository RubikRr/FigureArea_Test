using FigureAreaLibrary.Figures;
namespace FigureAreaLibrary.Tests.Figures
{
    public class CircleTest
    {
        double eps = Constants.CalcAccuracy;

        [Test]
        public void GetAreaWithRadius1 ()
        {
            var radius = 1;
            var except = Math.PI;
            var circle = new Circle(radius);
            var result= circle.GetArea();
            Assert.AreEqual(except, result);
        }

        [Test]
        public void GetSquareTest()
        {
            var radius = 5;
            var circle = new Circle(radius);
            var expected = Math.PI * Math.Pow(radius, 2d);

            var square = circle.GetArea();

            Assert.IsTrue(Math.Abs(square - expected) < eps);
        }

        [Test]
        public void ZeroRadiusTest()
        {
            var radius = 0;
            var circle=new Circle(radius);
            Assert.Warn("Радиус не может быть 0");
        }


        [Test]
        public void NegativeRadiusTest()
        {
            var radius = 0;
            var circle = new Circle(radius);
            Assert.Warn("Радиус не может быть отрицательным числом");
        }

    }
}