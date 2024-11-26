using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Задача 2. Найти минимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static int Min(int a, int b, int c)
        {
            return a < b ? (a < c ? a : c) : (b < c ? b : c);
        }
        static int Inp(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a = Inp("a= ");
            int b = Inp("b= ");
            int c = Inp("c= ");
            int result = Min(a,b,c);
            Out(result);
            Console.ReadLine();
        }
        static void Out(int result)
        {
            Console.WriteLine(result);
        }
    }
}
