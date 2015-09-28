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
        public char sim;
        public ColorSnake color;

        public Point() { }
        public Point(int _x, int _y, char _sim, ColorSnake color) 
        {
            x = _x;
            y = _y;
            sim = _sim;
            this.color = color;
        }

        public Point(Point p) 
        {
            x = p.x;
            y = p.y;
            sim = p.sim;
            color = p.color;
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
            if (color == ColorSnake.BLUE)
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (color == ColorSnake.GREEN)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (color == ColorSnake.RED)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (color == ColorSnake.WHITE)
                Console.ForegroundColor = ConsoleColor.White;
            else if (color == ColorSnake.YELLOW)
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }

        public void Clear()
        {
            sim = ' ';
            Draw();
        }

        public bool IsHit(Point food)
        {
            return food.x == this.x && food.y == this.y;
        }
    }
}
