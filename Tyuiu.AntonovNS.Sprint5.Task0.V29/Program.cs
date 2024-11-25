using System.IO;
using Tyuiu.AntonovNS.Sprint5.Task0.V29.Lib;
namespace Tyuiu.AntonovNS.Sprint4.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rad = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Антонов Н.С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("#* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Антонов Никита Сергеевич |  ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и                     *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
            Console.WriteLine("* (массив): (False, False, True, True, False, False), при                 *");
            Console.WriteLine("* x = 3105, y = 275                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            string path = ds.SaveToFileTextData(x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(path);
            Console.ReadKey();
        }
    }
}