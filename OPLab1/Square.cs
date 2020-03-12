using System;

namespace OPLab1
{
    public class Square
    {
        public Point lower;
        public Point upper;
        public double area;
        public double permiter;
        public Color c;

        public Square(Point p1, Point p2)
        {
            lower = p1;
            upper = p2;
            getArea();
            getPermiter();
        }

        public double getArea()
        {
            area = Math.Abs(upper.y - lower.y) * Math.Abs(upper.x - lower.x);
            return area;
        }


        public double getPermiter()
        {
            permiter = Math.Abs(upper.y - lower.y) * 2 + Math.Abs(upper.x - lower.x) * 2;
            return permiter;
        }

        public double makeCube(int width)
        {
            return width * area;
        }

        public void move(Point v)
        {
            lower.x += v.x;
            lower.y += v.y;
            upper.x += v.x;
            upper.y += v.y;
        }

        public void setGreen()
        {
            c.color = "green";
        }

        public void setRed()
        {
            c.color = "red";
        }

        public void setBlue()
        {
            c.color = "blue";
        }

        public static void StupidMethod(int x)
        {
            Console.WriteLine(x);
            //_snip2
            //_snip3
            //_snip4
        }

        public string getUpper()
        {
            return upper.ToString();
        }

        public string getLower()
        {
            return lower.ToString();
        }

        public override string ToString()
        {
            return $"{upper},{lower},{area},{permiter}";
        }
    }
}