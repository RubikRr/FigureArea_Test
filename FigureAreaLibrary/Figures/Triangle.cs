using FigureAreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary.Figures
{
    public class Triangle : ITriangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public double SideA
        {
            get { return sideA; }
            set
            {
                if (value < 0)
                    throw new Exception("Сторона треугольника не может быть отрицательным числом");
                sideA = value;
            }
        }
        public double SideB
        {
            get { return sideB; }
            set
            {
                if (value < 0)
                    throw new Exception("Сторона треугольника не может быть отрицательным числом");
                sideB = value;
            }
        }
        public double SideC
        {
            get { return sideC; }
            set
            {
                if (value < 0)
                    throw new Exception("Сторона треугольника не может быть отрицательным числом");
                sideC = value;
            }
        }

        private double maxSide { get { return Math.Max(SideA, Math.Max(SideB, SideC)); } }
        private double minSide { get { return Math.Min(SideA, Math.Min(SideB, SideC)); } }
        private double averageSide { get { return Perimeter - minSide - maxSide; } }

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


        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!this.IsValid(sideA, sideB, sideC))
                throw new Exception("Треугольник с такими сторонами не может существовать. Большая сторона должна быть меньше суммы двух других");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            var area = Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideA) * (HalfPerimeter - SideB) * (HalfPerimeter - SideC));
            return area;
        }

        public bool IsValid(double sideA, double sideB, double sideC)
        {
            var maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            var minSide = Math.Min(sideA, Math.Min(sideB, sideC));
            var averageSide = sideA + sideB + sideC - maxSide - minSide;
            return maxSide < minSide + averageSide;
        }

        public bool IsRightTriangle()
        {
            return maxSide * maxSide == minSide * minSide + averageSide * averageSide;
        }
    }
}
