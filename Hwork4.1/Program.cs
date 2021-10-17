using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N при условии, что N>0");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;

            for (int i = 1; i <= n; i++)
            {
                s = s + ((2 * i) - 1);
                Console.WriteLine($" {s} ");
            }
            Console.WriteLine($"Квадрат числа {n} = {s}");
            Console.ReadKey();
        }
    }
}
