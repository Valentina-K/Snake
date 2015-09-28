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

        public Point(Point p) 
        {
            x = p.x;
            y = p.y;
            sim = p.sim;
        }

        public void Move(int offset,Direction d) 
        {
            if (d == Direction.RIGHT) { x = x + offset; }
            if (d == Direction.LEFT) { x = x - offset; }
            if (d == Direction.DOWN) { y = y + offset; }
            if (d == Direction.UP) { y = y - offset; }
        }

        public void Draw() 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }

        internal void Clear()
        {
            sim = ' ';
            Draw();
        }
    }
}
