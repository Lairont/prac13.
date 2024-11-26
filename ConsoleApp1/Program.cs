using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Задача 1. Найти минимальную величину из двух целых переменных a, b, используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        static int Inp(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string [] args)
        {
            int a = Inp("a= ");
            int b = Inp("b= ");
            int result = Min(a, b);
            Out(result);
            Console.ReadLine();
        }
        static void Out(int result)
        {
            Console.WriteLine(result);
        }
        
    }
}
