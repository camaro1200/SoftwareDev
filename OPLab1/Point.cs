using System;
using System.ComponentModel.Design;

namespace OPLab1
{
    public class Point
    {
        public int x;
        public int y;
        
        
        public Point(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}