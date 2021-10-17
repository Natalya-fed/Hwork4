using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0; // переменная отвечающая за положительные числа
            int c = 0; // переменная отвечающая за отлицательные числа
            Console.WriteLine("Введите последовательность целых чисел. Окончанием последовательности является цифра 0");
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                {
                    b++;
                }
                else if (a < 0)
                {
                    c++;
                }
            } while (a != 0);
            if (b > c)
            {
                Console.WriteLine("Положительных чисел больше, чем отрицательных чисел");
            }
            else if (b < c)
            {
                Console.WriteLine("Отрицательных чисел больше, чем положительных чисел");
            }
            else if (b == c)
            {
                Console.WriteLine("Отрицательных и положительных чисел одинаковое количество");
            }
            Console.ReadKey();
        }
    }
}
