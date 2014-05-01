//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides;
//Two sides and an angle between them. Use System.Math.

using System;

namespace _04.SurfaceOfTriangleCalculation
{
    class SurfaceOfTriangleCalculation
    {
        static double CalculateSurfaceOfTriangle(double side, double altitude)
        {
            double area = (side * altitude) / 2;
            return area;
        }

        static double CalculateSurfaceOfTriangle(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return area;
        }

        static double CalculateSurfaceOfTriangle(double sideA, double sideB, int angle)
        {
            double area = (sideA * sideB * Math.Sin(Math.PI * angle / 180)) / 2;
            return area;
        }
        static void Main()
        {
            Console.WriteLine("Area (given a, ha) = {0:F2} ", CalculateSurfaceOfTriangle(6, 4));
            Console.WriteLine("Area (given a,b,c) = {0:F2}", CalculateSurfaceOfTriangle(3, 4, 5.0));
            Console.WriteLine("Area (given a, b, angle between them) = {0:F2}", CalculateSurfaceOfTriangle(2, 2, 60));
        }
    }
}
