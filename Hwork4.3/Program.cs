using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные числа А,В,С.");
            Console.WriteLine("На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений).");
            Console.WriteLine("Найти количество квадратов, размещенных на прямоугольнике.");
            Console.WriteLine("Введите положительное число А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите положительное число В");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите положительное число С");
            int c = Convert.ToInt32(Console.ReadLine());
            int g;
            int e = 0; // кол-во квадратов по стороне А
            int f = 0; // кол-во квадратов по стороне В
            while (a >= c)
            {
                a = a - c;
                e++;
            }
            while (b >= c)
            {
                b = b - c;
                f++;
            }
            g = e * f; // не знаю как без умножения справиться и без добавления другого цикла
            Console.WriteLine($"Количество квадратов, размещенных на прямоугольнике равно {g}");
            Console.ReadKey();
        }
    }
}
