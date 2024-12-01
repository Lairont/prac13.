using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Задача 5. Определить статический метод int Meters (int k, int m), который принимает два целых аргумента (километры k, метры m)
    /// и возвращает количество метров. Используя этот метод, вычислить количество метров для расстояния
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = Inp("Километры: ");
            int m = Inp("Метры: ");
            int result = Meters(k, m);
            Out(result);
            Console.ReadLine();
        }
        static int Meters(int k, int m)
        {
            int distance= 0;
            for (int i = 0; i < k; i++)
            {
                distance += 1000;
            }
            for (int i = 0; i < m; i++)
            {
                distance += 1;
            }
            return distance;

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
