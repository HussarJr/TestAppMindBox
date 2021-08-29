using System;
using ClassLibraryGeometry;

namespace TestAppMindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Geometry_lib.Sfigure(20));
            Console.WriteLine(Geometry_lib.Sfigure(213,213,123));
            Console.WriteLine(Geometry_lib.Check_triangle(213, 213, 123));
        }
    }
}
