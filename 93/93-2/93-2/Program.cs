using System;

namespace _93_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int w, r;
                double c, total;
                string input = Console.ReadLine();
                string[] data = input.Split(' ');
                w = int.Parse(data[0]);
                r = int.Parse(data[1]);
                c = double.Parse(data[2].Substring(0, data[2].Length - 1));
                while (w < 0 || r < 200 || c < 0.4)
                {
                    Console.WriteLine("請重新輸入(必須W>=0,R>=200,c>=0.4)");
                    input = Console.ReadLine();
                    data = input.Split(' ');
                    w = int.Parse(data[0]);
                    r = int.Parse(data[1]);
                    c = double.Parse(data[2].Substring(0, data[2].Length - 1));
                }
                if (w == 0)
                {
                    total = (350 + r) * (0.2 + c);
                    Console.Write("{0}ps", total);
                }
                else
                {
                    total = (350 + r / 2) * (c / 2 + w * 0.04) + 350 + (350 / w + r / 2) * (c / 2 + 0.2);
                    Console.Write("{0}ps", total);
                }
            }
        }
    }
}
