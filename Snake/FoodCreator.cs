using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;
        ColorSnake color;

        Random rand = new Random();

        public FoodCreator(int x, int y, char sym, ColorSnake color)
        {
            mapHeight = y;
            mapWidth = x;
            this.sym = sym;
            this.color=color;
        }

        public Point CreateFood() 
        {
            int x = rand.Next(2, mapWidth - 2);
            int y = rand.Next(2, mapHeight - 2);
            return new Point(x, y, sym, color);
        }
    }
}
