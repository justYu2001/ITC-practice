using System;

namespace _93_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(' ');
                int h, h2, d, times = 0;
                h = int.Parse(data[0]);
                d = int.Parse(data[1]);
                h2 = h / 2 - d / 5;
                if (h2 > 0)
                    times++;
                while (h2 >= 0)
                {
                    Console.Write("{0} ", h2);
                    h2 = h2 / 2 - d / 5;
                    if (h2 > 0)
                        times++;
                }
                Console.WriteLine(times);
            }
        }
    }
}
