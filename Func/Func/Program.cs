using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];


            Console.WriteLine("Введите числа в диапазоне (100 - 199)");
            void calculation(
            for (int i = 0; i < 7; i++) {
                Console.WriteLine($"Введите {i + 1} - ое число");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (100 > numbers[i] || numbers[i] > 199)
                {
                    return;
                }
            }
            Console.Clear();
            int Sum = 0;
            for(int i = 0; i < 7;i++) {
                Sum += numbers[i];
            }

            Console.WriteLine($"Сумма чисел :{Sum}");
        }
    }
}
