using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary.Figures
{
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }


        public double Perimeter
        {
            get { return (SideA + SideB + SideC); }
            set { }
        }

        public double HalfPerimeter
        {
            get { return Perimeter / 2; }
            set { }
        }
        //
        public double TryGetArea()
        {
            var area = Math.Sqrt(HalfPerimeter*(HalfPerimeter-SideA)*(HalfPerimeter - SideB) *(HalfPerimeter - SideC));
            return area;
        }

        public bool IsTriange()
        {
            var maxSide=Math.Max(SideA, Math.Max(SideB,SideC));
            var minSide = Math.Min(SideA, Math.Min(SideB, SideC));
            var averageSide=SideA+SideB+SideC-maxSide-minSide;
            return maxSide < minSide + averageSide;
        }
    }
}
