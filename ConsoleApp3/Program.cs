using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Задача 3. Найти s=min(a, b) + min(c, d), используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = Inp("a= ");
            int b = Inp("b= ");
            int c = Inp("c= ");
            int d = Inp("d= ");
            int result = Min(a, b) + Min(c, d);
            Out(result);
            Console.ReadLine();
        }
        static int Min(int x, int y)
        {
            return x < y ? x : y;

        }
        static int Inp(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Out(int result)
        {
            Console.WriteLine(result);
        }
    }
}
