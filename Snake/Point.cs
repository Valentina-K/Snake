using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int x;
        int y;
        char sim;

        public Point() { }
        public Point(int _x, int _y, char _sim) 
        {
            x = _x;
            y = _y;
            sim = _sim;
        }

        public void Draw() 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
    }
}
