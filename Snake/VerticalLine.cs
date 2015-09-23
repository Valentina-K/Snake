using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yUdown, int x, char sim) 
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yUdown; y++) 
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
    }
}
