using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /// <summary>
    /// Задача 6. Определить статический метод void Numbers (int n), 
    /// который выводит на экран четные числа от 2 до числа n.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Inp("n= ");
            Numbers(n);
            Console.ReadLine();
        }
        static void Numbers(int n)
        {

            for (int i = 2; i <= n; i++)
            {
                if(i%2==0)
                {
                  Out(i);
                }
            }
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
