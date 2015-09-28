using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(3, 5, '#');
            p1.Draw();
            p2.Draw();

            HorizontalLine hl = new HorizontalLine(0, 78, 0, '+');
            hl.Draw();
            HorizontalLine hl1 = new HorizontalLine(0, 78, 24, '+');
            hl1.Draw();
            VerticalLine vl = new VerticalLine(0, 24, 78, '+');
            vl.Draw();
            VerticalLine vl1 = new VerticalLine(0, 24, 0, '+');
            vl1.Draw();

            Console.ReadLine();
        }
    }
}
