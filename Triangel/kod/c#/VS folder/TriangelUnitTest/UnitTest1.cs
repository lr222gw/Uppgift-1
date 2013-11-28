using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangelUnitTest
{
    [TestClass]
    public class UnitTestTriangel
    {
        //Test för metoden isIsosceles
        [TestMethod]
        public void isIsosceles_likBentTest_Giltigt()
        {

            Triangle tri = new Triangle(4.5, 4.5, 60.6);

            Assert.IsTrue(tri.isIsosceles()); // om denna metod (tri.isIsosceles()) 
                                              // returnerar true så kastas ingen felexception 
                                              // dvs testet lyckas. 
                                              // alltså om Assert.IsTrue() har en metod(eller variabel)
                                              // i sina parametrar som är true så kastar metoden true
                                              
            
        }
        [TestMethod]
        public void isIsosceles_likBentTest_oGiltigt()
        {
            Triangle tri = new Triangle(4.5, 4.6, 60.6);
            Assert.IsFalse(tri.isIsosceles());

        }
        //Test för metoden isEquilateral
        [TestMethod]
        public void isEquilateral_likaSidorLength_Giligt()
        {
            Triangle tri = new Triangle(6.0, 6.0, 6.0); 
            Assert.IsTrue(tri.isEquilateral());
        }
        [TestMethod]
        public void isEquilateral_likaSidorLength_oGiligt()
        {
            Triangle tri = new Triangle(5.0, 1.0, 7.0);
            Assert.IsFalse(tri.isEquilateral());
        }

        //Test för metoden "isScalene"
        [TestMethod]
        public void isScalene_OlikaLength_Giligt()
        {
            Triangle tri = new Triangle(6.0, 5.0, 3.0); 
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        public void isScalene_OlikaLength_oGiligt()
        {
            Triangle tri = new Triangle(6.0, 6.0, 6.0); 
            Assert.IsFalse(tri.isScalene());
        }

        // Test för Triangle(Point a, Point b, Point c)
        [TestMethod]
        public void PointKonstruktornABC()
        {
            Triangle tri = new Triangle(new Point(0 , 0), new Point(4, 0), new Point(2, 2));
            //Testar med isIsosceles()-metoden då den är den enda som fungerar enligt mina tester..
            Assert.IsTrue(tri.isIsosceles()); 
        }

        //Test för Triangle(Point[] s)
        [TestMethod]
        public void PointKonstruktornArray_likbent()
        {
            Point[] pArr = new Point[3];
            pArr[0].x = 4;
            pArr[0].y = 0;
            pArr[1].x = 4;
            pArr[1].y = 0;
            pArr[2].x = 2;
            pArr[2].y = 2;
            Triangle tri = new Triangle(pArr);
            //Testar med isIsosceles()-metoden då den är den enda som fungerar enligt mina tester..
            Assert.IsTrue(tri.isIsosceles());
            //Returnerar false.. alltså fungerar inte pointkonstruktorn som den ska?
        }
        [TestMethod]
        public void PointKonstruktornArray_OlikaSidor()
        {
            Point[] pArr = new Point[2];
            pArr[0].x = 5;
            pArr[0].y = 0;
            pArr[1].x = 4;
            pArr[1].y = 0;
            pArr[2].x = 2;
            pArr[2].y = 2;
            Triangle tri = new Triangle(pArr);
            //Testar med isIsosceles()-metoden då den är den enda som fungerar enligt mina tester..
            Assert.IsTrue(tri.isScalene());
            //Returnerar false.. alltså fungerar inte pointkonstruktorn som den ska?
        }
        [TestMethod]
        public void PointKonstruktornArray_MerArray()
        {
            Point[] pArr = new Point[2];
            pArr[0].x = 5;
            pArr[0].y = 0;
            pArr[1].x = 4;
            pArr[1].y = 0;
            pArr[2].x = 2;
            pArr[2].y = 2;
            pArr[3].x = 4;
            pArr[3].y = 4;
            Triangle tri = new Triangle(pArr);
            //Testar med isIsosceles()-metoden då den är den enda som fungerar enligt mina tester..
            Assert.IsFalse(tri.isScalene());
            //Borde inte gå att mata in mer än 3 sidor..
        }
        [TestMethod]
        public void PointKonstruktornArray_LikaSidor()
        {
            Point[] pArr = new Point[2];
            pArr[0].x = 5;
            pArr[0].y = 0;
            pArr[1].x = 5;
            pArr[1].y = 0;
            pArr[2].x = 5;
            pArr[2].y = 0;
            Triangle tri = new Triangle(pArr);
            //Testar med isIsosceles()-metoden då den är den enda som fungerar enligt mina tester..
            Assert.IsTrue(tri.isEquilateral());
            //Returnerar false.. alltså fungerar inte pointkonstruktorn som den ska?
        }

        //Test för Triangle(double[] s)
        [TestMethod]
        public void DoubleKonstruktornArray() //behöver bara testa med en metod (isIsoscles) då det är den enda som fungerar..
        {
            double[] dArr = new double[3];
            dArr[0] = 2.2;
            dArr[1] = 2.2;
            dArr[2] = 4.4;
            Triangle tri = new Triangle(dArr);
            //Testar med isIsosceles()-metoden då den är den enda som fungerar enligt mina tester..
            Assert.IsTrue(tri.isIsosceles());
            //Returnerar false.. alltså fungerar inte pointkonstruktorn som den ska?
        }
        //Testar med en ogiltig triangel i ett annars fungerande test!
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OgiltigTriangel()
        {
            Triangle tri = new Triangle(0.0, 0.0, 0.0);
            // Denna metod testar om triangeln är ogiltig, vi räknar med
            // att få ett Felmedellande "ArgumentNullException", om vi ej får det
            // så är testet ej avklararat! 
        }
    }
}
