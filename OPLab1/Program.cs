using System;

namespace OPLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point v = new Point(5, 5);
            Square s1 = new Square(new Point(0, 0), new Point(2, 2));

            s1.getArea();
            s1.getPermiter();
            s1.getLower(); 
            s1.getUpper();
           
        }
    }
}