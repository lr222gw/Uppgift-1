using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangelUnitTest
{
    [TestClass]
    public class UnitTestTriangel
    {
        [TestMethod]
        public void likBentTest()
        {
            Triangle tri = new Triangle(4.5, 4.5, 60.6);
            Assert.IsTrue(tri.isIsosceles());
            
        }
        public void likBentTest()
        {
            Triangle tri = new Triangle(4.5, 4.5, 60.6);
            Assert.IsTrue(tri.isIsosceles());

        }
    }
}
