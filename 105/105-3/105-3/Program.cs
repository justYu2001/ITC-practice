using System;

namespace _105_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string chooise, coordinate, judgement = "1";
            int x1 = 0, x2 = 0, x3 = 0, y1 = 0, y2 = 0, y3 = 0, counter = 1;
            while (judgement == "1")
            {
                Console.WriteLine("請選擇操作項目:");
                Console.WriteLine("       <1>輸入二點座標<x1,y1>,<x2,y2>繪一線:");
                Console.WriteLine("       <2>輸入三個頂點座標<x1,y1>,<x2,y2>,<x3,y3>繪三角形:");
                Console.WriteLine("       <3>上題三角形水平翻轉:");
                Console.Write("請選擇:");
                chooise = Console.ReadLine();
                if (chooise == "1")
                {
                    Console.Write("x1,y1\tx2,y2:");
                    coordinate = Console.ReadLine();
                    string[] xy = coordinate.Split(' ');
                    x1 = int.Parse(xy[0]);
                    y1 = int.Parse(xy[1]);
                    x2 = int.Parse(xy[2]);
                    y2 = int.Parse(xy[3]);
                    DrawLine(x1, y1, x2, y2, counter);
                    Console.SetCursorPosition(0, 36 * counter);
                    Console.Write("繼續:請按1，結束:請按0: ");
                    judgement = Console.ReadLine();
                    counter++;
                }
                else if (chooise == "2")
                {
                    Console.Write("x1,y1\tx2,y2\tx3,y3:");
                    coordinate = Console.ReadLine();
                    string[] xy = coordinate.Split(' ');
                    x1 = int.Parse(xy[0]);
                    y1 = int.Parse(xy[1]);
                    x2 = int.Parse(xy[2]);
                    y2 = int.Parse(xy[3]);
                    x3 = int.Parse(xy[4]);
                    y3 = int.Parse(xy[5]);
                    DrawTriangle(x1, y1, x2, y2, x3, y3, counter);
                    Console.SetCursorPosition(0, 36 * counter);
                    Console.Write("繼續:請按1，結束:請按0: ");
                    judgement = Console.ReadLine();
                    counter++;
                }
                else if (chooise == "3")
                {
                    FlipTriangle(x1, y1, x2, y2, x3, y3, counter);
                    Console.SetCursorPosition(0, 36 * counter);
                    Console.Write("繼續:請按1，結束:請按0: ");
                    judgement = Console.ReadLine();
                    counter++;
                }
            }
        }

        static void DrawLine(int x1, int y1, int x2, int y2, int counter)
        {
            int point_x, point_y, constant, bigger_piont, smaller_piont;
            if (x2 == x1)
            {
                if (y2 > y1)
                {
                    bigger_piont = y2;
                    smaller_piont = y1;
                }
                else
                {
                    bigger_piont = y1;
                    smaller_piont = y2;
                }
                for (int i = smaller_piont; i <= bigger_piont; i++)
                {
                    point_x = x1;
                    point_y = (36 * (counter - 1) + 35) - i;
                    Console.SetCursorPosition(point_x, point_y);
                    Console.Write("*");
                }
            }
            else
            {
                if (x2 > x1)
                {
                    bigger_piont = x2;
                    smaller_piont = x1;
                }
                else
                {
                    bigger_piont = x1;
                    smaller_piont = x2;
                }
                constant = y1 - x1 * (y2 - y1) / (x2 - x1);
                for (int i = smaller_piont; i <= bigger_piont; i++)
                {
                    point_x = i;
                    point_y = (36 * (counter - 1) + 35) - (point_x * (y2 - y1) / (x2 - x1) + constant);
                    Console.SetCursorPosition(point_x, point_y);
                    Console.Write("*");
                }
            }
        }

        static void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3, int counter)
        {
            DrawLine(x1, y1, x2, y2, counter);
            DrawLine(x2, y2, x3, y3, counter);
            DrawLine(x1, y1, x3, y3, counter);
        }

        static void FlipTriangle(int x1, int y1, int x2, int y2, int x3, int y3, int counter)
        {
            int[] x = { x1, x2, x3 };
            int[] y = { y1, y2, y3 };
            int number = 0, max_y = 0;
            for (int i = 0; i < 3; i++)
            {
                if (y[i] > max_y)
                {
                    max_y = y[i];
                    number = i;
                }
            }
            y3 = max_y;
            x3 = x[(number + 1) % 3] - x[number] + x[((number - 1) + 3) % 3];
            x1 = x[(number + 1) % 3];
            y1 = y[(number + 1) % 3];
            x2 = x[((number - 1) + 3) % 3];
            y2 = y[((number - 1) + 3) % 3];
            DrawTriangle(x1, y1, x2, y2, x3, y3, counter);
        }
    }
}
