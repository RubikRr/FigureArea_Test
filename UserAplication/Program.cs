using FigureAreaLibrary.Figures;

namespace UserAplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(3,4,5);
            if (triangle.IsRightTriangle() ) { Console.WriteLine("ДААААААААААА"); }
        }
    }
}