using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryGeometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGeometry.Tests
{
    [TestClass()]
    public class Geometry_libTests
    {
        [TestMethod()]
        public void SfigureTest1()
        {
            double r = 10.0;
            double expected = 314.1;

            Geometry_lib geometry_Lib = new Geometry_lib();
            double actual = geometry_Lib.Sfigure(r);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SfigureTest2()
        {
            double a = 3, b = 4, c = 5;
            double expected = 6.0;

            Geometry_lib geometry_Lib = new Geometry_lib();
            double actual = geometry_Lib.Sfigure(a, b, c);
            Assert.AreEqual(expected, actual);


        }

        [TestMethod()]
        public void Check_triangleTest()
        {
            double a = 3, b = 4, c = 5;
            bool expected = true;

            Geometry_lib geometry_Lib = new Geometry_lib();
            bool actual = geometry_Lib.Check_triangle(a,b,c);
            Assert.AreEqual(expected, actual);
        }
    }
}