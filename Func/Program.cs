using System;


namespace Func
{
    internal class Program

    {
        static void Calculator(int numbers, out int  Sum, out int proizvd)
        {

            Sum = 0;
            proizvd = 1;
            for (int i = 0; i < 7; i++)
            {
                Sum += numbers;
                proizvd *= numbers;
            }

            Console.WriteLine($"Сумма чисел :{Sum}");
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[7];


            Console.WriteLine("Введите числа в диапазоне (100 - 199)");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Введите {i + 1} - ое число");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] < 100 || numbers[i] > 199)
                {
                    Console.WriteLine("Число должно быть в диапазоне от 100 до 199. Попробуйте снова.");
                    i--;
                }
                Console.Clear();
                for (int l = 0; l < 7; l++)
                {
                    int Sum, proizvd;
                    Calculator(numbers[i], out Sum, out proizvd);

                    Console.WriteLine($"Сумма цифр {Sum}, Произведение цифр {proizvd}");
                }

            }
        }
    }
}

