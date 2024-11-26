using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_13_Куделин.Н_215гр
{
    /// <summary>
    /// Найти минимальную величину из двух целых переменных a, b, 
    /// используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static int InputValue(string varName)
        {

            Console.Write($"Введите значение переменной {varName}: ");
            return int.Parse(Console.ReadLine());
        }
        static int FindMinimum(int x, int y)
        {
            return x < y ? x : y;
        }
        static void PrintResult(int result)
        {
            Console.WriteLine($"Минимальная величина между введенными числами: {result}");
        }
        static void Main()
        {


            int x = InputValue("a");
            int y = InputValue("b");
            int minimum = FindMinimum(x,y);
            PrintResult(minimum);
            Console.Read();
        }
    }
}
