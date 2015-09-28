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
            int t;
            Console.WriteLine("Выберите свой уровень:\nвысокий - 1, средний - 2 или низкий - 3");
            ConsoleKeyInfo cinf= Console.ReadKey();
            t = (cinf.KeyChar - 48) * 100;
            Console.Clear();
            Console.SetBufferSize(80, 25);
            Walls wall = new Walls(80, 25);
            wall.Drow();
                    
            Point p1 = new Point(3, 3, '*');
            Snake sn = new Snake(p1, 5, Direction.RIGHT);
            sn.Draw();
            FoodCreator fc = new FoodCreator(80, 25, '$');
            Point food = fc.CreateFood();
            food.Draw();
            while (true) 
            {
                if (wall.IsHit(sn) || sn.IsHitTail())
                    break;
                if (sn.Eat(food)) 
                {
                    food = fc.CreateFood();
                    food.Draw();
                }
                else
                    sn.Move(); 
                Thread.Sleep(t);

                if (Console.KeyAvailable) 
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    sn.HandleKey(key.Key);
                }
            }
            Console.Clear();
            Console.WriteLine("Игра окончена! \nСпасибо за внимание.");
            Console.ReadLine();
        }
    }
}
