using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            
            HorizontalLine hl = new HorizontalLine(0, 78, 0, '-');
            hl.Draw();
            HorizontalLine hl1 = new HorizontalLine(0, 78, 24, '-');
            hl1.Draw();
            VerticalLine vl = new VerticalLine(0, 24, 78, '|');
            vl.Draw();
            VerticalLine vl1 = new VerticalLine(0, 24, 0, '|');
            vl1.Draw();
            Point p1 = new Point(3, 3, '*');
            Snake sn = new Snake(p1, 5, Direction.RIGHT);
            sn.Draw();
            FoodCreator fc = new FoodCreator(80, 25, '$');
            Point food = fc.CreateFood();
            food.Draw();
            while (true) 
            {
                if (sn.Eat(food)) 
                {
                    food = fc.CreateFood();
                    food.Draw();
                }
                else
                    sn.Move(); 
                Thread.Sleep(100);

                if (Console.KeyAvailable) 
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    sn.HandleKey(key.Key);
                }
            }
            
            
            //Console.ReadLine();
        }
    }
}
