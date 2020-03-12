using NUnit.Framework;
using System;

namespace OPLab1
{

    public class Tests
    {
        Point v = new Point(5, 5);
        Square s1 = new Square(new Point(0, 0), new Point(2, 2));
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void PerimeterTest()
        {
            double expectation = 8;
            double result = s1.getPermiter();
            Square.StupidMethod(15);
            Assert.AreEqual(expectation, result);
        }
        
        [Test]
        public void AreaTest()
        {
            double expectation = 4;
            double result = s1.getArea();
            Console.WriteLine("hello");
            Assert.AreEqual(expectation, result);
        }
        
        [Test] 
        public void moveTest()
        {
            s1.move(v);
            string expectation = "(7,7)";
            string result = s1.getUpper();
            Assert.AreEqual(expectation, result);
        }

        [Test]
        public void OutputTest()
        {
            s1.move(v);
            string expectation = "(7,7),(5,5),4,8";
            string result = s1.ToString();
            Assert.AreEqual(expectation, result);
        }
    }
}