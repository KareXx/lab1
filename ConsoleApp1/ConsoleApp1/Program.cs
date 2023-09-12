using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть число: ");
            int n = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(n);
            Console.WriteLine($"Факторіал числа {n} дорівнює {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1; // Факторіал 0 дорівнює 1
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}
