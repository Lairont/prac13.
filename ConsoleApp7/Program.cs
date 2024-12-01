using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Задача 7. Определить статический метод double Average (int m, int n), 
    /// который вычисляет и возвращает среднее арифметическое всех целых от m до n включительно. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Inp("m= ");
            int n = Inp("n=");
            double result = Average(m, n);
            Out(result);
            Console.ReadLine();
        }
        static double Average(int m, int n)
        {
            double amount = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                amount += i;
                count++;
            }
            return count > 0 ? amount/count:0 ;
        }
        static int Inp(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Out(double result)
        {
            Console.WriteLine(result);
        }
    }
}
