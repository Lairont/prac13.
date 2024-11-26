using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Задача 4. Определить статический метод int Seconds (int h, int m, int s),
    /// который принимает три целых аргумента (часы h, минуты m и секунды s) и возвращает количество секунд,
    /// прошедших с начала дня. Используя этот метод, вычислить количество секунд, прошедших с начала дня при:
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int h = Inp("часов: ");
            int m = Inp("минут: ");
            int s = Inp("секунд: ");
            int result = Seconds(h, m, s);
            Out(result);
            Console.ReadLine();
        }
        static int Seconds(int h, int m, int s)
        {
            return h * 3600 + m * 60 + s;
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
