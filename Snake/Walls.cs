using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight) 
        {
            wallList = new List<Figure>();
            HorizontalLine horLine = new HorizontalLine(0, mapWidth - 2, 0, '+',ColorSnake.WHITE);
            HorizontalLine botLine = new HorizontalLine( 0, mapWidth - 2,mapHeight - 1, '+',ColorSnake.WHITE);
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+',ColorSnake.WHITE);
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+',ColorSnake.WHITE);

            wallList.Add(horLine);
            wallList.Add(botLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void Drow() 
        {
            foreach (var wall in wallList) 
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure) 
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
    }
}
