using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    internal class Program
    {
        //static void MinMax(double x, double y)
        //{
        //    if (x > y)
        //    {
        //        double z = x;
        //        x = y;
        //        y = z;
        //    }

        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("a");
        //    double a = Convert.ToSingle(Console.ReadLine());
        //    Console.WriteLine("b");
        //    double b = Convert.ToSingle(Console.ReadLine());
        //    Console.WriteLine("c");
        //    double c = Convert.ToSingle(Console.ReadLine());
        //    Console.WriteLine("d");
        //    double d = Convert.ToSingle(Console.ReadLine());

        //    MinMax(a, b);
        //    MinMax(d, c);
        //    MinMax(a, c);
        //    MinMax(b, d);
        //    Console.WriteLine($"Минимальное число {Math.Round(a,2)}");
        //    Console.WriteLine($"Максимальное число {Math.Round(d, 2)}");

        //static void Even()
        //{
        //    //return K % 2 == 0;
        //    Console.WriteLine("Введите число:");
        //    int K = Convert.ToInt16(Console.ReadLine());
        //    bool B;
        //    if (K%2==0)
        //    {
        //        B = true;
        //    }
        //    else B = false;
        //    Console.WriteLine(B);
        //}
        //static void Main(string[] args)
        //{
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Even();
        //    }
        //}

        static void Fib(int N)
        {
            Console.WriteLine( N - 1 + N - 2 );
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int N;
                Console.WriteLine("Введите число");
                N = Convert.ToInt32(Console.ReadLine());
                Fib(N);
            }
        }
    }
}


