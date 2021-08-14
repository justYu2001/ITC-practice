using System;

namespace _93_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int r, n, a = 1, b = 1, times = 0;
                r = int.Parse(Console.ReadLine());
                n = (int)Math.Sqrt(r);
                Console.WriteLine("count\tx\ty");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (a * a + b * b == r)
                        {
                            times++;
                            Console.WriteLine("{0}\t{1}\t{2}", times, a, b);
                            b++;
                        }
                        else
                            b++;
                    }
                    b = 1;
                    a++;
                }
                if (times == 0)
                    Console.WriteLine("Sorry,No answer found.");
                else if (times == 1)
                    Console.WriteLine("There is 1 possible answer.");
                else
                    Console.WriteLine("There are {0} possible answer.", times);
            }
        }
    }
}
