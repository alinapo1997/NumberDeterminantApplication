using System;

namespace NumberDeterminantApplication
{
    /// <summary>
    /// Приложение по определению чётного или нечётного числа
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чётное или нечётное?");
            Console.WriteLine("Введите целое число:");
            int intValue = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            string result = intValue % 2 == 0 ? " - чётное число" : " - нечётное число";
            Console.WriteLine(intValue + result);
            Console.ReadKey();
        }
    }
}
