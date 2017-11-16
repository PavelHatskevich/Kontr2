using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo k;
            int x = 50;
            int y = 20;
            int h = 100;
            Console.WriteLine("при попадании на границу консоли отнимается здоровье");
            Console.WriteLine("health " + h);
            do
            {
                if (x <= 0 || y <= 0)
                {
                    h = h - 50;
                    Console.WriteLine("health " + h);
                    if (h <= 0)
                    {
                        Console.WriteLine("game over");
                    }
                    Console.SetCursorPosition(1, 1);
                    Console.ReadKey();
                    Console.Clear();
                    x++;
                    y++;
                    Console.SetCursorPosition(x, y);
                }
                Console.SetCursorPosition(x, y);
                Console.Write((char)2);
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.LeftArrow)
                    x--;
                if (k.Key == ConsoleKey.DownArrow)
                    y++;
                if (k.Key == ConsoleKey.UpArrow)
                    y--;
                if (k.Key == ConsoleKey.RightArrow)
                    x++;
                Console.Clear();
            }
            while (k.Key != ConsoleKey.Escape);

        }
    }
}

