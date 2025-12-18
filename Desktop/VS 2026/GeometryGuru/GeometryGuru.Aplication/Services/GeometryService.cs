using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGuru.Aplication.Services
{
    public class GeometryService
    {

        public double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double CircleLength(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public double TriangleArea(double tomon1, double tomon2, double tomon3)
        {
            double s = (tomon1 + tomon2 + tomon3) / 2;
            return Math.Sqrt(s * (s - tomon1) * (s - tomon2) * (s - tomon3));
        }
        public double TrianglePerimeter(double tomon1, double tomon2, double tomon3)
        {
            return tomon1 + tomon2 + tomon3;
        }
        public double RectangleArea(double tomon1, double tomon2)
        {
            return tomon1 * tomon2;
        }
        public double RectanglePerimeter(double tomon1, double tomon2)
        {
            return 2 * (tomon1 + tomon2);
        }
        public double ParallelogramArea(double tomon1, double balandlik)
        {
            return tomon1 * balandlik;
        }
        public double ParallelogramPerimeter(double tomon1, double tomon2)
        {
            return 2 * (tomon1 + tomon2);
        }
        public double SquareArea(double tomon1)
        {
            return tomon1 * tomon1;
        }
        public double SquarePerimeter(double tomon1)
        {
            return 4 * tomon1;
        }
        public double TrapezoidArea(double tomon1, double tomon2, double balandlik)
        {
            return ((tomon1 + tomon2) / 2) * balandlik;
        }
        public double TrapezoidPerimeter(double tomon1, double tomon2, double tomon3, double tomon4)
        {
            return tomon1 + tomon2 + tomon3 + tomon4;
        }


    }
}
