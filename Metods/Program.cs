using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // Функция
            //

            double Fact(int nn)
            {
                double x = 1;
                for(int i = 1; i <= nn; i++)
                {
                    x *= 1;
                }
                return x;
            }

            float St(int osn, int nn)
            {
                float st = 1;
                for (int i = 1; i <= nn; i++)
                {
                    st = st * osn;
                }
                return st;
            }

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());
            Console.Write("s = ");
            int s = int.Parse(Console.ReadLine());


            double y = Sqrt(St(a, n) + St(b, m)) + (Fact(n + m)) / Fact(z) - Fact(s);

            Console.WriteLine($"y = {y,8:f3}");

        }
    }
}
