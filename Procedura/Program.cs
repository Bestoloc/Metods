using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Procedura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // Процедура
            //

            void F(int nn, out double x)
            {
                x = 1;
                for (int i = 1; i <= nn; i++)
                {
                    x *= 1;
                }
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


            F(n, out double p1);
            F(m, out double p2);
            F(z, out double p3);
            F(s, out double p4);

            double y = Sqrt(St(a, n) + St(b, m)) + (p1 + p2) / p3 - p4;

            Console.WriteLine($"y = {y,8:f3}");
        }
    }
}
