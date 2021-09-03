using System;

namespace ClassLibraryGeometry
{
    public class Geometry_lib
    {
        public static double Sfigure(double radius) //площадь круга по радиусу
        {
            const double PI = 3.141;
            double s = PI * (radius * radius);
            return s;
        }
        public static double Sfigure(double a, double b, double c) //площадь треугольника по 3 сторонам
        {
            double P = (a + b + c) / 2;
            double s = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return s;
        }
        public static bool Check_triangle(double a, double b, double c) //проверка треуголника на прямоугольность
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                double x;
                switch (i)
                {
                    case 0:
                        x = ((a * a) + (c * c) - (b * b)) / (2 * a * c);
                        if (x == 0)
                        {
                            count++;
                        }
                        break;
                    case 1:
                        x = ((a * a) + (b * b) - (c * c)) / (2 * a * b);
                        if (x == 0)
                        {
                            count++;
                        }
                        break;
                    case 2:
                        x = ((b * b) + (c * c) - (a * a)) / (2 * c * b);
                        if (x == 0)
                        {
                            count++;
                        }
                        break;
                }
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double Sfigure(int[] arr)
        {
           
            double s = 0;
            return s;
        }
    }
}
