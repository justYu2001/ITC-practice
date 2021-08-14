using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _93_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int x1, x2, x3, x4, y1, y2, y3, y4;
                Console.Write("A(X1,Y1)=");
                string input = Console.ReadLine();
                string[] data = input.Split(' ');
                x1 = int.Parse(data[0]);
                y1 = int.Parse(data[1]);
                Console.Write("B(X2,Y2)=");
                input= Console.ReadLine();
                data = input.Split(' ');
                x2 = int.Parse(data[0]);
                y2 = int.Parse(data[1]);
                Console.Write("C(X3,Y3)=");
                input = Console.ReadLine();
                data = input.Split(' ');
                x3 = int.Parse(data[0]);
                y3 = int.Parse(data[1]);
                Console.Write("D(X4,Y4)=");
                input = Console.ReadLine();
                data = input.Split(' ');
                x4 = int.Parse(data[0]);
                y4 = int.Parse(data[1]);
                if(x3>=x1&&x3<=x2|| x3 >= x2 && x3 <= x1)
                {
                    if(y3 >= y1 && y3 <= y2 || y3 >= y2 && y3 <= y1)
                    {
                        Console.WriteLine("線有交叉");
                    }
                }
                else
                    Console.WriteLine("線無交叉");
            }
        }
    }
}
