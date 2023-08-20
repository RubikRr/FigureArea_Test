using FigureAreaLibrary.Figures;

namespace UserAplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(3,4,5);
            var circle = new Circle(10);
            Console.WriteLine($"Площадь треугольника со сторонами {triangle.SideA} {triangle.SideB} {triangle.SideC} равна {triangle.GetArea()}");
            Console.WriteLine($"Плоащадь окружнсоти с радиусом {circle.Raidus} равна {circle.GetArea()}");
        }
    }
}