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

        Random rand = new Random();

        public FoodCreator(int x, int y, char sym)
        {
            mapHeight = y;
            mapWidth = x;
            this.sym = sym;
        }

        public Point CreateFood() 
        {
            int x = rand.Next(2, mapWidth - 2);
            int y = rand.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
