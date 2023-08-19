using FigureAreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary.Figures
{
    public class Сircle : IFigure
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
        public double GetArea()
        {
            var area = Math.PI*Raidus*Raidus;
            return area;
        }
    }
}
