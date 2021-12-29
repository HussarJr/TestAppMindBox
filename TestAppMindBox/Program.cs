using System;
using ClassLibraryGeometry;

namespace TestAppMindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry_lib geometry_Lib = new Geometry_lib();
            string sql = "Select * from products join categories on products.id = categories.products_id ";
            Console.WriteLine(geometry_Lib.Sfigure(20));
            Console.WriteLine(geometry_Lib.Sfigure(213,213,123));
            Console.WriteLine(geometry_Lib.Check_triangle(213, 213, 123));
            Console.WriteLine(sql);
        }
    }
}
