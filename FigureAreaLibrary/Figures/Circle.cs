using FigureAreaLibrary.Interfaces;

namespace FigureAreaLibrary.Figures
{
    public class Circle : IFigure
    {
        public double radius;
        public double Raidus
        {
            get { return radius; }
            set
            {
                if (value < 0)
                    throw new Exception("Радиус не может быть отрицательным числом");
                radius = value;
            }
        }
        public Circle(double radius)
        {
            Raidus = radius;
        }
        public double GetArea()
        {
            var area = Math.PI*Raidus*Raidus;
            return area;
        }
    }
}
